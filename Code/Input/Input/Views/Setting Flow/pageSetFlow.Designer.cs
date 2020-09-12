namespace Input
{
    partial class pageSetFlow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.advgListFlow = new ADGV.AdvancedDataGridView();
            this.bindingSourceFlowAll = new System.Windows.Forms.BindingSource(this.components);
            this.lblTotalRow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.advgListFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFlowAll)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(11, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "List Flow All";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(153, 33);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(209, 59);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "Create New ";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(392, 34);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(209, 58);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update Status";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // advgListFlow
            // 
            this.advgListFlow.AllowUserToAddRows = false;
            this.advgListFlow.AllowUserToDeleteRows = false;
            this.advgListFlow.AllowUserToResizeColumns = false;
            this.advgListFlow.AllowUserToResizeRows = false;
            this.advgListFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advgListFlow.AutoGenerateContextFilters = true;
            this.advgListFlow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.advgListFlow.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advgListFlow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.advgListFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advgListFlow.DateWithTime = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advgListFlow.DefaultCellStyle = dataGridViewCellStyle2;
            this.advgListFlow.Location = new System.Drawing.Point(16, 132);
            this.advgListFlow.MultiSelect = false;
            this.advgListFlow.Name = "advgListFlow";
            this.advgListFlow.ReadOnly = true;
            this.advgListFlow.RowHeadersVisible = false;
            this.advgListFlow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advgListFlow.Size = new System.Drawing.Size(732, 363);
            this.advgListFlow.TabIndex = 25;
            this.advgListFlow.TimeFilter = false;
            this.advgListFlow.SortStringChanged += new System.EventHandler(this.advgListFlow_SortStringChanged);
            this.advgListFlow.FilterStringChanged += new System.EventHandler(this.advgListFlow_FilterStringChanged);
            // 
            // bindingSourceFlowAll
            // 
            this.bindingSourceFlowAll.CurrentChanged += new System.EventHandler(this.bindingSourceFlowAll_CurrentChanged);
            // 
            // lblTotalRow
            // 
            this.lblTotalRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRow.AutoSize = true;
            this.lblTotalRow.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalRow.Location = new System.Drawing.Point(641, 500);
            this.lblTotalRow.Name = "lblTotalRow";
            this.lblTotalRow.Size = new System.Drawing.Size(115, 13);
            this.lblTotalRow.TabIndex = 103;
            this.lblTotalRow.Text = "Total rows : xxxxxxxxxx";
            // 
            // pageSetFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTotalRow);
            this.Controls.Add(this.advgListFlow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnUpdate);
            this.Name = "pageSetFlow";
            this.Size = new System.Drawing.Size(764, 532);
            this.Load += new System.EventHandler(this.pageSetFlow_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advgListFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFlowAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource bindingSourceFlowAll;
        private ADGV.AdvancedDataGridView advgListFlow;
        private System.Windows.Forms.Label lblTotalRow;
    }
}
