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
    public partial class FormAddContract : Form
    {
        private int cl_id;
        private int cl_type;
        public FormAddContract(int cl_id_tempo)
        {
            InitializeComponent();
            comboBoxOfferType.SelectedIndex = 0;
            cl_id = cl_id_tempo;
            cl_type = (int)clientsTableAdapter1.GetCl_typeByCl_ID(cl_id);
        }

        private void FormAddContract_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetMain.DataTable4". При необходимости она может быть перемещена или удалена.
            FillTable();

        }
        


        private void FillTable()
        {
            global::System.Nullable<int> credit_count = clientsTableAdapter1.CountClientContractsOfSelectedType(cl_id, 0);
            global::System.Nullable<int> deposit_count = clientsTableAdapter1.CountClientContractsOfSelectedType(cl_id, 1);
            if (credit_count != null && deposit_count != null)
                dataTable4TableAdapter.FillByAllFilters(dataSetMain.DataTable4, comboBoxOfferType.SelectedIndex, cl_type, credit_count, deposit_count, (int)numericUpDownSum.Value);
        }

        private void buttonLoadOffers_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void buttonSignContract_Click(object sender, EventArgs e)
        {
            string dateNow;
            dateNow = DateTime.Now.ToString("yyyy-MM-dd");
            int o_id = (int)dataGridViewOffersSelection.CurrentRow.Cells["oIDDataGridViewTextBoxColumn"].Value;
            try
            {
                if (GetStringDate() != "")
                {
                    contractsTableAdapter1.AddNewContract(o_id, cl_id, dateNow, GetStringDate(), (int)numericUpDownSum.Value);
                    MessageBox.Show("The contract successfully was signed!");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Cant add new contract!");
            }

        }

        private string GetStringDate()
        {
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            if (DateTime.Compare(dateTime, dateTimePickerFinishingDate.Value) < 0)
            {
                string result = dateTimePickerFinishingDate.Value.ToString("yyyy-MM-dd");
                return result;
            }
            else
            {
                MessageBox.Show("Finish date can not be erlier than now!");
                return "";
            }
        }

        private void comboBoxOfferType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTable();
        }

        private void numericUpDownSum_ValueChanged(object sender, EventArgs e)
        {
            FillTable();
        }
    }
}
