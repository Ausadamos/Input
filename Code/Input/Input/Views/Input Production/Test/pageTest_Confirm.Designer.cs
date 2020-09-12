namespace Input
{
    partial class pageTest_Confirm
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
            this.dgvOrderInput = new System.Windows.Forms.DataGridView();
            this.txtTotelOrder = new System.Windows.Forms.Label();
            this.bttInput = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bindingSourceInput = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInput)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderInput
            // 
            this.dgvOrderInput.AllowUserToAddRows = false;
            this.dgvOrderInput.AllowUserToDeleteRows = false;
            this.dgvOrderInput.AllowUserToResizeColumns = false;
            this.dgvOrderInput.AllowUserToResizeRows = false;
            this.dgvOrderInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrderInput.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderInput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderInput.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderInput.Location = new System.Drawing.Point(32, 68);
            this.dgvOrderInput.MultiSelect = false;
            this.dgvOrderInput.Name = "dgvOrderInput";
            this.dgvOrderInput.ReadOnly = true;
            this.dgvOrderInput.RowHeadersVisible = false;
            this.dgvOrderInput.Size = new System.Drawing.Size(698, 291);
            this.dgvOrderInput.TabIndex = 0;
            this.dgvOrderInput.TabStop = false;
            // 
            // txtTotelOrder
            // 
            this.txtTotelOrder.AutoSize = true;
            this.txtTotelOrder.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotelOrder.ForeColor = System.Drawing.Color.DimGray;
            this.txtTotelOrder.Location = new System.Drawing.Point(26, 21);
            this.txtTotelOrder.Name = "txtTotelOrder";
            this.txtTotelOrder.Size = new System.Drawing.Size(189, 33);
            this.txtTotelOrder.TabIndex = 1;
            this.txtTotelOrder.Text = "Total Input XXX";
            // 
            // bttInput
            // 
            this.bttInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttInput.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttInput.Location = new System.Drawing.Point(593, 406);
            this.bttInput.Name = "bttInput";
            this.bttInput.Size = new System.Drawing.Size(137, 45);
            this.bttInput.TabIndex = 3;
            this.bttInput.Text = "Input";
            this.bttInput.UseVisualStyleBackColor = true;
            this.bttInput.Click += new System.EventHandler(this.bttInput_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(22, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pageTest_Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bttInput);
            this.Controls.Add(this.txtTotelOrder);
            this.Controls.Add(this.dgvOrderInput);
            this.Name = "pageTest_Confirm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(753, 471);
            this.Load += new System.EventHandler(this.pageInput_Confirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderInput;
        private System.Windows.Forms.Label txtTotelOrder;
        private System.Windows.Forms.Button bttInput;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bindingSourceInput;
    }
}
