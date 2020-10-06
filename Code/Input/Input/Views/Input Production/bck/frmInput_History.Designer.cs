namespace Input
{
    partial class frmInput_History
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInput_History));
            this.label9 = new System.Windows.Forms.Label();
            this.adgvHistory = new ADGV.AdvancedDataGridView();
            this.lblTotalRow = new System.Windows.Forms.Label();
            this.bindingSourceHistory = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adgvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(316, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 39);
            this.label9.TabIndex = 12;
            this.label9.Text = "History";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adgvHistory
            // 
            this.adgvHistory.AllowUserToAddRows = false;
            this.adgvHistory.AllowUserToDeleteRows = false;
            this.adgvHistory.AllowUserToResizeColumns = false;
            this.adgvHistory.AllowUserToResizeRows = false;
            this.adgvHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adgvHistory.AutoGenerateContextFilters = true;
            this.adgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.adgvHistory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.adgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvHistory.DateWithTime = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adgvHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.adgvHistory.Location = new System.Drawing.Point(12, 63);
            this.adgvHistory.MultiSelect = false;
            this.adgvHistory.Name = "adgvHistory";
            this.adgvHistory.ReadOnly = true;
            this.adgvHistory.RowHeadersVisible = false;
            this.adgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adgvHistory.Size = new System.Drawing.Size(723, 397);
            this.adgvHistory.TabIndex = 14;
            this.adgvHistory.TimeFilter = false;
            this.adgvHistory.SortStringChanged += new System.EventHandler(this.adgvHistory_SortStringChanged);
            this.adgvHistory.FilterStringChanged += new System.EventHandler(this.adgvHistory_FilterStringChanged);
            // 
            // lblTotalRow
            // 
            this.lblTotalRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRow.AutoSize = true;
            this.lblTotalRow.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalRow.Location = new System.Drawing.Point(621, 463);
            this.lblTotalRow.Name = "lblTotalRow";
            this.lblTotalRow.Size = new System.Drawing.Size(115, 13);
            this.lblTotalRow.TabIndex = 102;
            this.lblTotalRow.Text = "Total rows : xxxxxxxxxx";
            // 
            // bindingSourceHistory
            // 
            this.bindingSourceHistory.CurrentChanged += new System.EventHandler(this.bindingSourceHistory_CurrentChanged);
            // 
            // frmInput_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 496);
            this.Controls.Add(this.lblTotalRow);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.adgvHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInput_History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History ";
            this.Load += new System.EventHandler(this.frmInput_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adgvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private ADGV.AdvancedDataGridView adgvHistory;
        private System.Windows.Forms.BindingSource bindingSourceHistory;
        private System.Windows.Forms.Label lblTotalRow;
    }
}