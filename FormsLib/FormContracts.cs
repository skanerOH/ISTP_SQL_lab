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
    public partial class FormContracts : Form
    {
        int cl_ID;
        public FormContracts(int cl_id_temp)
        {
            InitializeComponent();
            comboBoxOType.SelectedIndex = 0;
            cl_ID = cl_id_temp;
            dataTable3TableAdapter.FillByCl_ID(dataSetMain.DataTable3, cl_ID);
        }

        private void FormContracts_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxOType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FilterAndFill()
        {
            if (comboBoxOType.SelectedIndex==0)
            {
                if (textBoxBName.Text!="")
                {
                    if (textBoxOName.Text!="")
                    {
                        dataTable3TableAdapter.FillByCl_IDAndB_nameANDO_name(dataSetMain.DataTable3, cl_ID, textBoxBName.Text, textBoxOName.Text);
                    }
                    else
                    {
                        dataTable3TableAdapter.FillByCl_IDAndB_name(dataSetMain.DataTable3, cl_ID, textBoxBName.Text);
                    }
                }
                else
                {
                    if (textBoxOName.Text!="")
                    {
                        dataTable3TableAdapter.FillByCl_IDAndO_name(dataSetMain.DataTable3, cl_ID, textBoxOName.Text);
                    }
                    else
                    {
                        dataTable3TableAdapter.FillByCl_ID(dataSetMain.DataTable3, cl_ID);
                    }
                }
            }
            else
            {
                if (textBoxBName.Text != "")
                {
                    if (textBoxOName.Text != "")
                    {
                        dataTable3TableAdapter.FillByCl_IDAndO_typeAndO_nameAndB_name(dataSetMain.DataTable3, cl_ID,comboBoxOType.SelectedIndex-1, textBoxBName.Text, textBoxOName.Text);
                    }
                    else
                    {
                        dataTable3TableAdapter.FillByCl_IDAndO_typeAndB_name(dataSetMain.DataTable3, cl_ID, comboBoxOType.SelectedIndex - 1, textBoxBName.Text);
                    }
                }
                else
                {
                    if (textBoxOName.Text != "")
                    {
                        dataTable3TableAdapter.FillByCl_IDAndO_typeAndO_name(dataSetMain.DataTable3, cl_ID,comboBoxOType.SelectedIndex - 1, textBoxOName.Text);
                    }
                    else
                    {
                        dataTable3TableAdapter.FillByCl_IDo_type(dataSetMain.DataTable3, cl_ID, comboBoxOType.SelectedIndex - 1);
                    }
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FilterAndFill();
        }

        private void buttonContractsDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewContracts.CurrentRow.Cells["conIDDataGridViewTextBoxColumn"].Value;
            contractsTableAdapter1.DeleteByCon_ID(id);
            FilterAndFill();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            FormAddContract formAddContract = new FormAddContract(cl_ID);
            this.Hide();
            formAddContract.ShowDialog();
            FilterAndFill();

            formAddContract.Dispose();
            this.Show();
        }
    }
}
