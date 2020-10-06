namespace Input
{
    partial class frmSearchPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchPurchase));
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtpDate_Start = new System.Windows.Forms.DateTimePicker();
            this.dtpDate_End = new System.Windows.Forms.DateTimePicker();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.advgDataProcess = new ADGV.AdvancedDataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rtxtDocumentNo = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalRow = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkThisYear = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.bindingSourceData = new System.Windows.Forms.BindingSource(this.components);
            this.btnClearAll = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtPartNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFFTCode = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.picProcess = new System.Windows.Forms.PictureBox();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advgDataProcess)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceData)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 165;
            this.label1.Text = " Documant No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 627);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 172;
            this.label8.Text = "This Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 167;
            this.label3.Text = "Input date";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.dtpDate_Start);
            this.panel7.Controls.Add(this.dtpDate_End);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel11);
            this.panel7.ForeColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(243, 114);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(388, 52);
            this.panel7.TabIndex = 166;
            // 
            // dtpDate_Start
            // 
            this.dtpDate_Start.Checked = false;
            this.dtpDate_Start.CustomFormat = "yyyy-MM-dd";
            this.dtpDate_Start.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate_Start.Location = new System.Drawing.Point(11, 16);
            this.dtpDate_Start.Name = "dtpDate_Start";
            this.dtpDate_Start.ShowCheckBox = true;
            this.dtpDate_Start.Size = new System.Drawing.Size(159, 25);
            this.dtpDate_Start.TabIndex = 135;
            this.dtpDate_Start.ValueChanged += new System.EventHandler(this.dtpDate_Start_ValueChanged);
            // 
            // dtpDate_End
            // 
            this.dtpDate_End.Checked = false;
            this.dtpDate_End.CustomFormat = "yyyy-MM-dd";
            this.dtpDate_End.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate_End.Location = new System.Drawing.Point(225, 16);
            this.dtpDate_End.Name = "dtpDate_End";
            this.dtpDate_End.ShowCheckBox = true;
            this.dtpDate_End.Size = new System.Drawing.Size(155, 25);
            this.dtpDate_End.TabIndex = 134;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(386, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2, 48);
            this.panel8.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(2, 48);
            this.panel9.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(181, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 23);
            this.label4.TabIndex = 133;
            this.label4.Text = "To";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(388, 2);
            this.panel10.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 50);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(388, 2);
            this.panel11.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.advgDataProcess);
            this.panel1.Location = new System.Drawing.Point(4, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 447);
            this.panel1.TabIndex = 163;
            // 
            // advgDataProcess
            // 
            this.advgDataProcess.AllowUserToAddRows = false;
            this.advgDataProcess.AllowUserToDeleteRows = false;
            this.advgDataProcess.AllowUserToResizeColumns = false;
            this.advgDataProcess.AllowUserToResizeRows = false;
            this.advgDataProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advgDataProcess.AutoGenerateContextFilters = true;
            this.advgDataProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.advgDataProcess.BackgroundColor = System.Drawing.Color.White;
            this.advgDataProcess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advgDataProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advgDataProcess.DateWithTime = false;
            this.advgDataProcess.Location = new System.Drawing.Point(2, 2);
            this.advgDataProcess.Name = "advgDataProcess";
            this.advgDataProcess.ReadOnly = true;
            this.advgDataProcess.RowHeadersVisible = false;
            this.advgDataProcess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advgDataProcess.Size = new System.Drawing.Size(888, 443);
            this.advgDataProcess.TabIndex = 123;
            this.advgDataProcess.TimeFilter = false;
            this.advgDataProcess.SortStringChanged += new System.EventHandler(this.advgDataProcess_SortStringChanged);
            this.advgDataProcess.FilterStringChanged += new System.EventHandler(this.advgDataProcess_FilterStringChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(231, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2, 147);
            this.panel6.TabIndex = 3;
            // 
            // rtxtDocumentNo
            // 
            this.rtxtDocumentNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDocumentNo.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.rtxtDocumentNo.Location = new System.Drawing.Point(9, 13);
            this.rtxtDocumentNo.Name = "rtxtDocumentNo";
            this.rtxtDocumentNo.Size = new System.Drawing.Size(216, 127);
            this.rtxtDocumentNo.TabIndex = 134;
            this.rtxtDocumentNo.Text = "";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 147);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 2);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 2);
            this.panel3.TabIndex = 0;
            // 
            // lblTotalRow
            // 
            this.lblTotalRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRow.AutoSize = true;
            this.lblTotalRow.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRow.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalRow.Location = new System.Drawing.Point(723, 622);
            this.lblTotalRow.Name = "lblTotalRow";
            this.lblTotalRow.Size = new System.Drawing.Size(161, 21);
            this.lblTotalRow.TabIndex = 162;
            this.lblTotalRow.Text = "Total rows : xxxxxxxxxx";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.rtxtDocumentNo);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(4, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 151);
            this.panel2.TabIndex = 164;
            // 
            // chkThisYear
            // 
            this.chkThisYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkThisYear.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkThisYear.Checked = false;
            this.chkThisYear.CheckedOnColor = System.Drawing.Color.LightSteelBlue;
            this.chkThisYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkThisYear.ForeColor = System.Drawing.Color.White;
            this.chkThisYear.Location = new System.Drawing.Point(6, 625);
            this.chkThisYear.Name = "chkThisYear";
            this.chkThisYear.Size = new System.Drawing.Size(20, 20);
            this.chkThisYear.TabIndex = 171;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(768, 105);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 61);
            this.btnSearch.TabIndex = 168;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bindingSourceData
            // 
            this.bindingSourceData.CurrentChanged += new System.EventHandler(this.bindingSourceData_CurrentChanged);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(661, 123);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(101, 32);
            this.btnClearAll.TabIndex = 169;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Controls.Add(this.txtPartNo);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Controls.Add(this.txtFFTCode);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.panel14);
            this.panel12.Controls.Add(this.panel15);
            this.panel12.Controls.Add(this.panel16);
            this.panel12.ForeColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(243, 15);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(388, 85);
            this.panel12.TabIndex = 170;
            // 
            // txtPartNo
            // 
            this.txtPartNo.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartNo.ForeColor = System.Drawing.Color.Black;
            this.txtPartNo.Location = new System.Drawing.Point(108, 48);
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.Size = new System.Drawing.Size(272, 25);
            this.txtPartNo.TabIndex = 142;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 141;
            this.label7.Text = "Part No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 140;
            this.label6.Text = "FFT Code :";
            // 
            // txtFFTCode
            // 
            this.txtFFTCode.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFFTCode.ForeColor = System.Drawing.Color.Black;
            this.txtFFTCode.Location = new System.Drawing.Point(108, 13);
            this.txtFFTCode.Name = "txtFFTCode";
            this.txtFFTCode.Size = new System.Drawing.Size(272, 25);
            this.txtFFTCode.TabIndex = 4;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(386, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(2, 81);
            this.panel13.TabIndex = 3;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(0, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(2, 81);
            this.panel14.TabIndex = 2;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(388, 2);
            this.panel15.TabIndex = 1;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(0, 83);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(388, 2);
            this.panel16.TabIndex = 0;
            // 
            // picProcess
            // 
            this.picProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picProcess.Image = ((System.Drawing.Image)(resources.GetObject("picProcess.Image")));
            this.picProcess.Location = new System.Drawing.Point(634, 3);
            this.picProcess.Margin = new System.Windows.Forms.Padding(0);
            this.picProcess.Name = "picProcess";
            this.picProcess.Size = new System.Drawing.Size(262, 97);
            this.picProcess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProcess.TabIndex = 161;
            this.picProcess.TabStop = false;
            // 
            // frmSearchPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 649);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotalRow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chkThisYear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.picProcess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Purchase";
            this.Load += new System.EventHandler(this.frmSearchPurchase_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advgDataProcess)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceData)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dtpDate_Start;
        private System.Windows.Forms.DateTimePicker dtpDate_End;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel1;
        private ADGV.AdvancedDataGridView advgDataProcess;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox rtxtDocumentNo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalRow;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCheckbox chkThisYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource bindingSourceData;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtPartNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFFTCode;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.PictureBox picProcess;
    }
}