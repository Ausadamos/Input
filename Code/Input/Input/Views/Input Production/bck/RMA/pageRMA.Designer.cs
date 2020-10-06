namespace Input
{
    partial class pageRMA
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
            this.rdoRMARework = new System.Windows.Forms.RadioButton();
            this.rdoRMAInvastigate = new System.Windows.Forms.RadioButton();
            this.panBodyRMA = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoRMARework);
            this.groupBox2.Controls.Add(this.rdoRMAInvastigate);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(12, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 48);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Select RMA Type";
            // 
            // rdoRMARework
            // 
            this.rdoRMARework.AutoSize = true;
            this.rdoRMARework.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRMARework.Location = new System.Drawing.Point(140, 17);
            this.rdoRMARework.Name = "rdoRMARework";
            this.rdoRMARework.Size = new System.Drawing.Size(80, 23);
            this.rdoRMARework.TabIndex = 1;
            this.rdoRMARework.TabStop = true;
            this.rdoRMARework.Text = "Rework";
            this.rdoRMARework.UseVisualStyleBackColor = true;
            this.rdoRMARework.CheckedChanged += new System.EventHandler(this.rdoRMARework_CheckedChanged);
            // 
            // rdoRMAInvastigate
            // 
            this.rdoRMAInvastigate.AutoSize = true;
            this.rdoRMAInvastigate.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRMAInvastigate.Location = new System.Drawing.Point(26, 17);
            this.rdoRMAInvastigate.Name = "rdoRMAInvastigate";
            this.rdoRMAInvastigate.Size = new System.Drawing.Size(103, 23);
            this.rdoRMAInvastigate.TabIndex = 0;
            this.rdoRMAInvastigate.TabStop = true;
            this.rdoRMAInvastigate.Text = "Investigate";
            this.rdoRMAInvastigate.UseVisualStyleBackColor = true;
            this.rdoRMAInvastigate.CheckedChanged += new System.EventHandler(this.rdoRMAInvastigate_CheckedChanged);
            // 
            // panBodyRMA
            // 
            this.panBodyRMA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panBodyRMA.BackColor = System.Drawing.Color.DimGray;
            this.panBodyRMA.Location = new System.Drawing.Point(5, 57);
            this.panBodyRMA.Name = "panBodyRMA";
            this.panBodyRMA.Size = new System.Drawing.Size(753, 471);
            this.panBodyRMA.TabIndex = 48;
            // 
            // pageRMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panBodyRMA);
            this.Controls.Add(this.groupBox2);
            this.Name = "pageRMA";
            this.Size = new System.Drawing.Size(763, 535);
            this.Load += new System.EventHandler(this.pageRMA_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoRMARework;
        private System.Windows.Forms.RadioButton rdoRMAInvastigate;
        private System.Windows.Forms.Panel panBodyRMA;
    }
}
