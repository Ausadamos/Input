namespace Input
{
    partial class pageRework_Main
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvInputRMA = new System.Windows.Forms.DataGridView();
            this.cmbProcess = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFlowName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSelect_PurchaseNo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoAllPurchase = new System.Windows.Forms.RadioButton();
            this.rdoLastPurchase = new System.Windows.Forms.RadioButton();
            this.rdoUsedPurchase = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblFFTOrderID = new System.Windows.Forms.Label();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQtyOrder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputRMA)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(619, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 39);
            this.btnAdd.TabIndex = 121;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvInputRMA
            // 
            this.dgvInputRMA.BackgroundColor = System.Drawing.Color.White;
            this.dgvInputRMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInputRMA.Location = new System.Drawing.Point(12, 121);
            this.dgvInputRMA.MultiSelect = false;
            this.dgvInputRMA.Name = "dgvInputRMA";
            this.dgvInputRMA.Size = new System.Drawing.Size(720, 269);
            this.dgvInputRMA.TabIndex = 122;
            // 
            // cmbProcess
            // 
            this.cmbProcess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProcess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProcess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcess.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProcess.ForeColor = System.Drawing.Color.Black;
            this.cmbProcess.FormattingEnabled = true;
            this.cmbProcess.Items.AddRange(new object[] {
            "- Select Purchase -"});
            this.cmbProcess.Location = new System.Drawing.Point(390, 52);
            this.cmbProcess.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProcess.Name = "cmbProcess";
            this.cmbProcess.Size = new System.Drawing.Size(200, 25);
            this.cmbProcess.TabIndex = 121;
            this.cmbProcess.SelectedIndexChanged += new System.EventHandler(this.cmbProcess_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkGray;
            this.label13.Location = new System.Drawing.Point(9, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 19);
            this.label13.TabIndex = 120;
            this.label13.Text = "Flow Name :";
            // 
            // txtFlowName
            // 
            this.txtFlowName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFlowName.BackColor = System.Drawing.Color.White;
            this.txtFlowName.Enabled = false;
            this.txtFlowName.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlowName.Location = new System.Drawing.Point(107, 52);
            this.txtFlowName.Name = "txtFlowName";
            this.txtFlowName.Size = new System.Drawing.Size(166, 25);
            this.txtFlowName.TabIndex = 119;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(279, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 112;
            this.label9.Text = "Process Start :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(526, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 19);
            this.label8.TabIndex = 111;
            // 
            // cmbSelect_PurchaseNo
            // 
            this.cmbSelect_PurchaseNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSelect_PurchaseNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSelect_PurchaseNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSelect_PurchaseNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelect_PurchaseNo.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelect_PurchaseNo.ForeColor = System.Drawing.Color.Black;
            this.cmbSelect_PurchaseNo.FormattingEnabled = true;
            this.cmbSelect_PurchaseNo.Items.AddRange(new object[] {
            "- Select Purchase -"});
            this.cmbSelect_PurchaseNo.Location = new System.Drawing.Point(422, 17);
            this.cmbSelect_PurchaseNo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelect_PurchaseNo.Name = "cmbSelect_PurchaseNo";
            this.cmbSelect_PurchaseNo.Size = new System.Drawing.Size(168, 25);
            this.cmbSelect_PurchaseNo.TabIndex = 38;
            this.cmbSelect_PurchaseNo.SelectedIndexChanged += new System.EventHandler(this.cmbSelect_PurchaseNo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(315, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Purchase No :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Serial :";
            // 
            // rdoAllPurchase
            // 
            this.rdoAllPurchase.AutoSize = true;
            this.rdoAllPurchase.Location = new System.Drawing.Point(217, 14);
            this.rdoAllPurchase.Name = "rdoAllPurchase";
            this.rdoAllPurchase.Size = new System.Drawing.Size(92, 19);
            this.rdoAllPurchase.TabIndex = 125;
            this.rdoAllPurchase.TabStop = true;
            this.rdoAllPurchase.Text = "All Purchase";
            this.rdoAllPurchase.UseVisualStyleBackColor = true;
            this.rdoAllPurchase.CheckedChanged += new System.EventHandler(this.rdoAllPurchase_CheckedChanged);
            // 
            // rdoLastPurchase
            // 
            this.rdoLastPurchase.AutoSize = true;
            this.rdoLastPurchase.Checked = true;
            this.rdoLastPurchase.Location = new System.Drawing.Point(6, 14);
            this.rdoLastPurchase.Name = "rdoLastPurchase";
            this.rdoLastPurchase.Size = new System.Drawing.Size(100, 19);
            this.rdoLastPurchase.TabIndex = 123;
            this.rdoLastPurchase.TabStop = true;
            this.rdoLastPurchase.Text = "Last Purchase";
            this.rdoLastPurchase.UseVisualStyleBackColor = true;
            this.rdoLastPurchase.CheckedChanged += new System.EventHandler(this.rdoLastPurchase_CheckedChanged);
            // 
            // rdoUsedPurchase
            // 
            this.rdoUsedPurchase.AutoSize = true;
            this.rdoUsedPurchase.Location = new System.Drawing.Point(108, 14);
            this.rdoUsedPurchase.Name = "rdoUsedPurchase";
            this.rdoUsedPurchase.Size = new System.Drawing.Size(103, 19);
            this.rdoUsedPurchase.TabIndex = 124;
            this.rdoUsedPurchase.TabStop = true;
            this.rdoUsedPurchase.Text = "UsedPurchase";
            this.rdoUsedPurchase.UseVisualStyleBackColor = true;
            this.rdoUsedPurchase.CheckedChanged += new System.EventHandler(this.rdoUsedPurchase_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoAllPurchase);
            this.groupBox2.Controls.Add(this.rdoLastPurchase);
            this.groupBox2.Controls.Add(this.rdoUsedPurchase);
            this.groupBox2.Location = new System.Drawing.Point(12, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 39);
            this.groupBox2.TabIndex = 126;
            this.groupBox2.TabStop = false;
            // 
            // txtSerial
            // 
            this.txtSerial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSerial.BackColor = System.Drawing.Color.White;
            this.txtSerial.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(68, 17);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(241, 25);
            this.txtSerial.TabIndex = 36;
            this.txtSerial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerial_KeyDown);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(614, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 39);
            this.button2.TabIndex = 152;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = global::Input.Properties.Resources.back24px;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(11, 495);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 33);
            this.btnBack.TabIndex = 151;
            this.btnBack.Text = "     Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblGroup
            // 
            this.lblGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.ForeColor = System.Drawing.Color.DarkGray;
            this.lblGroup.Location = new System.Drawing.Point(393, 19);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(19, 21);
            this.lblGroup.TabIndex = 150;
            this.lblGroup.Text = "1";
            // 
            // lblFFTOrderID
            // 
            this.lblFFTOrderID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFFTOrderID.AutoSize = true;
            this.lblFFTOrderID.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFFTOrderID.ForeColor = System.Drawing.Color.DarkGray;
            this.lblFFTOrderID.Location = new System.Drawing.Point(145, 18);
            this.lblFFTOrderID.Name = "lblFFTOrderID";
            this.lblFFTOrderID.Size = new System.Drawing.Size(84, 21);
            this.lblFFTOrderID.TabIndex = 149;
            this.lblFFTOrderID.Text = "CA190001";
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewHistory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewHistory.Location = new System.Drawing.Point(593, 15);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(131, 31);
            this.btnViewHistory.TabIndex = 148;
            this.btnViewHistory.Text = "View History Input";
            this.btnViewHistory.UseVisualStyleBackColor = true;
            this.btnViewHistory.Click += new System.EventHandler(this.btnViewHistory_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(464, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 45);
            this.label5.TabIndex = 147;
            this.label5.Text = "|";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(237, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 45);
            this.label4.TabIndex = 146;
            this.label4.Text = "|";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(269, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 19);
            this.label10.TabIndex = 145;
            this.label10.Text = "History Q\'ty :";
            // 
            // txtHistory
            // 
            this.txtHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHistory.BackColor = System.Drawing.Color.White;
            this.txtHistory.Enabled = false;
            this.txtHistory.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistory.Location = new System.Drawing.Point(367, 55);
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.Size = new System.Drawing.Size(95, 25);
            this.txtHistory.TabIndex = 144;
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalQty.BackColor = System.Drawing.Color.White;
            this.txtTotalQty.Enabled = false;
            this.txtTotalQty.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalQty.Location = new System.Drawing.Point(593, 56);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(95, 25);
            this.txtTotalQty.TabIndex = 143;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGray;
            this.label12.Location = new System.Drawing.Point(497, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 19);
            this.label12.TabIndex = 142;
            this.label12.Text = "Total Input :";
            // 
            // txtQtyOrder
            // 
            this.txtQtyOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQtyOrder.BackColor = System.Drawing.Color.White;
            this.txtQtyOrder.Enabled = false;
            this.txtQtyOrder.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtyOrder.Location = new System.Drawing.Point(138, 56);
            this.txtQtyOrder.Name = "txtQtyOrder";
            this.txtQtyOrder.Size = new System.Drawing.Size(97, 25);
            this.txtQtyOrder.TabIndex = 141;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(28, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 140;
            this.label6.Text = "Q\'ty In Order :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(334, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 139;
            this.label3.Text = "Group : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(28, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 138;
            this.label2.Text = "FFT_ORDER_ID : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dgvInputRMA);
            this.groupBox1.Controls.Add(this.cmbProcess);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtFlowName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbSelect_PurchaseNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSerial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(11, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 396);
            this.groupBox1.TabIndex = 137;
            this.groupBox1.TabStop = false;
            // 
            // pageRework_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblFFTOrderID);
            this.Controls.Add(this.btnViewHistory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHistory);
            this.Controls.Add(this.txtTotalQty);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtQtyOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "pageRework_Main";
            this.Size = new System.Drawing.Size(763, 535);
            this.Load += new System.EventHandler(this.pageRework_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputRMA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvInputRMA;
        private System.Windows.Forms.ComboBox cmbProcess;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFlowName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSelect_PurchaseNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoAllPurchase;
        private System.Windows.Forms.RadioButton rdoLastPurchase;
        private System.Windows.Forms.RadioButton rdoUsedPurchase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblFFTOrderID;
        private System.Windows.Forms.Button btnViewHistory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQtyOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
