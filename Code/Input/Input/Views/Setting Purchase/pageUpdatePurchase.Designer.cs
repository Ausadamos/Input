namespace Input
{
    partial class pageUpdateProcessCard
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
            this.components = new System.ComponentModel.Container();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.lblTPuurchase = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblShowFileName = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.txtPathProcessCard = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bindingSourcePurcAll = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.txtFlow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbFlow = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFFTCode = new System.Windows.Forms.Label();
            this.lblPART_NO = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblModelNO = new System.Windows.Forms.Label();
            this.treeViewSetProcess = new System.Windows.Forms.TreeView();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePurcAll)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(785, 454);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 55);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchase.Location = new System.Drawing.Point(264, 55);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(59, 20);
            this.lblPurchase.TabIndex = 30;
            this.lblPurchase.Text = "- - - - - -";
            // 
            // lblTPuurchase
            // 
            this.lblTPuurchase.AutoSize = true;
            this.lblTPuurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPuurchase.ForeColor = System.Drawing.Color.Gray;
            this.lblTPuurchase.Location = new System.Drawing.Point(124, 55);
            this.lblTPuurchase.Margin = new System.Windows.Forms.Padding(15);
            this.lblTPuurchase.Name = "lblTPuurchase";
            this.lblTPuurchase.Size = new System.Drawing.Size(134, 20);
            this.lblTPuurchase.TabIndex = 27;
            this.lblTPuurchase.Text = "PURCHASE NO :";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.lblShowFileName);
            this.groupBox4.Controls.Add(this.btnChooseFile);
            this.groupBox4.Controls.Add(this.txtPathProcessCard);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(128, 331);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(428, 103);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Process Card";
            // 
            // lblShowFileName
            // 
            this.lblShowFileName.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowFileName.ForeColor = System.Drawing.Color.DarkGray;
            this.lblShowFileName.Location = new System.Drawing.Point(236, 24);
            this.lblShowFileName.Name = "lblShowFileName";
            this.lblShowFileName.Size = new System.Drawing.Size(186, 34);
            this.lblShowFileName.TabIndex = 43;
            this.lblShowFileName.Text = "Show file name.";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFile.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFile.ForeColor = System.Drawing.Color.Black;
            this.btnChooseFile.Location = new System.Drawing.Point(140, 24);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(85, 26);
            this.btnChooseFile.TabIndex = 42;
            this.btnChooseFile.Text = "Choose Flie";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // txtPathProcessCard
            // 
            this.txtPathProcessCard.BackColor = System.Drawing.Color.White;
            this.txtPathProcessCard.Enabled = false;
            this.txtPathProcessCard.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathProcessCard.Location = new System.Drawing.Point(15, 61);
            this.txtPathProcessCard.MaxLength = 255;
            this.txtPathProcessCard.Name = "txtPathProcessCard";
            this.txtPathProcessCard.ReadOnly = true;
            this.txtPathProcessCard.Size = new System.Drawing.Size(407, 25);
            this.txtPathProcessCard.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Flie process card";
            // 
            // bindingSourcePurcAll
            // 
            this.bindingSourcePurcAll.CurrentChanged += new System.EventHandler(this.bindingSourcePurcAll_CurrentChanged);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(128, 462);
            this.btnBack.Margin = new System.Windows.Forms.Padding(10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 40);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtFlow
            // 
            this.txtFlow.BackColor = System.Drawing.Color.White;
            this.txtFlow.Enabled = false;
            this.txtFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlow.Location = new System.Drawing.Point(239, 144);
            this.txtFlow.MaxLength = 255;
            this.txtFlow.Name = "txtFlow";
            this.txtFlow.ReadOnly = true;
            this.txtFlow.Size = new System.Drawing.Size(151, 26);
            this.txtFlow.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(124, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "FLOW NAME :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.treeViewSetProcess);
            this.groupBox2.Controls.Add(this.cmbFlow);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(645, 55);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 379);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Flow";
            // 
            // cmbFlow
            // 
            this.cmbFlow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlow.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.cmbFlow.FormattingEnabled = true;
            this.cmbFlow.Location = new System.Drawing.Point(17, 24);
            this.cmbFlow.Name = "cmbFlow";
            this.cmbFlow.Size = new System.Drawing.Size(181, 25);
            this.cmbFlow.TabIndex = 0;
            this.cmbFlow.SelectedIndexChanged += new System.EventHandler(this.cmbFlow_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "List Process.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(124, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "FFT CODE ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(124, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "PART NO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(124, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "PRODUCT NAME :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(124, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "MODEL NO :";
            // 
            // lblFFTCode
            // 
            this.lblFFTCode.AutoSize = true;
            this.lblFFTCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFFTCode.Location = new System.Drawing.Point(245, 101);
            this.lblFFTCode.Name = "lblFFTCode";
            this.lblFFTCode.Size = new System.Drawing.Size(59, 20);
            this.lblFFTCode.TabIndex = 54;
            this.lblFFTCode.Text = "- - - - - -";
            // 
            // lblPART_NO
            // 
            this.lblPART_NO.AutoSize = true;
            this.lblPART_NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPART_NO.Location = new System.Drawing.Point(210, 193);
            this.lblPART_NO.Name = "lblPART_NO";
            this.lblPART_NO.Size = new System.Drawing.Size(59, 20);
            this.lblPART_NO.TabIndex = 55;
            this.lblPART_NO.Text = "- - - - - -";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(274, 239);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(59, 20);
            this.lblProductName.TabIndex = 56;
            this.lblProductName.Text = "- - - - - -";
            // 
            // lblModelNO
            // 
            this.lblModelNO.AutoSize = true;
            this.lblModelNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelNO.Location = new System.Drawing.Point(235, 285);
            this.lblModelNO.Name = "lblModelNO";
            this.lblModelNO.Size = new System.Drawing.Size(59, 20);
            this.lblModelNO.TabIndex = 57;
            this.lblModelNO.Text = "- - - - - -";
            // 
            // treeViewSetProcess
            // 
            this.treeViewSetProcess.Location = new System.Drawing.Point(10, 75);
            this.treeViewSetProcess.Name = "treeViewSetProcess";
            this.treeViewSetProcess.Size = new System.Drawing.Size(240, 290);
            this.treeViewSetProcess.TabIndex = 38;
            // 
            // pageUpdateProcessCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblModelNO);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblPART_NO);
            this.Controls.Add(this.lblFFTCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFlow);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblPurchase);
            this.Controls.Add(this.lblTPuurchase);
            this.Name = "pageUpdateProcessCard";
            this.Size = new System.Drawing.Size(1130, 589);
            this.Load += new System.EventHandler(this.pageUpdatePurchase_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePurcAll)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.Label lblTPuurchase;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblShowFileName;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox txtPathProcessCard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bindingSourcePurcAll;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtFlow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbFlow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFFTCode;
        private System.Windows.Forms.Label lblPART_NO;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblModelNO;
        private System.Windows.Forms.TreeView treeViewSetProcess;
    }
}
