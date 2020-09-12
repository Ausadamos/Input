namespace Input
{
    partial class pageCreate_ProductType
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.lstProductType = new System.Windows.Forms.ListBox();
            this.txtProductTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstHis = new System.Windows.Forms.ListBox();
            this.lblExNumberSerial = new System.Windows.Forms.Label();
            this.lblExYear = new System.Windows.Forms.Label();
            this.lblShowExFormatSerial = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductFormat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(509, 440);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(151, 41);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lstProductType
            // 
            this.lstProductType.BackColor = System.Drawing.Color.White;
            this.lstProductType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstProductType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstProductType.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProductType.ForeColor = System.Drawing.Color.Black;
            this.lstProductType.FormattingEnabled = true;
            this.lstProductType.ItemHeight = 30;
            this.lstProductType.Location = new System.Drawing.Point(6, 28);
            this.lstProductType.Name = "lstProductType";
            this.lstProductType.Size = new System.Drawing.Size(265, 450);
            this.lstProductType.TabIndex = 25;
            this.lstProductType.Click += new System.EventHandler(this.lstProductType_Click);
            this.lstProductType.SelectedIndexChanged += new System.EventHandler(this.lstProductType_SelectedIndexChanged);
            // 
            // txtProductTitle
            // 
            this.txtProductTitle.BackColor = System.Drawing.Color.White;
            this.txtProductTitle.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductTitle.Location = new System.Drawing.Point(443, 100);
            this.txtProductTitle.MaxLength = 255;
            this.txtProductTitle.Name = "txtProductTitle";
            this.txtProductTitle.Size = new System.Drawing.Size(354, 25);
            this.txtProductTitle.TabIndex = 1;
            this.txtProductTitle.TextChanged += new System.EventHandler(this.txtProductTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(387, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Title : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lblExNumberSerial);
            this.groupBox1.Controls.Add(this.lblExYear);
            this.groupBox1.Controls.Add(this.lblShowExFormatSerial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtProductFormat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(367, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 256);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Serial Format";
            // 
            // btnSet
            // 
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.ForeColor = System.Drawing.Color.Black;
            this.btnSet.Location = new System.Drawing.Point(26, 194);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(126, 44);
            this.btnSet.TabIndex = 47;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstHis);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Gray;
            this.groupBox3.Location = new System.Drawing.Point(211, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 130);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "History";
            // 
            // lstHis
            // 
            this.lstHis.BackColor = System.Drawing.Color.White;
            this.lstHis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstHis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstHis.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHis.ForeColor = System.Drawing.Color.DimGray;
            this.lstHis.FormattingEnabled = true;
            this.lstHis.ItemHeight = 17;
            this.lstHis.Location = new System.Drawing.Point(6, 21);
            this.lstHis.Name = "lstHis";
            this.lstHis.Size = new System.Drawing.Size(195, 102);
            this.lstHis.TabIndex = 25;
            this.lstHis.Click += new System.EventHandler(this.lstHis_Click);
            // 
            // lblExNumberSerial
            // 
            this.lblExNumberSerial.AutoSize = true;
            this.lblExNumberSerial.Location = new System.Drawing.Point(23, 133);
            this.lblExNumberSerial.Name = "lblExNumberSerial";
            this.lblExNumberSerial.Size = new System.Drawing.Size(107, 13);
            this.lblExNumberSerial.TabIndex = 46;
            this.lblExNumberSerial.Text = "XXXX  =  order serial ";
            this.lblExNumberSerial.Visible = false;
            // 
            // lblExYear
            // 
            this.lblExYear.AutoSize = true;
            this.lblExYear.Location = new System.Drawing.Point(23, 108);
            this.lblExYear.Name = "lblExYear";
            this.lblExYear.Size = new System.Drawing.Size(129, 13);
            this.lblExYear.TabIndex = 45;
            this.lblExYear.Text = "yy  =  year of manufacture";
            this.lblExYear.Visible = false;
            // 
            // lblShowExFormatSerial
            // 
            this.lblShowExFormatSerial.AutoSize = true;
            this.lblShowExFormatSerial.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowExFormatSerial.ForeColor = System.Drawing.Color.DarkGray;
            this.lblShowExFormatSerial.Location = new System.Drawing.Point(107, 72);
            this.lblShowExFormatSerial.Name = "lblShowExFormatSerial";
            this.lblShowExFormatSerial.Size = new System.Drawing.Size(118, 21);
            this.lblShowExFormatSerial.TabIndex = 44;
            this.lblShowExFormatSerial.Text = "Show Ex. Serial ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(22, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Example : ";
            // 
            // txtProductFormat
            // 
            this.txtProductFormat.BackColor = System.Drawing.Color.White;
            this.txtProductFormat.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductFormat.Location = new System.Drawing.Point(98, 27);
            this.txtProductFormat.MaxLength = 25;
            this.txtProductFormat.Name = "txtProductFormat";
            this.txtProductFormat.Size = new System.Drawing.Size(320, 25);
            this.txtProductFormat.TabIndex = 2;
            this.txtProductFormat.TextChanged += new System.EventHandler(this.txtProductFormat_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(22, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Format : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstProductType);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(36, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 493);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Product Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.label4.Location = new System.Drawing.Point(350, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Product :";
            // 
            // cmbProduct
            // 
            this.cmbProduct.BackColor = System.Drawing.Color.White;
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.ForeColor = System.Drawing.Color.Black;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(443, 60);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(354, 29);
            this.cmbProduct.TabIndex = 46;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // pageCreate_ProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtProductTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreate);
            this.Name = "pageCreate_ProductType";
            this.Size = new System.Drawing.Size(1130, 572);
            this.Load += new System.EventHandler(this.pageCreate_ProductType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ListBox lstProductType;
        private System.Windows.Forms.TextBox txtProductTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblShowExFormatSerial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblExNumberSerial;
        private System.Windows.Forms.Label lblExYear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstHis;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProduct;
    }
}
