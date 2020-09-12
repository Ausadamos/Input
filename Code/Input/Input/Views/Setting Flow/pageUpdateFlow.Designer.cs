namespace Input
{
    partial class pageUpdateFlow
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
            this.lblFlowName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblTFlowName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalRow = new System.Windows.Forms.Label();
            this.dgvFlow = new ADGV.AdvancedDataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.bindingSourceFlow = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFlow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFlowName
            // 
            this.lblFlowName.AutoSize = true;
            this.lblFlowName.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlowName.Location = new System.Drawing.Point(156, 38);
            this.lblFlowName.Name = "lblFlowName";
            this.lblFlowName.Size = new System.Drawing.Size(66, 21);
            this.lblFlowName.TabIndex = 9;
            this.lblFlowName.Text = "- - - - - -";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(48, 88);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 23);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status :";
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.White;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Use",
            "Cancel"});
            this.cmbStatus.Location = new System.Drawing.Point(124, 86);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(125, 29);
            this.cmbStatus.TabIndex = 7;
            // 
            // lblTFlowName
            // 
            this.lblTFlowName.AutoSize = true;
            this.lblTFlowName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTFlowName.ForeColor = System.Drawing.Color.Gray;
            this.lblTFlowName.Location = new System.Drawing.Point(48, 40);
            this.lblTFlowName.Name = "lblTFlowName";
            this.lblTFlowName.Size = new System.Drawing.Size(108, 19);
            this.lblTFlowName.TabIndex = 6;
            this.lblTFlowName.Text = "FLOW_NAME :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblTotalRow);
            this.groupBox1.Controls.Add(this.dgvFlow);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 321);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " List Flow ";
            // 
            // lblTotalRow
            // 
            this.lblTotalRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRow.AutoSize = true;
            this.lblTotalRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTotalRow.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalRow.Location = new System.Drawing.Point(620, 300);
            this.lblTotalRow.Name = "lblTotalRow";
            this.lblTotalRow.Size = new System.Drawing.Size(115, 13);
            this.lblTotalRow.TabIndex = 104;
            this.lblTotalRow.Text = "Total rows : xxxxxxxxxx";
            // 
            // dgvFlow
            // 
            this.dgvFlow.AllowUserToAddRows = false;
            this.dgvFlow.AllowUserToDeleteRows = false;
            this.dgvFlow.AllowUserToResizeColumns = false;
            this.dgvFlow.AllowUserToResizeRows = false;
            this.dgvFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFlow.AutoGenerateContextFilters = true;
            this.dgvFlow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFlow.BackgroundColor = System.Drawing.Color.White;
            this.dgvFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlow.DateWithTime = false;
            this.dgvFlow.Location = new System.Drawing.Point(11, 28);
            this.dgvFlow.MultiSelect = false;
            this.dgvFlow.Name = "dgvFlow";
            this.dgvFlow.ReadOnly = true;
            this.dgvFlow.RowHeadersVisible = false;
            this.dgvFlow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlow.Size = new System.Drawing.Size(718, 269);
            this.dgvFlow.TabIndex = 15;
            this.dgvFlow.TimeFilter = false;
            this.dgvFlow.SortStringChanged += new System.EventHandler(this.dgvFlow_SortStringChanged);
            this.dgvFlow.FilterStringChanged += new System.EventHandler(this.dgvFlow_FilterStringChanged);
            this.dgvFlow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlow_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 484);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 38);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(590, 93);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 54);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // bindingSourceFlow
            // 
            this.bindingSourceFlow.CurrentChanged += new System.EventHandler(this.bindingSourceFlow_CurrentChanged);
            // 
            // pageUpdateFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFlowName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblTFlowName);
            this.Name = "pageUpdateFlow";
            this.Size = new System.Drawing.Size(764, 532);
            this.Load += new System.EventHandler(this.pageUpdateFlow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFlow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlowName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblTFlowName;
        private System.Windows.Forms.GroupBox groupBox1;
        private ADGV.AdvancedDataGridView dgvFlow;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource bindingSourceFlow;
        private System.Windows.Forms.Label lblTotalRow;
    }
}
