namespace FormsLib
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageBanks = new System.Windows.Forms.TabPage();
            this.dataGridViewBanks = new System.Windows.Forms.DataGridView();
            this.bnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMain = new FormsLib.DataSetMain();
            this.buttonBanksDelete = new System.Windows.Forms.Button();
            this.buttonBanksSave = new System.Windows.Forms.Button();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.buttonClientsDelete = new System.Windows.Forms.Button();
            this.buttonClientsSave = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.clfullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.offersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banksTableAdapter = new FormsLib.DataSetMainTableAdapters.BanksTableAdapter();
            this.queriesTableAdapter1 = new FormsLib.DataSetMainTableAdapters.QueriesTableAdapter();
            this.clientsTableAdapter = new FormsLib.DataSetMainTableAdapters.ClientsTableAdapter();
            this.offersTableAdapter = new FormsLib.DataSetMainTableAdapters.OffersTableAdapter();
            this.tabControlMain.SuspendLayout();
            this.tabPageBanks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMain)).BeginInit();
            this.tabPageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageBanks);
            this.tabControlMain.Controls.Add(this.tabPageClients);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(776, 426);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageBanks
            // 
            this.tabPageBanks.BackgroundImage = global::FormsLib.Properties.Resources.background_money;
            this.tabPageBanks.Controls.Add(this.dataGridViewBanks);
            this.tabPageBanks.Controls.Add(this.buttonBanksDelete);
            this.tabPageBanks.Controls.Add(this.buttonBanksSave);
            this.tabPageBanks.Location = new System.Drawing.Point(4, 22);
            this.tabPageBanks.Name = "tabPageBanks";
            this.tabPageBanks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBanks.Size = new System.Drawing.Size(768, 400);
            this.tabPageBanks.TabIndex = 0;
            this.tabPageBanks.Text = "Banks";
            this.tabPageBanks.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBanks
            // 
            this.dataGridViewBanks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBanks.AutoGenerateColumns = false;
            this.dataGridViewBanks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBanks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bnameDataGridViewTextBoxColumn,
            this.blocationDataGridViewTextBoxColumn,
            this.bIDDataGridViewTextBoxColumn});
            this.dataGridViewBanks.DataSource = this.banksBindingSource;
            this.dataGridViewBanks.Location = new System.Drawing.Point(15, 61);
            this.dataGridViewBanks.Name = "dataGridViewBanks";
            this.dataGridViewBanks.Size = new System.Drawing.Size(736, 333);
            this.dataGridViewBanks.TabIndex = 3;
            this.dataGridViewBanks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBanks_CellDoubleClick);
            // 
            // bnameDataGridViewTextBoxColumn
            // 
            this.bnameDataGridViewTextBoxColumn.DataPropertyName = "b_name";
            this.bnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.bnameDataGridViewTextBoxColumn.Name = "bnameDataGridViewTextBoxColumn";
            this.bnameDataGridViewTextBoxColumn.Width = 120;
            // 
            // blocationDataGridViewTextBoxColumn
            // 
            this.blocationDataGridViewTextBoxColumn.DataPropertyName = "b_location";
            this.blocationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.blocationDataGridViewTextBoxColumn.Name = "blocationDataGridViewTextBoxColumn";
            this.blocationDataGridViewTextBoxColumn.Width = 200;
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "b_ID";
            this.bIDDataGridViewTextBoxColumn.HeaderText = "b_ID";
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            this.bIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // banksBindingSource
            // 
            this.banksBindingSource.DataMember = "Banks";
            this.banksBindingSource.DataSource = this.dataSetMain;
            // 
            // dataSetMain
            // 
            this.dataSetMain.DataSetName = "DataSetMain";
            this.dataSetMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonBanksDelete
            // 
            this.buttonBanksDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonBanksDelete.Location = new System.Drawing.Point(141, 15);
            this.buttonBanksDelete.Name = "buttonBanksDelete";
            this.buttonBanksDelete.Size = new System.Drawing.Size(120, 40);
            this.buttonBanksDelete.TabIndex = 2;
            this.buttonBanksDelete.Text = "Delete";
            this.buttonBanksDelete.UseVisualStyleBackColor = true;
            this.buttonBanksDelete.Click += new System.EventHandler(this.buttonBanksDelete_Click);
            // 
            // buttonBanksSave
            // 
            this.buttonBanksSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonBanksSave.Location = new System.Drawing.Point(15, 15);
            this.buttonBanksSave.Name = "buttonBanksSave";
            this.buttonBanksSave.Size = new System.Drawing.Size(120, 40);
            this.buttonBanksSave.TabIndex = 1;
            this.buttonBanksSave.Text = "Save";
            this.buttonBanksSave.UseVisualStyleBackColor = true;
            this.buttonBanksSave.Click += new System.EventHandler(this.buttonBanksSave_Click);
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.buttonClientsDelete);
            this.tabPageClients.Controls.Add(this.buttonClientsSave);
            this.tabPageClients.Controls.Add(this.dataGridViewClients);
            this.tabPageClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(768, 400);
            this.tabPageClients.TabIndex = 1;
            this.tabPageClients.Text = "Clients";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // buttonClientsDelete
            // 
            this.buttonClientsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonClientsDelete.Location = new System.Drawing.Point(141, 15);
            this.buttonClientsDelete.Name = "buttonClientsDelete";
            this.buttonClientsDelete.Size = new System.Drawing.Size(120, 40);
            this.buttonClientsDelete.TabIndex = 2;
            this.buttonClientsDelete.Text = "Delete";
            this.buttonClientsDelete.UseVisualStyleBackColor = true;
            this.buttonClientsDelete.Click += new System.EventHandler(this.buttonClientsDelete_Click);
            // 
            // buttonClientsSave
            // 
            this.buttonClientsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonClientsSave.Location = new System.Drawing.Point(15, 15);
            this.buttonClientsSave.Name = "buttonClientsSave";
            this.buttonClientsSave.Size = new System.Drawing.Size(120, 40);
            this.buttonClientsSave.TabIndex = 1;
            this.buttonClientsSave.Text = "Save";
            this.buttonClientsSave.UseVisualStyleBackColor = true;
            this.buttonClientsSave.Click += new System.EventHandler(this.buttonClientsSave_Click);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClients.AutoGenerateColumns = false;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clfullnameDataGridViewTextBoxColumn,
            this.cltypeDataGridViewTextBoxColumn,
            this.clIDDataGridViewTextBoxColumn});
            this.dataGridViewClients.DataSource = this.clientsBindingSource;
            this.dataGridViewClients.Location = new System.Drawing.Point(15, 61);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(739, 333);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellDoubleClick);
            // 
            // clfullnameDataGridViewTextBoxColumn
            // 
            this.clfullnameDataGridViewTextBoxColumn.DataPropertyName = "cl_full_name";
            this.clfullnameDataGridViewTextBoxColumn.HeaderText = "Client full name";
            this.clfullnameDataGridViewTextBoxColumn.Name = "clfullnameDataGridViewTextBoxColumn";
            this.clfullnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // cltypeDataGridViewTextBoxColumn
            // 
            this.cltypeDataGridViewTextBoxColumn.DataPropertyName = "cl_type";
            this.cltypeDataGridViewTextBoxColumn.HeaderText = "Physical(0)/Jurical(1)";
            this.cltypeDataGridViewTextBoxColumn.Name = "cltypeDataGridViewTextBoxColumn";
            this.cltypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // clIDDataGridViewTextBoxColumn
            // 
            this.clIDDataGridViewTextBoxColumn.DataPropertyName = "cl_ID";
            this.clIDDataGridViewTextBoxColumn.HeaderText = "cl_ID";
            this.clIDDataGridViewTextBoxColumn.Name = "clIDDataGridViewTextBoxColumn";
            this.clIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.dataSetMain;
            // 
            // offersBindingSource
            // 
            this.offersBindingSource.DataMember = "Offers";
            this.offersBindingSource.DataSource = this.dataSetMain;
            // 
            // banksTableAdapter
            // 
            this.banksTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // offersTableAdapter
            // 
            this.offersTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormsLib.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "BanksAppMainPage";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageBanks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMain)).EndInit();
            this.tabPageClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageBanks;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.Button buttonBanksSave;
        private System.Windows.Forms.Button buttonBanksDelete;
        private System.Windows.Forms.DataGridView dataGridViewBanks;
        private DataSetMain dataSetMain;
        private System.Windows.Forms.BindingSource banksBindingSource;
        private DataSetMainTableAdapters.BanksTableAdapter banksTableAdapter;
        private DataSetMainTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private DataSetMainTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Button buttonClientsDelete;
        private System.Windows.Forms.Button buttonClientsSave;
        private System.Windows.Forms.BindingSource offersBindingSource;
        private DataSetMainTableAdapters.OffersTableAdapter offersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clfullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIDDataGridViewTextBoxColumn;
    }
}

