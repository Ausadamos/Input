namespace Input.Views.Input
{
    partial class pageInput_History
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
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.bttBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(18, 66);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.Size = new System.Drawing.Size(725, 352);
            this.advancedDataGridView1.TabIndex = 0;
            this.advancedDataGridView1.TimeFilter = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(272, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 47);
            this.label9.TabIndex = 10;
            this.label9.Text = " Order History";
            // 
            // bttBack
            // 
            this.bttBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttBack.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttBack.Location = new System.Drawing.Point(15, 488);
            this.bttBack.Name = "bttBack";
            this.bttBack.Size = new System.Drawing.Size(111, 35);
            this.bttBack.TabIndex = 13;
            this.bttBack.Text = "Back";
            this.bttBack.UseVisualStyleBackColor = true;
            // 
            // pageInput_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bttBack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.advancedDataGridView1);
            this.Name = "pageInput_History";
            this.Size = new System.Drawing.Size(763, 535);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bttBack;
    }
}
