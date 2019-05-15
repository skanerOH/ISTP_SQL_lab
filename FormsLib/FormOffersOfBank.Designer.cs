namespace FormsLib
{
    partial class FormOffersOfBank
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.onameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cclienttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccreditcountmaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccdepositcountminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scsummaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scsumminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableOfferAdvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMain = new FormsLib.DataSetMain();
            this.buttonOffersDelete = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.numericUpDownCreditCountMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDepositCountMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSumMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSumMin = new System.Windows.Forms.NumericUpDown();
            this.comboBoxClientType = new System.Windows.Forms.ComboBox();
            this.comboBoxOfferType = new System.Windows.Forms.ComboBox();
            this.textBoxOfferName = new System.Windows.Forms.TextBox();
            this.dataTableOfferAdvTableAdapter = new FormsLib.DataSetMainTableAdapters.DataTableOfferAdvTableAdapter();
            this.offersTableAdapter1 = new FormsLib.DataSetMainTableAdapters.OffersTableAdapter();
            this.queriesTableAdapter1 = new FormsLib.DataSetMainTableAdapters.QueriesTableAdapter();
            this.contract_Count_ConditionsTableAdapter1 = new FormsLib.DataSetMainTableAdapters.Contract_Count_ConditionsTableAdapter();
            this.sum_ConditionsTableAdapter1 = new FormsLib.DataSetMainTableAdapters.Sum_ConditionsTableAdapter();
            this.conditionsTableAdapter1 = new FormsLib.DataSetMainTableAdapters.ConditionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOfferAdvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreditCountMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepositCountMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSumMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSumMin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.onameDataGridViewTextBoxColumn,
            this.oIDDataGridViewTextBoxColumn,
            this.otypeDataGridViewTextBoxColumn,
            this.cclienttypeDataGridViewTextBoxColumn,
            this.cccreditcountmaxDataGridViewTextBoxColumn,
            this.ccdepositcountminDataGridViewTextBoxColumn,
            this.scsummaxDataGridViewTextBoxColumn,
            this.scsumminDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTableOfferAdvBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // onameDataGridViewTextBoxColumn
            // 
            this.onameDataGridViewTextBoxColumn.DataPropertyName = "o_name";
            this.onameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.onameDataGridViewTextBoxColumn.Name = "onameDataGridViewTextBoxColumn";
            this.onameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oIDDataGridViewTextBoxColumn
            // 
            this.oIDDataGridViewTextBoxColumn.DataPropertyName = "o_ID";
            this.oIDDataGridViewTextBoxColumn.HeaderText = "o_ID";
            this.oIDDataGridViewTextBoxColumn.Name = "oIDDataGridViewTextBoxColumn";
            this.oIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // otypeDataGridViewTextBoxColumn
            // 
            this.otypeDataGridViewTextBoxColumn.DataPropertyName = "o_type";
            this.otypeDataGridViewTextBoxColumn.HeaderText = "Credit(0)/Deposit(1)";
            this.otypeDataGridViewTextBoxColumn.Name = "otypeDataGridViewTextBoxColumn";
            this.otypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.otypeDataGridViewTextBoxColumn.Width = 130;
            // 
            // cclienttypeDataGridViewTextBoxColumn
            // 
            this.cclienttypeDataGridViewTextBoxColumn.DataPropertyName = "c_client_type";
            this.cclienttypeDataGridViewTextBoxColumn.HeaderText = "Physical(0)/Jurical(1)";
            this.cclienttypeDataGridViewTextBoxColumn.Name = "cclienttypeDataGridViewTextBoxColumn";
            this.cclienttypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cclienttypeDataGridViewTextBoxColumn.Width = 130;
            // 
            // cccreditcountmaxDataGridViewTextBoxColumn
            // 
            this.cccreditcountmaxDataGridViewTextBoxColumn.DataPropertyName = "cc_credit_count_max";
            this.cccreditcountmaxDataGridViewTextBoxColumn.HeaderText = "Max count of credits";
            this.cccreditcountmaxDataGridViewTextBoxColumn.Name = "cccreditcountmaxDataGridViewTextBoxColumn";
            this.cccreditcountmaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.cccreditcountmaxDataGridViewTextBoxColumn.Width = 150;
            // 
            // ccdepositcountminDataGridViewTextBoxColumn
            // 
            this.ccdepositcountminDataGridViewTextBoxColumn.DataPropertyName = "cc_deposit_count_min";
            this.ccdepositcountminDataGridViewTextBoxColumn.HeaderText = "Min count of deposits";
            this.ccdepositcountminDataGridViewTextBoxColumn.Name = "ccdepositcountminDataGridViewTextBoxColumn";
            this.ccdepositcountminDataGridViewTextBoxColumn.ReadOnly = true;
            this.ccdepositcountminDataGridViewTextBoxColumn.Width = 150;
            // 
            // scsummaxDataGridViewTextBoxColumn
            // 
            this.scsummaxDataGridViewTextBoxColumn.DataPropertyName = "sc_sum_max";
            this.scsummaxDataGridViewTextBoxColumn.HeaderText = "Max sum";
            this.scsummaxDataGridViewTextBoxColumn.Name = "scsummaxDataGridViewTextBoxColumn";
            this.scsummaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.scsummaxDataGridViewTextBoxColumn.Width = 150;
            // 
            // scsumminDataGridViewTextBoxColumn
            // 
            this.scsumminDataGridViewTextBoxColumn.DataPropertyName = "sc_sum_min";
            this.scsumminDataGridViewTextBoxColumn.HeaderText = "Min sum";
            this.scsumminDataGridViewTextBoxColumn.Name = "scsumminDataGridViewTextBoxColumn";
            this.scsumminDataGridViewTextBoxColumn.ReadOnly = true;
            this.scsumminDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataTableOfferAdvBindingSource
            // 
            this.dataTableOfferAdvBindingSource.DataMember = "DataTableOfferAdv";
            this.dataTableOfferAdvBindingSource.DataSource = this.dataSetMain;
            // 
            // dataSetMain
            // 
            this.dataSetMain.DataSetName = "DataSetMain";
            this.dataSetMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonOffersDelete
            // 
            this.buttonOffersDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonOffersDelete.Location = new System.Drawing.Point(12, 12);
            this.buttonOffersDelete.Name = "buttonOffersDelete";
            this.buttonOffersDelete.Size = new System.Drawing.Size(205, 40);
            this.buttonOffersDelete.TabIndex = 1;
            this.buttonOffersDelete.Text = "Delete";
            this.buttonOffersDelete.UseVisualStyleBackColor = true;
            this.buttonOffersDelete.Click += new System.EventHandler(this.buttonOffersDelete_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonAddNew.Location = new System.Drawing.Point(237, 12);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(217, 40);
            this.buttonAddNew.TabIndex = 2;
            this.buttonAddNew.Text = "Add new";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // numericUpDownCreditCountMax
            // 
            this.numericUpDownCreditCountMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.numericUpDownCreditCountMax.Location = new System.Drawing.Point(420, 60);
            this.numericUpDownCreditCountMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownCreditCountMax.Name = "numericUpDownCreditCountMax";
            this.numericUpDownCreditCountMax.Size = new System.Drawing.Size(144, 32);
            this.numericUpDownCreditCountMax.TabIndex = 3;
            this.numericUpDownCreditCountMax.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownDepositCountMin
            // 
            this.numericUpDownDepositCountMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.numericUpDownDepositCountMin.Location = new System.Drawing.Point(566, 60);
            this.numericUpDownDepositCountMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownDepositCountMin.Name = "numericUpDownDepositCountMin";
            this.numericUpDownDepositCountMin.Size = new System.Drawing.Size(145, 32);
            this.numericUpDownDepositCountMin.TabIndex = 4;
            // 
            // numericUpDownSumMax
            // 
            this.numericUpDownSumMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.numericUpDownSumMax.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSumMax.Location = new System.Drawing.Point(717, 60);
            this.numericUpDownSumMax.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownSumMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSumMax.Name = "numericUpDownSumMax";
            this.numericUpDownSumMax.Size = new System.Drawing.Size(146, 32);
            this.numericUpDownSumMax.TabIndex = 5;
            this.numericUpDownSumMax.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // numericUpDownSumMin
            // 
            this.numericUpDownSumMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.numericUpDownSumMin.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSumMin.Location = new System.Drawing.Point(869, 60);
            this.numericUpDownSumMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownSumMin.Name = "numericUpDownSumMin";
            this.numericUpDownSumMin.Size = new System.Drawing.Size(148, 32);
            this.numericUpDownSumMin.TabIndex = 6;
            // 
            // comboBoxClientType
            // 
            this.comboBoxClientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBoxClientType.FormattingEnabled = true;
            this.comboBoxClientType.Items.AddRange(new object[] {
            "Physical",
            "Jurical"});
            this.comboBoxClientType.Location = new System.Drawing.Point(284, 59);
            this.comboBoxClientType.Name = "comboBoxClientType";
            this.comboBoxClientType.Size = new System.Drawing.Size(130, 33);
            this.comboBoxClientType.TabIndex = 7;
            // 
            // comboBoxOfferType
            // 
            this.comboBoxOfferType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOfferType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBoxOfferType.FormattingEnabled = true;
            this.comboBoxOfferType.Items.AddRange(new object[] {
            "Credit",
            "Deposit"});
            this.comboBoxOfferType.Location = new System.Drawing.Point(156, 59);
            this.comboBoxOfferType.Name = "comboBoxOfferType";
            this.comboBoxOfferType.Size = new System.Drawing.Size(122, 33);
            this.comboBoxOfferType.TabIndex = 8;
            // 
            // textBoxOfferName
            // 
            this.textBoxOfferName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxOfferName.Location = new System.Drawing.Point(12, 60);
            this.textBoxOfferName.Name = "textBoxOfferName";
            this.textBoxOfferName.Size = new System.Drawing.Size(138, 32);
            this.textBoxOfferName.TabIndex = 9;
            // 
            // dataTableOfferAdvTableAdapter
            // 
            this.dataTableOfferAdvTableAdapter.ClearBeforeFill = true;
            // 
            // offersTableAdapter1
            // 
            this.offersTableAdapter1.ClearBeforeFill = true;
            // 
            // contract_Count_ConditionsTableAdapter1
            // 
            this.contract_Count_ConditionsTableAdapter1.ClearBeforeFill = true;
            // 
            // sum_ConditionsTableAdapter1
            // 
            this.sum_ConditionsTableAdapter1.ClearBeforeFill = true;
            // 
            // conditionsTableAdapter1
            // 
            this.conditionsTableAdapter1.ClearBeforeFill = true;
            // 
            // FormOffersOfBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormsLib.Properties.Resources.background_money;
            this.ClientSize = new System.Drawing.Size(1029, 441);
            this.Controls.Add(this.textBoxOfferName);
            this.Controls.Add(this.comboBoxOfferType);
            this.Controls.Add(this.comboBoxClientType);
            this.Controls.Add(this.numericUpDownSumMin);
            this.Controls.Add(this.numericUpDownSumMax);
            this.Controls.Add(this.numericUpDownDepositCountMin);
            this.Controls.Add(this.numericUpDownCreditCountMax);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.buttonOffersDelete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormOffersOfBank";
            this.Text = "OffersOfSelectedBank";
            this.Load += new System.EventHandler(this.FormOffersOfBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOfferAdvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreditCountMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepositCountMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSumMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSumMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSetMain dataSetMain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataTableOfferAdvBindingSource;
        private DataSetMainTableAdapters.DataTableOfferAdvTableAdapter dataTableOfferAdvTableAdapter;
        private System.Windows.Forms.Button buttonOffersDelete;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.NumericUpDown numericUpDownCreditCountMax;
        private System.Windows.Forms.NumericUpDown numericUpDownDepositCountMin;
        private System.Windows.Forms.NumericUpDown numericUpDownSumMax;
        private System.Windows.Forms.NumericUpDown numericUpDownSumMin;
        private System.Windows.Forms.ComboBox comboBoxClientType;
        private System.Windows.Forms.ComboBox comboBoxOfferType;
        private System.Windows.Forms.TextBox textBoxOfferName;
        private DataSetMainTableAdapters.OffersTableAdapter offersTableAdapter1;
        private DataSetMainTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private DataSetMainTableAdapters.Contract_Count_ConditionsTableAdapter contract_Count_ConditionsTableAdapter1;
        private DataSetMainTableAdapters.Sum_ConditionsTableAdapter sum_ConditionsTableAdapter1;
        private DataSetMainTableAdapters.ConditionsTableAdapter conditionsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn onameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cclienttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccreditcountmaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccdepositcountminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scsummaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scsumminDataGridViewTextBoxColumn;
    }
}