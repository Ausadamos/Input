﻿namespace Input
{
    partial class pageSetPurchase_Main
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
            this.advgListPurchase = new ADGV.AdvancedDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblTotalRow = new System.Windows.Forms.Label();
            this.bindingSourcePurcAll = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdateProcessCard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.advgListPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePurcAll)).BeginInit();
            this.SuspendLayout();
            // 
            // advgListPurchase
            // 
            this.advgListPurchase.AllowUserToAddRows = false;
            this.advgListPurchase.AllowUserToDeleteRows = false;
            this.advgListPurchase.AllowUserToResizeColumns = false;
            this.advgListPurchase.AllowUserToResizeRows = false;
            this.advgListPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advgListPurchase.AutoGenerateContextFilters = true;
            this.advgListPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.advgListPurchase.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advgListPurchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.advgListPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advgListPurchase.DateWithTime = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advgListPurchase.DefaultCellStyle = dataGridViewCellStyle2;
            this.advgListPurchase.Location = new System.Drawing.Point(16, 104);
            this.advgListPurchase.MultiSelect = false;
            this.advgListPurchase.Name = "advgListPurchase";
            this.advgListPurchase.ReadOnly = true;
            this.advgListPurchase.RowHeadersVisible = false;
            this.advgListPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advgListPurchase.Size = new System.Drawing.Size(732, 402);
            this.advgListPurchase.TabIndex = 29;
            this.advgListPurchase.TimeFilter = false;
            this.advgListPurchase.SortStringChanged += new System.EventHandler(this.advgListPurchase_SortStringChanged);
            this.advgListPurchase.FilterStringChanged += new System.EventHandler(this.advgListPurchase_FilterStringChanged);
            this.advgListPurchase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advgListPurchase_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(11, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "List Purchase All";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(121, 13);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(244, 59);
            this.btnCreate.TabIndex = 27;
            this.btnCreate.Text = "Create Purchase";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblTotalRow
            // 
            this.lblTotalRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRow.AutoSize = true;
            this.lblTotalRow.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalRow.Location = new System.Drawing.Point(645, 509);
            this.lblTotalRow.Name = "lblTotalRow";
            this.lblTotalRow.Size = new System.Drawing.Size(115, 13);
            this.lblTotalRow.TabIndex = 120;
            this.lblTotalRow.Text = "Total rows : xxxxxxxxxx";
            // 
            // bindingSourcePurcAll
            // 
            this.bindingSourcePurcAll.CurrentChanged += new System.EventHandler(this.bindingSourcePurcAll_CurrentChanged);
            // 
            // btnUpdateProcessCard
            // 
            this.btnUpdateProcessCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateProcessCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProcessCard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProcessCard.Location = new System.Drawing.Point(371, 13);
            this.btnUpdateProcessCard.Name = "btnUpdateProcessCard";
            this.btnUpdateProcessCard.Size = new System.Drawing.Size(244, 59);
            this.btnUpdateProcessCard.TabIndex = 121;
            this.btnUpdateProcessCard.Text = "Update Purchase";
            this.btnUpdateProcessCard.UseVisualStyleBackColor = true;
            this.btnUpdateProcessCard.Click += new System.EventHandler(this.btnUpdateProcessCard_Click);
            // 
            // pageSetPurchase_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnUpdateProcessCard);
            this.Controls.Add(this.lblTotalRow);
            this.Controls.Add(this.advgListPurchase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Name = "pageSetPurchase_Main";
            this.Size = new System.Drawing.Size(764, 532);
            this.Load += new System.EventHandler(this.pageSetPurchase_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advgListPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePurcAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ADGV.AdvancedDataGridView advgListPurchase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.BindingSource bindingSourcePurcAll;
        private System.Windows.Forms.Label lblTotalRow;
        private System.Windows.Forms.Button btnUpdateProcessCard;
    }
}
