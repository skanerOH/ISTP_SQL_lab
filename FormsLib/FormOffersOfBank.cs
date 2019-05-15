using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLib
{
    public partial class FormOffersOfBank : Form
    {
        private int b_id;
        public FormOffersOfBank(int id)
        {
            b_id = id;
            InitializeComponent();
            comboBoxClientType.SelectedIndex = 0;
            comboBoxOfferType.SelectedIndex = 0;
            dataTableOfferAdvTableAdapter.FillByb_ID(dataSetMain.DataTableOfferAdv, b_id);
        }

        private void FormOffersOfBank_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            int client_type = comboBoxClientType.SelectedIndex;
            int credit_count_max = (int)numericUpDownCreditCountMax.Value;
            int deposit_count_min = (int)numericUpDownDepositCountMin.Value;
            int sum_max = (int)numericUpDownSumMax.Value;
            int sum_min = (int)numericUpDownSumMin.Value;
            int c_ID;
            if (CheckCorrectness())
            {
                global::System.Nullable<int> c_count = (int)queriesTableAdapter1.GetCountOfConditions(client_type, credit_count_max, deposit_count_min, sum_max, sum_min);
                if (c_count > 0)
                {
                    c_ID = (int)queriesTableAdapter1.GetConditionIDByAll(client_type, credit_count_max, deposit_count_min, sum_max, sum_min);
                    offersTableAdapter1.AddNewOffer(b_id, c_ID, textBoxOfferName.Text, comboBoxOfferType.SelectedIndex);
                }
                else
                {
                    conditionsTableAdapter1.AddNewCondition(client_type, GetSumConditionsID(sum_max, sum_min), GetContractCountConditionsID(credit_count_max, deposit_count_min));
                    c_ID = (int)queriesTableAdapter1.GetConditionIDByAll(client_type, credit_count_max, deposit_count_min, sum_max, sum_min);
                    offersTableAdapter1.AddNewOffer(b_id, c_ID, textBoxOfferName.Text, comboBoxOfferType.SelectedIndex);
                }
            }
            dataTableOfferAdvTableAdapter.FillByb_ID(dataSetMain.DataTableOfferAdv, b_id);
        }

        private int GetContractCountConditionsID(int credit_count_max, int deposit_count_min)
        {
            int result;
            int count_of_cc_ID=(int)queriesTableAdapter1.GetCountOfContract_Count_Conditions(credit_count_max, deposit_count_min);
            if (count_of_cc_ID==0)
            {
                contract_Count_ConditionsTableAdapter1.AddNewContractCountConditions(credit_count_max, deposit_count_min);
            }
            result = (int)queriesTableAdapter1.GetContract_Count_ConditionsCC_ID(credit_count_max, deposit_count_min);
            return result;
        }

        private int GetSumConditionsID(int sum_max, int sum_min)
        {
            int result;
            int count_of_sc_ID = (int)queriesTableAdapter1.GetCountOfSum_Conditions(sum_max, sum_min);
            if (count_of_sc_ID==0)
            {
                sum_ConditionsTableAdapter1.AddNewSumConditions(sum_max, sum_min);
            }
            result = (int)queriesTableAdapter1.GetSum_Conditions_sc_ID(sum_max, sum_min);
            return result;
        }

        private bool CheckCorrectness()
        {
            if (textBoxOfferName.Text=="")
            {
                MessageBox.Show("Offer has no name!");
                return false;
            }
            if (textBoxOfferName.Text.Length>=255)
            {
                MessageBox.Show("Error", "Name of offer is too long");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonOffersDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int o_id = (int)dataGridView1.CurrentRow.Cells["oIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> count_of_contracts = (int)queriesTableAdapter1.GetCountOfContractsOfOffer(o_id);
                if (count_of_contracts == 0)
                {
                    offersTableAdapter1.DeleteOffer(o_id);
                }
                else
                {
                    MessageBox.Show("There are some contracts signed on this offer. Unable to be deleted!");
                }
            }
            catch
            {
                MessageBox.Show("Can not delete this offer");
            }
            dataTableOfferAdvTableAdapter.FillByb_ID(dataSetMain.DataTableOfferAdv, b_id);
        }
    }
}
