namespace Input
{
    partial class pageCreateFlow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstProcess = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeViewSetProcess = new System.Windows.Forms.TreeView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.btnDownProcess = new System.Windows.Forms.Button();
            this.btnUpProcess = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstSubProcess = new System.Windows.Forms.ListBox();
            this.btnAddProcess = new System.Windows.Forms.Button();
            this.btnRemoveProcess = new System.Windows.Forms.Button();
            this.btnRemoveProcessSub = new System.Windows.Forms.Button();
            this.btnAddProcessSub = new System.Windows.Forms.Button();
            this.btnDownProcessSub = new System.Windows.Forms.Button();
            this.btnUpProcessSub = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtProcessSelected = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFlowName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstProcess);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(24, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 413);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " List Main Process All";
            // 
            // lstProcess
            // 
            this.lstProcess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstProcess.BackColor = System.Drawing.Color.White;
            this.lstProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstProcess.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProcess.FormattingEnabled = true;
            this.lstProcess.ItemHeight = 21;
            this.lstProcess.Location = new System.Drawing.Point(21, 45);
            this.lstProcess.Name = "lstProcess";
            this.lstProcess.Size = new System.Drawing.Size(234, 338);
            this.lstProcess.TabIndex = 1;
            this.lstProcess.Click += new System.EventHandler(this.lstProcess_Click);
            this.lstProcess.DoubleClick += new System.EventHandler(this.lstProcess_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeViewSetProcess);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(405, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 413);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Process Flow ";
            // 
            // treeViewSetProcess
            // 
            this.treeViewSetProcess.Location = new System.Drawing.Point(15, 28);
            this.treeViewSetProcess.Name = "treeViewSetProcess";
            this.treeViewSetProcess.Size = new System.Drawing.Size(285, 374);
            this.treeViewSetProcess.TabIndex = 0;
            this.treeViewSetProcess.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSetProcess_AfterSelect);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnCreate.Location = new System.Drawing.Point(526, 527);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(99, 38);
            this.btnCreate.TabIndex = 23;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(8, 27);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(261, 29);
            this.cmbProduct.TabIndex = 47;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // btnDownProcess
            // 
            this.btnDownProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnDownProcess.FlatAppearance.BorderSize = 0;
            this.btnDownProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownProcess.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownProcess.Image = global::Input.Properties.Resources.down_chevron;
            this.btnDownProcess.Location = new System.Drawing.Point(339, 380);
            this.btnDownProcess.Name = "btnDownProcess";
            this.btnDownProcess.Size = new System.Drawing.Size(33, 28);
            this.btnDownProcess.TabIndex = 28;
            this.btnDownProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownProcess.UseVisualStyleBackColor = false;
            this.btnDownProcess.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUpProcess
            // 
            this.btnUpProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnUpProcess.FlatAppearance.BorderSize = 0;
            this.btnUpProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpProcess.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpProcess.Image = global::Input.Properties.Resources.up_chevron;
            this.btnUpProcess.Location = new System.Drawing.Point(339, 341);
            this.btnUpProcess.Name = "btnUpProcess";
            this.btnUpProcess.Size = new System.Drawing.Size(33, 28);
            this.btnUpProcess.TabIndex = 27;
            this.btnUpProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpProcess.UseVisualStyleBackColor = false;
            this.btnUpProcess.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = global::Input.Properties.Resources.back24px;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(24, 534);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 38);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "    Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstSubProcess
            // 
            this.lstSubProcess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstSubProcess.BackColor = System.Drawing.Color.White;
            this.lstSubProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSubProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstSubProcess.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSubProcess.FormattingEnabled = true;
            this.lstSubProcess.ItemHeight = 21;
            this.lstSubProcess.Location = new System.Drawing.Point(16, 69);
            this.lstSubProcess.Name = "lstSubProcess";
            this.lstSubProcess.Size = new System.Drawing.Size(266, 317);
            this.lstSubProcess.TabIndex = 0;
            this.lstSubProcess.DoubleClick += new System.EventHandler(this.lstSubProcess_DoubleClick);
            // 
            // btnAddProcess
            // 
            this.btnAddProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProcess.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProcess.Image = global::Input.Properties.Resources.right_chevron;
            this.btnAddProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProcess.Location = new System.Drawing.Point(315, 228);
            this.btnAddProcess.Name = "btnAddProcess";
            this.btnAddProcess.Size = new System.Drawing.Size(79, 28);
            this.btnAddProcess.TabIndex = 25;
            this.btnAddProcess.Text = "  Add  ";
            this.btnAddProcess.UseVisualStyleBackColor = false;
            this.btnAddProcess.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveProcess
            // 
            this.btnRemoveProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProcess.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProcess.Image = global::Input.Properties.Resources.left_chevron;
            this.btnRemoveProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveProcess.Location = new System.Drawing.Point(316, 280);
            this.btnRemoveProcess.Name = "btnRemoveProcess";
            this.btnRemoveProcess.Size = new System.Drawing.Size(79, 28);
            this.btnRemoveProcess.TabIndex = 26;
            this.btnRemoveProcess.Text = " Remove";
            this.btnRemoveProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveProcess.UseVisualStyleBackColor = false;
            this.btnRemoveProcess.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveProcessSub
            // 
            this.btnRemoveProcessSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveProcessSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProcessSub.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProcessSub.Image = global::Input.Properties.Resources.right_chevron;
            this.btnRemoveProcessSub.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveProcessSub.Location = new System.Drawing.Point(731, 280);
            this.btnRemoveProcessSub.Name = "btnRemoveProcessSub";
            this.btnRemoveProcessSub.Size = new System.Drawing.Size(79, 28);
            this.btnRemoveProcessSub.TabIndex = 33;
            this.btnRemoveProcessSub.Text = "Remove    ";
            this.btnRemoveProcessSub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveProcessSub.UseVisualStyleBackColor = false;
            this.btnRemoveProcessSub.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddProcessSub
            // 
            this.btnAddProcessSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddProcessSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProcessSub.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProcessSub.Image = global::Input.Properties.Resources.left_chevron;
            this.btnAddProcessSub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProcessSub.Location = new System.Drawing.Point(731, 228);
            this.btnAddProcessSub.Name = "btnAddProcessSub";
            this.btnAddProcessSub.Size = new System.Drawing.Size(79, 28);
            this.btnAddProcessSub.TabIndex = 32;
            this.btnAddProcessSub.Text = "  Add  ";
            this.btnAddProcessSub.UseVisualStyleBackColor = false;
            this.btnAddProcessSub.Click += new System.EventHandler(this.btnAddProcessSub_Click);
            // 
            // btnDownProcessSub
            // 
            this.btnDownProcessSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnDownProcessSub.FlatAppearance.BorderSize = 0;
            this.btnDownProcessSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownProcessSub.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownProcessSub.Image = global::Input.Properties.Resources.down_chevron;
            this.btnDownProcessSub.Location = new System.Drawing.Point(756, 380);
            this.btnDownProcessSub.Name = "btnDownProcessSub";
            this.btnDownProcessSub.Size = new System.Drawing.Size(33, 28);
            this.btnDownProcessSub.TabIndex = 35;
            this.btnDownProcessSub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownProcessSub.UseVisualStyleBackColor = false;
            this.btnDownProcessSub.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUpProcessSub
            // 
            this.btnUpProcessSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnUpProcessSub.FlatAppearance.BorderSize = 0;
            this.btnUpProcessSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpProcessSub.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpProcessSub.Image = global::Input.Properties.Resources.up_chevron;
            this.btnUpProcessSub.Location = new System.Drawing.Point(756, 341);
            this.btnUpProcessSub.Name = "btnUpProcessSub";
            this.btnUpProcessSub.Size = new System.Drawing.Size(33, 28);
            this.btnUpProcessSub.TabIndex = 34;
            this.btnUpProcessSub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpProcessSub.UseVisualStyleBackColor = false;
            this.btnUpProcessSub.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtProcessSelected);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.lstSubProcess);
            this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.Gray;
            this.groupBox7.Location = new System.Drawing.Point(817, 102);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(301, 413);
            this.groupBox7.TabIndex = 36;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "List Sub Process All";
            // 
            // txtProcessSelected
            // 
            this.txtProcessSelected.AutoSize = true;
            this.txtProcessSelected.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.txtProcessSelected.Location = new System.Drawing.Point(13, 46);
            this.txtProcessSelected.Name = "txtProcessSelected";
            this.txtProcessSelected.Size = new System.Drawing.Size(37, 21);
            this.txtProcessSelected.TabIndex = 51;
            this.txtProcessSelected.Text = "XXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Process : ";
            // 
            // txtFlowName
            // 
            this.txtFlowName.AutoSize = true;
            this.txtFlowName.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtFlowName.Location = new System.Drawing.Point(11, 27);
            this.txtFlowName.Name = "txtFlowName";
            this.txtFlowName.Size = new System.Drawing.Size(48, 25);
            this.txtFlowName.TabIndex = 51;
            this.txtFlowName.Text = "XXX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(416, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 675;
            this.label4.Text = "Flow Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Controls.Add(this.txtFlowName);
            this.Panel1.Controls.Add(this.Panel4);
            this.Panel1.Controls.Add(this.Panel5);
            this.Panel1.Location = new System.Drawing.Point(405, 16);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(316, 75);
            this.Panel1.TabIndex = 674;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel2.Location = new System.Drawing.Point(314, 2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(2, 71);
            this.Panel2.TabIndex = 3;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel3.Location = new System.Drawing.Point(0, 2);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(2, 71);
            this.Panel3.TabIndex = 2;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel4.Location = new System.Drawing.Point(0, 0);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(316, 2);
            this.Panel4.TabIndex = 1;
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel5.Location = new System.Drawing.Point(0, 73);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(316, 2);
            this.Panel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(32, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 677;
            this.label2.Text = "Product";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.cmbProduct);
            this.panel6.Location = new System.Drawing.Point(24, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(277, 75);
            this.panel6.TabIndex = 676;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SteelBlue;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(275, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 71);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SteelBlue;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2, 71);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SteelBlue;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(277, 2);
            this.panel9.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SteelBlue;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 73);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(277, 2);
            this.panel10.TabIndex = 0;
            // 
            // pageCreateFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnAddProcessSub);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btnDownProcessSub);
            this.Controls.Add(this.btnDownProcess);
            this.Controls.Add(this.btnUpProcessSub);
            this.Controls.Add(this.btnUpProcess);
            this.Controls.Add(this.btnRemoveProcess);
            this.Controls.Add(this.btnRemoveProcessSub);
            this.Controls.Add(this.btnAddProcess);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "pageCreateFlow";
            this.Size = new System.Drawing.Size(1130, 581);
            this.Load += new System.EventHandler(this.pageCreateFlow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstProcess;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDownProcess;
        private System.Windows.Forms.Button btnUpProcess;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.TreeView treeViewSetProcess;
        private System.Windows.Forms.ListBox lstSubProcess;
        private System.Windows.Forms.Button btnAddProcess;
        private System.Windows.Forms.Button btnRemoveProcess;
        private System.Windows.Forms.Button btnRemoveProcessSub;
        private System.Windows.Forms.Button btnAddProcessSub;
        private System.Windows.Forms.Button btnDownProcessSub;
        private System.Windows.Forms.Button btnUpProcessSub;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label txtProcessSelected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtFlowName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.Panel Panel4;
        private System.Windows.Forms.Panel Panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
    }
}
