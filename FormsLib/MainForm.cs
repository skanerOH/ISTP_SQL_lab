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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetMain.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.dataSetMain.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetMain.Banks". При необходимости она может быть перемещена или удалена.
            this.banksTableAdapter.Fill(this.dataSetMain.Banks);

        }

        private void buttonBanksSave_Click(object sender, EventArgs e)
        {
            banksTableAdapter.Update(dataSetMain.Banks);
        }

        private void buttonBanksDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewBanks.CurrentRow.Cells["bIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> o_count = queriesTableAdapter1.SQCountBankOffers(id);
                if (o_count==0)
                {
                    banksBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Can`t Delete", "Bank has some offers");
                }
            }
            catch
            {
                MessageBox.Show("Fatal error!", "Something's gone wrong:(");
            }
        }

        private void buttonClientsSave_Click(object sender, EventArgs e)
        {
             clientsTableAdapter.Update(dataSetMain.Clients);
        }

        private void buttonClientsDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewClients.CurrentRow.Cells["clIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> con_count = queriesTableAdapter1.SQCountContructsOfClients(id);
                if (con_count == 0)
                {
                    clientsBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Can`t Delete", "Client has some contracts");
                }
            }
            catch
            {
                MessageBox.Show("Fatal error!", "Something's gone wrong:(");
            }
        }


        private void dataGridViewBanks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dataGridViewBanks.CurrentRow.Cells["bIDDataGridViewTextBoxColumn"].Value;
                FormOffersOfBank offersOfBankForm = new FormOffersOfBank(id);
                this.Hide();
                offersOfBankForm.ShowDialog(this);
                offersOfBankForm.Dispose();
                this.Show();
            }
            catch
            {
                MessageBox.Show("Failed to get bank`s offers", "Error");
                this.Show();
            }
        }

        private void dataGridViewClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dataGridViewClients.CurrentRow.Cells["clIDDataGridViewTextBoxColumn"].Value;
                FormContracts formContracts = new FormContracts(id);
                this.Hide();
                formContracts.ShowDialog(this);
                formContracts.Dispose();
                this.Show();
            }
            catch
            {
                MessageBox.Show("Failed to get cliet`s contracts", "Error");
                this.Show();
            }
        }
    }
}
