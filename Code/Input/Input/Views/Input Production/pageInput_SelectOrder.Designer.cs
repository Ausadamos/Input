namespace Input
{
    partial class pageInput_SelectOrder
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
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFFT_Order_ID = new System.Windows.Forms.TextBox();
            this.adgvOrder = new ADGV.AdvancedDataGridView();
            this.ckbDataThisYear = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblTotalRow = new System.Windows.Forms.Label();
            this.bttInput = new System.Windows.Forms.Button();
            this.bindingSourceOrder = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(293, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 39);
            this.label9.TabIndex = 9;
            this.label9.Text = "Select Order";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(28, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Order ID :";
            // 
            // txtFFT_Order_ID
            // 
            this.txtFFT_Order_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFFT_Order_ID.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFFT_Order_ID.Location = new System.Drawing.Point(160, 482);
            this.txtFFT_Order_ID.Name = "txtFFT_Order_ID";
            this.txtFFT_Order_ID.ReadOnly = true;
            this.txtFFT_Order_ID.Size = new System.Drawing.Size(398, 29);
            this.txtFFT_Order_ID.TabIndex = 1;
            this.txtFFT_Order_ID.Text = " ";
            this.txtFFT_Order_ID.TextChanged += new System.EventHandler(this.txtFFT_Order_ID_TextChanged);
            // 
            // adgvOrder
            // 
            this.adgvOrder.AllowUserToAddRows = false;
            this.adgvOrder.AllowUserToDeleteRows = false;
            this.adgvOrder.AllowUserToResizeColumns = false;
            this.adgvOrder.AllowUserToResizeRows = false;
            this.adgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adgvOrder.AutoGenerateContextFilters = true;
            this.adgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.adgvOrder.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.adgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvOrder.DateWithTime = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adgvOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.adgvOrder.Location = new System.Drawing.Point(12, 52);
            this.adgvOrder.MultiSelect = false;
            this.adgvOrder.Name = "adgvOrder";
            this.adgvOrder.ReadOnly = true;
            this.adgvOrder.RowHeadersVisible = false;
            this.adgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adgvOrder.Size = new System.Drawing.Size(739, 346);
            this.adgvOrder.TabIndex = 14;
            this.adgvOrder.TimeFilter = false;
            this.adgvOrder.SortStringChanged += new System.EventHandler(this.adgvOrder_SortStringChanged);
            this.adgvOrder.FilterStringChanged += new System.EventHandler(this.adgvOrder_FilterStringChanged);
            this.adgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adgvOrder_CellClick);
            // 
            // ckbDataThisYear
            // 
            this.ckbDataThisYear.AutoSize = true;
            this.ckbDataThisYear.ForeColor = System.Drawing.Color.Silver;
            this.ckbDataThisYear.Location = new System.Drawing.Point(12, 33);
            this.ckbDataThisYear.Name = "ckbDataThisYear";
            this.ckbDataThisYear.Size = new System.Drawing.Size(94, 17);
            this.ckbDataThisYear.TabIndex = 98;
            this.ckbDataThisYear.Text = "Order this year";
            this.ckbDataThisYear.UseVisualStyleBackColor = true;
            this.ckbDataThisYear.CheckedChanged += new System.EventHandler(this.ckbDataThisYear_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(71, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 33);
            this.label2.TabIndex = 99;
            this.label2.Text = "Type :";
            // 
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(160, 425);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(203, 29);
            this.txtType.TabIndex = 100;
            this.txtType.Text = " ";
            // 
            // lblTotalRow
            // 
            this.lblTotalRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRow.AutoSize = true;
            this.lblTotalRow.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalRow.Location = new System.Drawing.Point(640, 402);
            this.lblTotalRow.Name = "lblTotalRow";
            this.lblTotalRow.Size = new System.Drawing.Size(115, 13);
            this.lblTotalRow.TabIndex = 101;
            this.lblTotalRow.Text = "Total rows : xxxxxxxxxx";
            // 
            // bttInput
            // 
            this.bttInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttInput.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttInput.ForeColor = System.Drawing.Color.Black;
            this.bttInput.Image = global::Input.Properties.Resources.next24px;
            this.bttInput.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttInput.Location = new System.Drawing.Point(605, 462);
            this.bttInput.Name = "bttInput";
            this.bttInput.Size = new System.Drawing.Size(134, 50);
            this.bttInput.TabIndex = 2;
            this.bttInput.Text = "Next";
            this.bttInput.UseVisualStyleBackColor = true;
            this.bttInput.Click += new System.EventHandler(this.bttInput_Click);
            // 
            // bindingSourceOrder
            // 
            this.bindingSourceOrder.CurrentChanged += new System.EventHandler(this.bindingSourceOrder_CurrentChanged);
            // 
            // pageInput_SelectOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTotalRow);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckbDataThisYear);
            this.Controls.Add(this.adgvOrder);
            this.Controls.Add(this.txtFFT_Order_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttInput);
            this.Controls.Add(this.label9);
            this.Name = "pageInput_SelectOrder";
            this.Size = new System.Drawing.Size(763, 535);
            this.Load += new System.EventHandler(this.pageInput_SelectOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bttInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFFT_Order_ID;
        private System.Windows.Forms.BindingSource bindingSourceOrder;
        private ADGV.AdvancedDataGridView adgvOrder;
        private System.Windows.Forms.CheckBox ckbDataThisYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblTotalRow;
    }
}
