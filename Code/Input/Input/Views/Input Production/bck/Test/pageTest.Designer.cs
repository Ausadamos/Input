namespace Input
{
    partial class pageTest
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoTestManufac = new System.Windows.Forms.RadioButton();
            this.rdoTestInitial = new System.Windows.Forms.RadioButton();
            this.panBodyTest = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoTestManufac);
            this.groupBox2.Controls.Add(this.rdoTestInitial);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(12, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 48);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Select Test Type ";
            // 
            // rdoTestManufac
            // 
            this.rdoTestManufac.AutoSize = true;
            this.rdoTestManufac.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTestManufac.Location = new System.Drawing.Point(242, 17);
            this.rdoTestManufac.Name = "rdoTestManufac";
            this.rdoTestManufac.Size = new System.Drawing.Size(208, 23);
            this.rdoTestManufac.TabIndex = 1;
            this.rdoTestManufac.TabStop = true;
            this.rdoTestManufac.Text = "Manufacturing (Old Serial)";
            this.rdoTestManufac.UseVisualStyleBackColor = true;
            this.rdoTestManufac.CheckedChanged += new System.EventHandler(this.rdoTestManufac_CheckedChanged);
            // 
            // rdoTestInitial
            // 
            this.rdoTestInitial.AutoSize = true;
            this.rdoTestInitial.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTestInitial.Location = new System.Drawing.Point(16, 17);
            this.rdoTestInitial.Name = "rdoTestInitial";
            this.rdoTestInitial.Size = new System.Drawing.Size(195, 23);
            this.rdoTestInitial.TabIndex = 0;
            this.rdoTestInitial.TabStop = true;
            this.rdoTestInitial.Text = "Initial (Create Serial Test)";
            this.rdoTestInitial.UseVisualStyleBackColor = true;
            this.rdoTestInitial.CheckedChanged += new System.EventHandler(this.rdoTestInitial_CheckedChanged);
            // 
            // panBodyTest
            // 
            this.panBodyTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panBodyTest.BackColor = System.Drawing.Color.DimGray;
            this.panBodyTest.Location = new System.Drawing.Point(5, 57);
            this.panBodyTest.Name = "panBodyTest";
            this.panBodyTest.Size = new System.Drawing.Size(753, 471);
            this.panBodyTest.TabIndex = 49;
            // 
            // pageTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panBodyTest);
            this.Controls.Add(this.groupBox2);
            this.Name = "pageTest";
            this.Size = new System.Drawing.Size(763, 535);
            this.Load += new System.EventHandler(this.pageTest_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoTestManufac;
        private System.Windows.Forms.RadioButton rdoTestInitial;
        public System.Windows.Forms.Panel panBodyTest;
    }
}
