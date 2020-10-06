namespace Input
{
    partial class frmSearchFlows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchFlows));
            this.panel1 = new System.Windows.Forms.Panel();
            this.adgvFlow = new ADGV.AdvancedDataGridView();
            this.bindingSourceData = new System.Windows.Forms.BindingSource(this.components);
            this.picProcess = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgvFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.adgvFlow);
            this.panel1.Location = new System.Drawing.Point(12, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 333);
            this.panel1.TabIndex = 164;
            // 
            // adgvFlow
            // 
            this.adgvFlow.AllowUserToAddRows = false;
            this.adgvFlow.AllowUserToDeleteRows = false;
            this.adgvFlow.AllowUserToResizeColumns = false;
            this.adgvFlow.AllowUserToResizeRows = false;
            this.adgvFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adgvFlow.AutoGenerateContextFilters = true;
            this.adgvFlow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.adgvFlow.BackgroundColor = System.Drawing.Color.White;
            this.adgvFlow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adgvFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvFlow.DateWithTime = false;
            this.adgvFlow.Location = new System.Drawing.Point(2, 2);
            this.adgvFlow.Name = "adgvFlow";
            this.adgvFlow.ReadOnly = true;
            this.adgvFlow.RowHeadersVisible = false;
            this.adgvFlow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adgvFlow.Size = new System.Drawing.Size(883, 329);
            this.adgvFlow.TabIndex = 123;
            this.adgvFlow.TimeFilter = false;
            // 
            // picProcess
            // 
            this.picProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picProcess.Image = ((System.Drawing.Image)(resources.GetObject("picProcess.Image")));
            this.picProcess.Location = new System.Drawing.Point(9, 9);
            this.picProcess.Margin = new System.Windows.Forms.Padding(0);
            this.picProcess.Name = "picProcess";
            this.picProcess.Size = new System.Drawing.Size(893, 106);
            this.picProcess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProcess.TabIndex = 165;
            this.picProcess.TabStop = false;
            // 
            // frmSearchFlows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 475);
            this.Controls.Add(this.picProcess);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchFlows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Flow";
            this.Load += new System.EventHandler(this.frmSearchFlows_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adgvFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ADGV.AdvancedDataGridView adgvFlow;
        private System.Windows.Forms.BindingSource bindingSourceData;
        private System.Windows.Forms.PictureBox picProcess;
    }
}