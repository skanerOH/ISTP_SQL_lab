namespace FormsLib
{
    partial class FormContracts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewContracts = new System.Windows.Forms.DataGridView();
            this.bnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consigningdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confinishdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMain = new FormsLib.DataSetMain();
            this.comboBoxOType = new System.Windows.Forms.ComboBox();
            this.textBoxBName = new System.Windows.Forms.TextBox();
            this.textBoxOName = new System.Windows.Forms.TextBox();
            this.labelBanksFilter = new System.Windows.Forms.Label();
            this.labelOfferNameFilter = new System.Windows.Forms.Label();
            this.labelOfferTypeFilter = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonContractsDelete = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.dataTable3TableAdapter = new FormsLib.DataSetMainTableAdapters.DataTable3TableAdapter();
            this.contractsTableAdapter1 = new FormsLib.DataSetMainTableAdapters.ContractsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContracts
            // 
            this.dataGridViewContracts.AllowUserToAddRows = false;
            this.dataGridViewContracts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewContracts.AutoGenerateColumns = false;
            this.dataGridViewContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bnameDataGridViewTextBoxColumn,
            this.onameDataGridViewTextBoxColumn,
            this.otypeDataGridViewTextBoxColumn,
            this.consumDataGridViewTextBoxColumn,
            this.consigningdateDataGridViewTextBoxColumn,
            this.confinishdateDataGridViewTextBoxColumn,
            this.conIDDataGridViewTextBoxColumn});
            this.dataGridViewContracts.DataSource = this.dataTable3BindingSource;
            this.dataGridViewContracts.Location = new System.Drawing.Point(16, 156);
            this.dataGridViewContracts.Name = "dataGridViewContracts";
            this.dataGridViewContracts.Size = new System.Drawing.Size(654, 282);
            this.dataGridViewContracts.TabIndex = 0;
            // 
            // bnameDataGridViewTextBoxColumn
            // 
            this.bnameDataGridViewTextBoxColumn.DataPropertyName = "b_name";
            this.bnameDataGridViewTextBoxColumn.HeaderText = "Bank";
            this.bnameDataGridViewTextBoxColumn.Name = "bnameDataGridViewTextBoxColumn";
            // 
            // onameDataGridViewTextBoxColumn
            // 
            this.onameDataGridViewTextBoxColumn.DataPropertyName = "o_name";
            this.onameDataGridViewTextBoxColumn.HeaderText = "Offer name";
            this.onameDataGridViewTextBoxColumn.Name = "onameDataGridViewTextBoxColumn";
            // 
            // otypeDataGridViewTextBoxColumn
            // 
            this.otypeDataGridViewTextBoxColumn.DataPropertyName = "o_type";
            this.otypeDataGridViewTextBoxColumn.HeaderText = "Credit(0)/Deposit(1)";
            this.otypeDataGridViewTextBoxColumn.Name = "otypeDataGridViewTextBoxColumn";
            this.otypeDataGridViewTextBoxColumn.Width = 110;
            // 
            // consumDataGridViewTextBoxColumn
            // 
            this.consumDataGridViewTextBoxColumn.DataPropertyName = "con_sum";
            this.consumDataGridViewTextBoxColumn.HeaderText = "Sum";
            this.consumDataGridViewTextBoxColumn.Name = "consumDataGridViewTextBoxColumn";
            // 
            // consigningdateDataGridViewTextBoxColumn
            // 
            this.consigningdateDataGridViewTextBoxColumn.DataPropertyName = "con_signing_date";
            this.consigningdateDataGridViewTextBoxColumn.HeaderText = "Signing date";
            this.consigningdateDataGridViewTextBoxColumn.Name = "consigningdateDataGridViewTextBoxColumn";
            // 
            // confinishdateDataGridViewTextBoxColumn
            // 
            this.confinishdateDataGridViewTextBoxColumn.DataPropertyName = "con_finish_date";
            this.confinishdateDataGridViewTextBoxColumn.HeaderText = "Finish date";
            this.confinishdateDataGridViewTextBoxColumn.Name = "confinishdateDataGridViewTextBoxColumn";
            // 
            // conIDDataGridViewTextBoxColumn
            // 
            this.conIDDataGridViewTextBoxColumn.DataPropertyName = "con_ID";
            this.conIDDataGridViewTextBoxColumn.HeaderText = "con_ID";
            this.conIDDataGridViewTextBoxColumn.Name = "conIDDataGridViewTextBoxColumn";
            this.conIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.conIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataTable3BindingSource
            // 
            this.dataTable3BindingSource.DataMember = "DataTable3";
            this.dataTable3BindingSource.DataSource = this.dataSetMain;
            // 
            // dataSetMain
            // 
            this.dataSetMain.DataSetName = "DataSetMain";
            this.dataSetMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxOType
            // 
            this.comboBoxOType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxOType.FormattingEnabled = true;
            this.comboBoxOType.Items.AddRange(new object[] {
            "All",
            "Credits",
            "Deposits"});
            this.comboBoxOType.Location = new System.Drawing.Point(126, 79);
            this.comboBoxOType.Name = "comboBoxOType";
            this.comboBoxOType.Size = new System.Drawing.Size(121, 32);
            this.comboBoxOType.TabIndex = 1;
            this.comboBoxOType.SelectedIndexChanged += new System.EventHandler(this.comboBoxOType_SelectedIndexChanged);
            // 
            // textBoxBName
            // 
            this.textBoxBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxBName.Location = new System.Drawing.Point(126, 9);
            this.textBoxBName.Name = "textBoxBName";
            this.textBoxBName.Size = new System.Drawing.Size(121, 29);
            this.textBoxBName.TabIndex = 2;
            // 
            // textBoxOName
            // 
            this.textBoxOName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxOName.Location = new System.Drawing.Point(126, 44);
            this.textBoxOName.Name = "textBoxOName";
            this.textBoxOName.Size = new System.Drawing.Size(121, 29);
            this.textBoxOName.TabIndex = 3;
            // 
            // labelBanksFilter
            // 
            this.labelBanksFilter.AutoSize = true;
            this.labelBanksFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelBanksFilter.Location = new System.Drawing.Point(12, 12);
            this.labelBanksFilter.Name = "labelBanksFilter";
            this.labelBanksFilter.Size = new System.Drawing.Size(110, 24);
            this.labelBanksFilter.TabIndex = 4;
            this.labelBanksFilter.Text = "Bank name:";
            // 
            // labelOfferNameFilter
            // 
            this.labelOfferNameFilter.AutoSize = true;
            this.labelOfferNameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelOfferNameFilter.Location = new System.Drawing.Point(12, 44);
            this.labelOfferNameFilter.Name = "labelOfferNameFilter";
            this.labelOfferNameFilter.Size = new System.Drawing.Size(108, 24);
            this.labelOfferNameFilter.TabIndex = 5;
            this.labelOfferNameFilter.Text = "Offer name:";
            // 
            // labelOfferTypeFilter
            // 
            this.labelOfferTypeFilter.AutoSize = true;
            this.labelOfferTypeFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelOfferTypeFilter.Location = new System.Drawing.Point(12, 79);
            this.labelOfferTypeFilter.Name = "labelOfferTypeFilter";
            this.labelOfferTypeFilter.Size = new System.Drawing.Size(95, 24);
            this.labelOfferTypeFilter.TabIndex = 6;
            this.labelOfferTypeFilter.Text = "Offer type:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonSearch.Location = new System.Drawing.Point(16, 117);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(231, 33);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonContractsDelete
            // 
            this.buttonContractsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonContractsDelete.Location = new System.Drawing.Point(253, 117);
            this.buttonContractsDelete.Name = "buttonContractsDelete";
            this.buttonContractsDelete.Size = new System.Drawing.Size(208, 33);
            this.buttonContractsDelete.TabIndex = 8;
            this.buttonContractsDelete.Text = "Delete";
            this.buttonContractsDelete.UseVisualStyleBackColor = true;
            this.buttonContractsDelete.Click += new System.EventHandler(this.buttonContractsDelete_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonAddNew.Location = new System.Drawing.Point(467, 117);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(203, 33);
            this.buttonAddNew.TabIndex = 9;
            this.buttonAddNew.Text = "Add new";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // dataTable3TableAdapter
            // 
            this.dataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // contractsTableAdapter1
            // 
            this.contractsTableAdapter1.ClearBeforeFill = true;
            // 
            // FormContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormsLib.Properties.Resources.background_money;
            this.ClientSize = new System.Drawing.Size(676, 443);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.buttonContractsDelete);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelOfferTypeFilter);
            this.Controls.Add(this.labelOfferNameFilter);
            this.Controls.Add(this.labelBanksFilter);
            this.Controls.Add(this.textBoxOName);
            this.Controls.Add(this.textBoxBName);
            this.Controls.Add(this.comboBoxOType);
            this.Controls.Add(this.dataGridViewContracts);
            this.Name = "FormContracts";
            this.Text = "ContractsOfSelectedUser";
            this.Load += new System.EventHandler(this.FormContracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContracts;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
        private DataSetMain dataSetMain;
        private DataSetMainTableAdapters.DataTable3TableAdapter dataTable3TableAdapter;
        private System.Windows.Forms.ComboBox comboBoxOType;
        private System.Windows.Forms.TextBox textBoxBName;
        private System.Windows.Forms.TextBox textBoxOName;
        private System.Windows.Forms.Label labelBanksFilter;
        private System.Windows.Forms.Label labelOfferNameFilter;
        private System.Windows.Forms.Label labelOfferTypeFilter;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn bnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consigningdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confinishdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonContractsDelete;
        private DataSetMainTableAdapters.ContractsTableAdapter contractsTableAdapter1;
        private System.Windows.Forms.Button buttonAddNew;
    }
}