namespace Input
{
    partial class frmSearch_SerialInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch_SerialInput));
            this.lblTotalRow = new System.Windows.Forms.Label();
            this.advgListSerialInput = new ADGV.AdvancedDataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtSerial = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkCancel = new System.Windows.Forms.CheckBox();
            this.chkUse = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpInputDate_Start = new System.Windows.Forms.DateTimePicker();
            this.dtpInputDate_End = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFFTOrder = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbPurchase = new System.Windows.Forms.ComboBox();
            this.bindingSourceSerialInput = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.advgListSerialInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSerialInput)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalRow
            // 
            this.lblTotalRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRow.AutoSize = true;
            this.lblTotalRow.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRow.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalRow.Location = new System.Drawing.Point(783, 615);
            this.lblTotalRow.Name = "lblTotalRow";
            this.lblTotalRow.Size = new System.Drawing.Size(161, 21);
            this.lblTotalRow.TabIndex = 122;
            this.lblTotalRow.Text = "Total rows : xxxxxxxxxx";
            // 
            // advgListSerialInput
            // 
            this.advgListSerialInput.AllowUserToAddRows = false;
            this.advgListSerialInput.AllowUserToDeleteRows = false;
            this.advgListSerialInput.AllowUserToResizeColumns = false;
            this.advgListSerialInput.AllowUserToResizeRows = false;
            this.advgListSerialInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advgListSerialInput.AutoGenerateContextFilters = true;
            this.advgListSerialInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.advgListSerialInput.BackgroundColor = System.Drawing.Color.White;
            this.advgListSerialInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advgListSerialInput.DateWithTime = false;
            this.advgListSerialInput.Location = new System.Drawing.Point(12, 277);
            this.advgListSerialInput.Name = "advgListSerialInput";
            this.advgListSerialInput.ReadOnly = true;
            this.advgListSerialInput.RowHeadersVisible = false;
            this.advgListSerialInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advgListSerialInput.Size = new System.Drawing.Size(930, 334);
            this.advgListSerialInput.TabIndex = 121;
            this.advgListSerialInput.TimeFilter = false;
            this.advgListSerialInput.SortStringChanged += new System.EventHandler(this.advgListSerialInput_SortStringChanged);
            this.advgListSerialInput.FilterStringChanged += new System.EventHandler(this.advgListSerialInput_FilterStringChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(768, 199);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(174, 66);
            this.btnSearch.TabIndex = 123;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Input.Properties.Resources.Header_SerialInput;
            this.pictureBox1.Location = new System.Drawing.Point(634, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 124;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.rtxtSerial);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 260);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Input Serial ";
            // 
            // rtxtSerial
            // 
            this.rtxtSerial.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.rtxtSerial.Location = new System.Drawing.Point(14, 23);
            this.rtxtSerial.Name = "rtxtSerial";
            this.rtxtSerial.Size = new System.Drawing.Size(234, 225);
            this.rtxtSerial.TabIndex = 133;
            this.rtxtSerial.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.chkCancel);
            this.groupBox2.Controls.Add(this.chkUse);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(642, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 101);
            this.groupBox2.TabIndex = 127;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Status ";
            // 
            // chkCancel
            // 
            this.chkCancel.AutoSize = true;
            this.chkCancel.Checked = true;
            this.chkCancel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCancel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCancel.Location = new System.Drawing.Point(19, 59);
            this.chkCancel.Name = "chkCancel";
            this.chkCancel.Size = new System.Drawing.Size(75, 25);
            this.chkCancel.TabIndex = 0;
            this.chkCancel.Text = "Cancel";
            this.chkCancel.UseVisualStyleBackColor = true;
            // 
            // chkUse
            // 
            this.chkUse.AutoSize = true;
            this.chkUse.Checked = true;
            this.chkUse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUse.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUse.Location = new System.Drawing.Point(19, 26);
            this.chkUse.Name = "chkUse";
            this.chkUse.Size = new System.Drawing.Size(55, 25);
            this.chkUse.TabIndex = 0;
            this.chkUse.Text = "Use";
            this.chkUse.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.dtpInputDate_Start);
            this.groupBox3.Controls.Add(this.dtpInputDate_End);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(288, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 75);
            this.groupBox3.TabIndex = 128;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Input Date ";
            // 
            // dtpInputDate_Start
            // 
            this.dtpInputDate_Start.Checked = false;
            this.dtpInputDate_Start.CustomFormat = "yyyy-MM-dd";
            this.dtpInputDate_Start.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInputDate_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInputDate_Start.Location = new System.Drawing.Point(20, 33);
            this.dtpInputDate_Start.Name = "dtpInputDate_Start";
            this.dtpInputDate_Start.ShowCheckBox = true;
            this.dtpInputDate_Start.Size = new System.Drawing.Size(170, 25);
            this.dtpInputDate_Start.TabIndex = 132;
            this.dtpInputDate_Start.ValueChanged += new System.EventHandler(this.dtpInputDate_Start_ValueChanged);
            // 
            // dtpInputDate_End
            // 
            this.dtpInputDate_End.Checked = false;
            this.dtpInputDate_End.CustomFormat = "yyyy-MM-dd";
            this.dtpInputDate_End.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInputDate_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInputDate_End.Location = new System.Drawing.Point(253, 33);
            this.dtpInputDate_End.Name = "dtpInputDate_End";
            this.dtpInputDate_End.ShowCheckBox = true;
            this.dtpInputDate_End.Size = new System.Drawing.Size(170, 25);
            this.dtpInputDate_End.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(207, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 23);
            this.label1.TabIndex = 130;
            this.label1.Text = "To";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(823, 153);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(119, 32);
            this.btnClearAll.TabIndex = 129;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.Controls.Add(this.txtGroup);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtFFTOrder);
            this.groupBox5.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(287, 84);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(341, 101);
            this.groupBox5.TabIndex = 131;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " FFT_Order ";
            // 
            // txtGroup
            // 
            this.txtGroup.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroup.Location = new System.Drawing.Point(62, 62);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(72, 25);
            this.txtGroup.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group";
            // 
            // txtFFTOrder
            // 
            this.txtFFTOrder.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFFTOrder.ForeColor = System.Drawing.Color.Black;
            this.txtFFTOrder.Location = new System.Drawing.Point(21, 23);
            this.txtFFTOrder.Name = "txtFFTOrder";
            this.txtFFTOrder.Size = new System.Drawing.Size(291, 25);
            this.txtFFTOrder.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox6.Controls.Add(this.cmbPurchase);
            this.groupBox6.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(288, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(340, 67);
            this.groupBox6.TabIndex = 132;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = " Purchase ";
            // 
            // cmbPurchase
            // 
            this.cmbPurchase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbPurchase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPurchase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPurchase.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPurchase.ForeColor = System.Drawing.Color.Black;
            this.cmbPurchase.FormattingEnabled = true;
            this.cmbPurchase.Location = new System.Drawing.Point(20, 26);
            this.cmbPurchase.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPurchase.Name = "cmbPurchase";
            this.cmbPurchase.Size = new System.Drawing.Size(291, 25);
            this.cmbPurchase.TabIndex = 133;
            // 
            // bindingSourceSerialInput
            // 
            this.bindingSourceSerialInput.CurrentChanged += new System.EventHandler(this.bindingSourceSerialInput_CurrentChanged);
            // 
            // frmSearch_SerialInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 645);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTotalRow);
            this.Controls.Add(this.advgListSerialInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearch_SerialInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Serial Input";
            this.Load += new System.EventHandler(this.frmSearch_SerialInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advgListSerialInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSerialInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalRow;
        private ADGV.AdvancedDataGridView advgListSerialInput;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkCancel;
        private System.Windows.Forms.CheckBox chkUse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpInputDate_End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFFTOrder;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.BindingSource bindingSourceSerialInput;
        private System.Windows.Forms.RichTextBox rtxtSerial;
        private System.Windows.Forms.ComboBox cmbPurchase;
        private System.Windows.Forms.DateTimePicker dtpInputDate_Start;
    }
}