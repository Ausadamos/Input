namespace Input
{
    partial class pageUpdate_Order
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
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblGroup = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFFT_ORDER_ID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.adgvListInput = new ADGV.AdvancedDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalRow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSourceInputAll = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adgvListInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInputAll)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.White;
            this.txtQty.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(143, 104);
            this.txtQty.MaxLength = 255;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(83, 25);
            this.txtQty.TabIndex = 118;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(601, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 54);
            this.btnUpdate.TabIndex = 116;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.ForeColor = System.Drawing.Color.Gray;
            this.lblGroup.Location = new System.Drawing.Point(103, 60);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(66, 21);
            this.lblGroup.TabIndex = 115;
            this.lblGroup.Text = "- - - - - -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(34, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 114;
            this.label2.Text = "GROUP :";
            // 
            // lblFFT_ORDER_ID
            // 
            this.lblFFT_ORDER_ID.AutoSize = true;
            this.lblFFT_ORDER_ID.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFFT_ORDER_ID.ForeColor = System.Drawing.Color.Gray;
            this.lblFFT_ORDER_ID.Location = new System.Drawing.Point(154, 17);
            this.lblFFT_ORDER_ID.Name = "lblFFT_ORDER_ID";
            this.lblFFT_ORDER_ID.Size = new System.Drawing.Size(66, 21);
            this.lblFFT_ORDER_ID.TabIndex = 113;
            this.lblFFT_ORDER_ID.Text = "- - - - - -";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(34, 103);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(105, 23);
            this.lblStatus.TabIndex = 112;
            this.lblStatus.Text = "QUANTITY :";
            // 
            // adgvListInput
            // 
            this.adgvListInput.AllowUserToAddRows = false;
            this.adgvListInput.AllowUserToDeleteRows = false;
            this.adgvListInput.AllowUserToResizeColumns = false;
            this.adgvListInput.AllowUserToResizeRows = false;
            this.adgvListInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adgvListInput.AutoGenerateContextFilters = true;
            this.adgvListInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.adgvListInput.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adgvListInput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.adgvListInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvListInput.DateWithTime = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adgvListInput.DefaultCellStyle = dataGridViewCellStyle2;
            this.adgvListInput.Location = new System.Drawing.Point(9, 186);
            this.adgvListInput.MultiSelect = false;
            this.adgvListInput.Name = "adgvListInput";
            this.adgvListInput.ReadOnly = true;
            this.adgvListInput.RowHeadersVisible = false;
            this.adgvListInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adgvListInput.Size = new System.Drawing.Size(744, 311);
            this.adgvListInput.TabIndex = 110;
            this.adgvListInput.TimeFilter = false;
            this.adgvListInput.SortStringChanged += new System.EventHandler(this.adgvListInput_SortStringChanged);
            this.adgvListInput.FilterStringChanged += new System.EventHandler(this.adgvListInput_FilterStringChanged);
            this.adgvListInput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adgvListInput_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(10, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 109;
            this.label1.Text = "List Input";
            // 
            // lblTotalRow
            // 
            this.lblTotalRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRow.AutoSize = true;
            this.lblTotalRow.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalRow.Location = new System.Drawing.Point(637, 505);
            this.lblTotalRow.Name = "lblTotalRow";
            this.lblTotalRow.Size = new System.Drawing.Size(115, 13);
            this.lblTotalRow.TabIndex = 119;
            this.lblTotalRow.Text = "Total rows : xxxxxxxxxx";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(34, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 121;
            this.label4.Text = "FFT_ORDER_ID : ";
            // 
            // bindingSourceInputAll
            // 
            this.bindingSourceInputAll.CurrentChanged += new System.EventHandler(this.bindingSourceInputAll_CurrentChanged);
            // 
            // pageUpdate_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalRow);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFFT_ORDER_ID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.adgvListInput);
            this.Controls.Add(this.label1);
            this.Name = "pageUpdate_Order";
            this.Size = new System.Drawing.Size(764, 532);
            this.Load += new System.EventHandler(this.pageUpdate_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adgvListInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInputAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFFT_ORDER_ID;
        private System.Windows.Forms.Label lblStatus;
        private ADGV.AdvancedDataGridView adgvListInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalRow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSourceInputAll;
    }
}
