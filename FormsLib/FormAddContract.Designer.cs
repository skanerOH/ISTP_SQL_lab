namespace FormsLib
{
    partial class FormAddContract
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
            this.dataGridViewOffersSelection = new System.Windows.Forms.DataGridView();
            this.bnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cclienttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccreditcountmaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccdepositcountminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scsummaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scsumminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMain = new FormsLib.DataSetMain();
            this.dataTable4TableAdapter = new FormsLib.DataSetMainTableAdapters.DataTable4TableAdapter();
            this.comboBoxOfferType = new System.Windows.Forms.ComboBox();
            this.numericUpDownSum = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerFinishingDate = new System.Windows.Forms.DateTimePicker();
            this.labelOfferType = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.clientsTableAdapter1 = new FormsLib.DataSetMainTableAdapters.ClientsTableAdapter();
            this.buttonLoadOffers = new System.Windows.Forms.Button();
            this.buttonSignContract = new System.Windows.Forms.Button();
            this.contractsTableAdapter1 = new FormsLib.DataSetMainTableAdapters.ContractsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffersSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOffersSelection
            // 
            this.dataGridViewOffersSelection.AllowUserToAddRows = false;
            this.dataGridViewOffersSelection.AllowUserToDeleteRows = false;
            this.dataGridViewOffersSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOffersSelection.AutoGenerateColumns = false;
            this.dataGridViewOffersSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffersSelection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bnameDataGridViewTextBoxColumn,
            this.onameDataGridViewTextBoxColumn,
            this.otypeDataGridViewTextBoxColumn,
            this.cclienttypeDataGridViewTextBoxColumn,
            this.cccreditcountmaxDataGridViewTextBoxColumn,
            this.ccdepositcountminDataGridViewTextBoxColumn,
            this.scsummaxDataGridViewTextBoxColumn,
            this.scsumminDataGridViewTextBoxColumn,
            this.oIDDataGridViewTextBoxColumn});
            this.dataGridViewOffersSelection.DataSource = this.dataTable4BindingSource;
            this.dataGridViewOffersSelection.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewOffersSelection.Name = "dataGridViewOffersSelection";
            this.dataGridViewOffersSelection.ReadOnly = true;
            this.dataGridViewOffersSelection.Size = new System.Drawing.Size(694, 300);
            this.dataGridViewOffersSelection.TabIndex = 0;
            // 
            // bnameDataGridViewTextBoxColumn
            // 
            this.bnameDataGridViewTextBoxColumn.DataPropertyName = "b_name";
            this.bnameDataGridViewTextBoxColumn.HeaderText = "Bank name";
            this.bnameDataGridViewTextBoxColumn.Name = "bnameDataGridViewTextBoxColumn";
            this.bnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // onameDataGridViewTextBoxColumn
            // 
            this.onameDataGridViewTextBoxColumn.DataPropertyName = "o_name";
            this.onameDataGridViewTextBoxColumn.HeaderText = "Offer name";
            this.onameDataGridViewTextBoxColumn.Name = "onameDataGridViewTextBoxColumn";
            this.onameDataGridViewTextBoxColumn.ReadOnly = true;
            this.onameDataGridViewTextBoxColumn.Width = 150;
            // 
            // otypeDataGridViewTextBoxColumn
            // 
            this.otypeDataGridViewTextBoxColumn.DataPropertyName = "o_type";
            this.otypeDataGridViewTextBoxColumn.HeaderText = "o_type";
            this.otypeDataGridViewTextBoxColumn.Name = "otypeDataGridViewTextBoxColumn";
            this.otypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.otypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // cclienttypeDataGridViewTextBoxColumn
            // 
            this.cclienttypeDataGridViewTextBoxColumn.DataPropertyName = "c_client_type";
            this.cclienttypeDataGridViewTextBoxColumn.HeaderText = "c_client_type";
            this.cclienttypeDataGridViewTextBoxColumn.Name = "cclienttypeDataGridViewTextBoxColumn";
            this.cclienttypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cclienttypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // cccreditcountmaxDataGridViewTextBoxColumn
            // 
            this.cccreditcountmaxDataGridViewTextBoxColumn.DataPropertyName = "cc_credit_count_max";
            this.cccreditcountmaxDataGridViewTextBoxColumn.HeaderText = "Max count of credits";
            this.cccreditcountmaxDataGridViewTextBoxColumn.Name = "cccreditcountmaxDataGridViewTextBoxColumn";
            this.cccreditcountmaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ccdepositcountminDataGridViewTextBoxColumn
            // 
            this.ccdepositcountminDataGridViewTextBoxColumn.DataPropertyName = "cc_deposit_count_min";
            this.ccdepositcountminDataGridViewTextBoxColumn.HeaderText = "Min count of deposits";
            this.ccdepositcountminDataGridViewTextBoxColumn.Name = "ccdepositcountminDataGridViewTextBoxColumn";
            this.ccdepositcountminDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scsummaxDataGridViewTextBoxColumn
            // 
            this.scsummaxDataGridViewTextBoxColumn.DataPropertyName = "sc_sum_max";
            this.scsummaxDataGridViewTextBoxColumn.HeaderText = "Max sum";
            this.scsummaxDataGridViewTextBoxColumn.Name = "scsummaxDataGridViewTextBoxColumn";
            this.scsummaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scsumminDataGridViewTextBoxColumn
            // 
            this.scsumminDataGridViewTextBoxColumn.DataPropertyName = "sc_sum_min";
            this.scsumminDataGridViewTextBoxColumn.HeaderText = "Min sum";
            this.scsumminDataGridViewTextBoxColumn.Name = "scsumminDataGridViewTextBoxColumn";
            this.scsumminDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oIDDataGridViewTextBoxColumn
            // 
            this.oIDDataGridViewTextBoxColumn.DataPropertyName = "o_ID";
            this.oIDDataGridViewTextBoxColumn.HeaderText = "o_ID";
            this.oIDDataGridViewTextBoxColumn.Name = "oIDDataGridViewTextBoxColumn";
            this.oIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataTable4BindingSource
            // 
            this.dataTable4BindingSource.DataMember = "DataTable4";
            this.dataTable4BindingSource.DataSource = this.dataSetMain;
            // 
            // dataSetMain
            // 
            this.dataSetMain.DataSetName = "DataSetMain";
            this.dataSetMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable4TableAdapter
            // 
            this.dataTable4TableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxOfferType
            // 
            this.comboBoxOfferType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOfferType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBoxOfferType.FormattingEnabled = true;
            this.comboBoxOfferType.Items.AddRange(new object[] {
            "Credit",
            "Deposit"});
            this.comboBoxOfferType.Location = new System.Drawing.Point(160, 23);
            this.comboBoxOfferType.Name = "comboBoxOfferType";
            this.comboBoxOfferType.Size = new System.Drawing.Size(178, 33);
            this.comboBoxOfferType.TabIndex = 1;
            this.comboBoxOfferType.SelectedIndexChanged += new System.EventHandler(this.comboBoxOfferType_SelectedIndexChanged);
            // 
            // numericUpDownSum
            // 
            this.numericUpDownSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.numericUpDownSum.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownSum.Location = new System.Drawing.Point(160, 62);
            this.numericUpDownSum.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownSum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSum.Name = "numericUpDownSum";
            this.numericUpDownSum.Size = new System.Drawing.Size(178, 32);
            this.numericUpDownSum.TabIndex = 2;
            this.numericUpDownSum.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSum.ValueChanged += new System.EventHandler(this.numericUpDownSum_ValueChanged);
            // 
            // dateTimePickerFinishingDate
            // 
            this.dateTimePickerFinishingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dateTimePickerFinishingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinishingDate.Location = new System.Drawing.Point(160, 100);
            this.dateTimePickerFinishingDate.MinDate = new System.DateTime(2019, 3, 16, 0, 0, 0, 0);
            this.dateTimePickerFinishingDate.Name = "dateTimePickerFinishingDate";
            this.dateTimePickerFinishingDate.Size = new System.Drawing.Size(178, 32);
            this.dateTimePickerFinishingDate.TabIndex = 3;
            // 
            // labelOfferType
            // 
            this.labelOfferType.AutoSize = true;
            this.labelOfferType.BackColor = System.Drawing.SystemColors.Control;
            this.labelOfferType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelOfferType.Location = new System.Drawing.Point(7, 23);
            this.labelOfferType.Name = "labelOfferType";
            this.labelOfferType.Size = new System.Drawing.Size(147, 26);
            this.labelOfferType.TabIndex = 4;
            this.labelOfferType.Text = "Contract type:";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelSum.Location = new System.Drawing.Point(7, 62);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(148, 26);
            this.labelSum.TabIndex = 5;
            this.labelSum.Text = "Contract sum:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelDate.Location = new System.Drawing.Point(12, 100);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(124, 26);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Finish date:";
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonLoadOffers
            // 
            this.buttonLoadOffers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonLoadOffers.Location = new System.Drawing.Point(344, 92);
            this.buttonLoadOffers.Name = "buttonLoadOffers";
            this.buttonLoadOffers.Size = new System.Drawing.Size(163, 40);
            this.buttonLoadOffers.TabIndex = 7;
            this.buttonLoadOffers.Text = "Load offers";
            this.buttonLoadOffers.UseVisualStyleBackColor = true;
            this.buttonLoadOffers.Click += new System.EventHandler(this.buttonLoadOffers_Click);
            // 
            // buttonSignContract
            // 
            this.buttonSignContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonSignContract.Location = new System.Drawing.Point(513, 92);
            this.buttonSignContract.Name = "buttonSignContract";
            this.buttonSignContract.Size = new System.Drawing.Size(181, 40);
            this.buttonSignContract.TabIndex = 8;
            this.buttonSignContract.Text = "Sign contract";
            this.buttonSignContract.UseVisualStyleBackColor = true;
            this.buttonSignContract.Click += new System.EventHandler(this.buttonSignContract_Click);
            // 
            // contractsTableAdapter1
            // 
            this.contractsTableAdapter1.ClearBeforeFill = true;
            // 
            // FormAddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormsLib.Properties.Resources.background_money;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.buttonSignContract);
            this.Controls.Add(this.buttonLoadOffers);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelOfferType);
            this.Controls.Add(this.dateTimePickerFinishingDate);
            this.Controls.Add(this.numericUpDownSum);
            this.Controls.Add(this.comboBoxOfferType);
            this.Controls.Add(this.dataGridViewOffersSelection);
            this.Name = "FormAddContract";
            this.Text = "FormAddContract";
            this.Load += new System.EventHandler(this.FormAddContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffersSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOffersSelection;
        private DataSetMain dataSetMain;
        private System.Windows.Forms.BindingSource dataTable4BindingSource;
        private DataSetMainTableAdapters.DataTable4TableAdapter dataTable4TableAdapter;
        private System.Windows.Forms.ComboBox comboBoxOfferType;
        private System.Windows.Forms.NumericUpDown numericUpDownSum;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinishingDate;
        private System.Windows.Forms.Label labelOfferType;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelDate;
        private DataSetMainTableAdapters.ClientsTableAdapter clientsTableAdapter1;
        private System.Windows.Forms.Button buttonLoadOffers;
        private System.Windows.Forms.DataGridViewTextBoxColumn bnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cclienttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccreditcountmaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccdepositcountminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scsummaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scsumminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSignContract;
        private DataSetMainTableAdapters.ContractsTableAdapter contractsTableAdapter1;
    }
}