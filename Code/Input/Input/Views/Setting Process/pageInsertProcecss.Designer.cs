namespace Input
{
    partial class pageInsertProcecss
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
            this.lstProcess = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoProcessInUse = new System.Windows.Forms.RadioButton();
            this.rdoProcessNonuse = new System.Windows.Forms.RadioButton();
            this.rdoPrcessAll = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtInsertProcess = new System.Windows.Forms.TextBox();
            this.rdoInsert = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.rdoUpdate = new System.Windows.Forms.RadioButton();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAddprocess = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlProcess = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.groupBox5.SuspendLayout();
            this.pnlAddprocess.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProcess
            // 
            this.lstProcess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstProcess.BackColor = System.Drawing.Color.White;
            this.lstProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstProcess.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProcess.ForeColor = System.Drawing.Color.Black;
            this.lstProcess.FormattingEnabled = true;
            this.lstProcess.ItemHeight = 21;
            this.lstProcess.Location = new System.Drawing.Point(17, 83);
            this.lstProcess.Name = "lstProcess";
            this.lstProcess.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstProcess.Size = new System.Drawing.Size(633, 401);
            this.lstProcess.TabIndex = 1;
            this.lstProcess.Click += new System.EventHandler(this.lstProcess_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdoProcessInUse);
            this.groupBox5.Controls.Add(this.rdoProcessNonuse);
            this.groupBox5.Controls.Add(this.rdoPrcessAll);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Location = new System.Drawing.Point(17, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(633, 47);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // rdoProcessInUse
            // 
            this.rdoProcessInUse.AutoSize = true;
            this.rdoProcessInUse.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoProcessInUse.Location = new System.Drawing.Point(253, 16);
            this.rdoProcessInUse.Name = "rdoProcessInUse";
            this.rdoProcessInUse.Size = new System.Drawing.Size(100, 19);
            this.rdoProcessInUse.TabIndex = 13;
            this.rdoProcessInUse.Text = "Process In Use";
            this.rdoProcessInUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoProcessInUse.UseVisualStyleBackColor = true;
            this.rdoProcessInUse.CheckedChanged += new System.EventHandler(this.rdoProcessInUse_CheckedChanged);
            // 
            // rdoProcessNonuse
            // 
            this.rdoProcessNonuse.AutoSize = true;
            this.rdoProcessNonuse.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoProcessNonuse.Location = new System.Drawing.Point(384, 16);
            this.rdoProcessNonuse.Name = "rdoProcessNonuse";
            this.rdoProcessNonuse.Size = new System.Drawing.Size(113, 19);
            this.rdoProcessNonuse.TabIndex = 14;
            this.rdoProcessNonuse.Text = "Process Non Use";
            this.rdoProcessNonuse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoProcessNonuse.UseVisualStyleBackColor = true;
            this.rdoProcessNonuse.CheckedChanged += new System.EventHandler(this.rdoProcessNonuse_CheckedChanged);
            // 
            // rdoPrcessAll
            // 
            this.rdoPrcessAll.AutoSize = true;
            this.rdoPrcessAll.Checked = true;
            this.rdoPrcessAll.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPrcessAll.Location = new System.Drawing.Point(142, 16);
            this.rdoPrcessAll.Name = "rdoPrcessAll";
            this.rdoPrcessAll.Size = new System.Drawing.Size(82, 19);
            this.rdoPrcessAll.TabIndex = 12;
            this.rdoPrcessAll.TabStop = true;
            this.rdoPrcessAll.Text = "All Process";
            this.rdoPrcessAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoPrcessAll.UseVisualStyleBackColor = true;
            this.rdoPrcessAll.CheckedChanged += new System.EventHandler(this.rdoPrcessAll_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(216, 72);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 37);
            this.btnAdd.TabIndex = 121;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtInsertProcess
            // 
            this.txtInsertProcess.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertProcess.Location = new System.Drawing.Point(21, 37);
            this.txtInsertProcess.Name = "txtInsertProcess";
            this.txtInsertProcess.Size = new System.Drawing.Size(317, 29);
            this.txtInsertProcess.TabIndex = 2;
            // 
            // rdoInsert
            // 
            this.rdoInsert.AutoSize = true;
            this.rdoInsert.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoInsert.ForeColor = System.Drawing.Color.Gray;
            this.rdoInsert.Location = new System.Drawing.Point(40, 173);
            this.rdoInsert.Name = "rdoInsert";
            this.rdoInsert.Size = new System.Drawing.Size(176, 29);
            this.rdoInsert.TabIndex = 32;
            this.rdoInsert.TabStop = true;
            this.rdoInsert.Text = "Add New Process";
            this.rdoInsert.UseVisualStyleBackColor = true;
            this.rdoInsert.CheckedChanged += new System.EventHandler(this.rdoInsert_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(211, 74);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 39);
            this.btnUpdate.TabIndex = 122;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 81);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 23);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status :";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(87, 79);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(97, 29);
            this.cmbStatus.TabIndex = 11;
            // 
            // txtUpdate
            // 
            this.txtUpdate.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdate.Location = new System.Drawing.Point(16, 31);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.ReadOnly = true;
            this.txtUpdate.Size = new System.Drawing.Size(317, 29);
            this.txtUpdate.TabIndex = 2;
            // 
            // rdoUpdate
            // 
            this.rdoUpdate.AutoSize = true;
            this.rdoUpdate.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoUpdate.ForeColor = System.Drawing.Color.Gray;
            this.rdoUpdate.Location = new System.Drawing.Point(46, 363);
            this.rdoUpdate.Name = "rdoUpdate";
            this.rdoUpdate.Size = new System.Drawing.Size(147, 29);
            this.rdoUpdate.TabIndex = 31;
            this.rdoUpdate.TabStop = true;
            this.rdoUpdate.Text = "Update Status";
            this.rdoUpdate.UseVisualStyleBackColor = true;
            this.rdoUpdate.CheckedChanged += new System.EventHandler(this.rdoUpdate_CheckedChanged);
            // 
            // cmbProduct
            // 
            this.cmbProduct.BackColor = System.Drawing.Color.White;
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.cmbProduct.ForeColor = System.Drawing.Color.Black;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(20, 35);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(317, 33);
            this.cmbProduct.TabIndex = 12;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Product";
            // 
            // pnlAddprocess
            // 
            this.pnlAddprocess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAddprocess.BackColor = System.Drawing.Color.White;
            this.pnlAddprocess.Controls.Add(this.btnAdd);
            this.pnlAddprocess.Controls.Add(this.txtInsertProcess);
            this.pnlAddprocess.Controls.Add(this.panel17);
            this.pnlAddprocess.Controls.Add(this.panel18);
            this.pnlAddprocess.Controls.Add(this.panel19);
            this.pnlAddprocess.Controls.Add(this.panel20);
            this.pnlAddprocess.Location = new System.Drawing.Point(28, 188);
            this.pnlAddprocess.Name = "pnlAddprocess";
            this.pnlAddprocess.Size = new System.Drawing.Size(354, 138);
            this.pnlAddprocess.TabIndex = 282;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(352, 2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(2, 134);
            this.panel17.TabIndex = 3;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.panel18.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel18.Location = new System.Drawing.Point(0, 2);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(2, 134);
            this.panel18.TabIndex = 2;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(354, 2);
            this.panel19.TabIndex = 1;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.panel20.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel20.Location = new System.Drawing.Point(0, 136);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(354, 2);
            this.panel20.TabIndex = 0;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlUpdate.BackColor = System.Drawing.Color.White;
            this.pnlUpdate.Controls.Add(this.btnUpdate);
            this.pnlUpdate.Controls.Add(this.lblStatus);
            this.pnlUpdate.Controls.Add(this.panel2);
            this.pnlUpdate.Controls.Add(this.cmbStatus);
            this.pnlUpdate.Controls.Add(this.panel3);
            this.pnlUpdate.Controls.Add(this.txtUpdate);
            this.pnlUpdate.Controls.Add(this.panel4);
            this.pnlUpdate.Controls.Add(this.panel5);
            this.pnlUpdate.Location = new System.Drawing.Point(26, 377);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(354, 138);
            this.pnlUpdate.TabIndex = 283;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(352, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 134);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 134);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 2);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(354, 2);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lstProcess);
            this.panel6.Controls.Add(this.groupBox5);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.pnlProcess);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Location = new System.Drawing.Point(422, 33);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(673, 517);
            this.panel6.TabIndex = 284;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(671, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 513);
            this.panel7.TabIndex = 3;
            // 
            // pnlProcess
            // 
            this.pnlProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.pnlProcess.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProcess.Location = new System.Drawing.Point(0, 2);
            this.pnlProcess.Name = "pnlProcess";
            this.pnlProcess.Size = new System.Drawing.Size(2, 513);
            this.pnlProcess.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(673, 2);
            this.panel9.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 515);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(673, 2);
            this.panel10.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.label2.Location = new System.Drawing.Point(441, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 285;
            this.label2.Text = "Process";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.cmbProduct);
            this.panel1.Location = new System.Drawing.Point(26, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 105);
            this.panel1.TabIndex = 286;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(352, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2, 101);
            this.panel8.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(2, 101);
            this.panel11.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(354, 2);
            this.panel12.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 103);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(354, 2);
            this.panel13.TabIndex = 0;
            // 
            // pageInsertProcecss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.rdoUpdate);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.rdoInsert);
            this.Controls.Add(this.pnlAddprocess);
            this.Name = "pageInsertProcecss";
            this.Size = new System.Drawing.Size(1130, 589);
            this.Load += new System.EventHandler(this.pageInsertProcecss_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.pnlAddprocess.ResumeLayout(false);
            this.pnlAddprocess.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstProcess;
        private System.Windows.Forms.TextBox txtInsertProcess;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.RadioButton rdoPrcessAll;
        private System.Windows.Forms.RadioButton rdoProcessInUse;
        private System.Windows.Forms.RadioButton rdoProcessNonuse;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.RadioButton rdoInsert;
        private System.Windows.Forms.RadioButton rdoUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAddprocess;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnlProcess;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
    }
}
