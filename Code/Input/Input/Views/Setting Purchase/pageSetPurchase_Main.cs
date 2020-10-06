using InputManagement.Controllers;
using InputManagement.Property;

using System;
using System.Windows.Forms;

namespace Input
{
    public partial class pageSetPurchase_Main : UserControl
    {
        PurchaseControllers _controllers = new PurchaseControllers();
        frmMain _frmMain;
        public PurchaseProperty purchaseData = new PurchaseProperty();
        public pageSetPurchase_Main(frmMain obj)
        {
            InitializeComponent();
            _frmMain = obj;
        }

        private void pageSetPurchase_Main_Load(object sender, EventArgs e)
        {
            this.LoadPurchaseAll();
        }

        private void LoadPurchaseAll()
        {
            this.bindingSourcePurcAll.DataSource = _controllers.LoadPurchaseAll();
            this.advgListPurchase.DataSource = this.bindingSourcePurcAll;

            // Check and visible columns["ID"].
            var _columnVis_ID = advgListPurchase.Columns["ID"];
            if (_columnVis_ID != null && _columnVis_ID.Visible)
            { advgListPurchase.Columns["ID"].Visible = false; }

        }

        private void bindingSourcePurcAll_CurrentChanged(object sender, EventArgs e)
        {
            this.lblTotalRow.Text = "Total rows : " + this.bindingSourcePurcAll.List.Count;
        }

        private void advgListPurchase_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSourcePurcAll.Sort = this.advgListPurchase.SortString;
        }

        private void advgListPurchase_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSourcePurcAll.Filter = this.advgListPurchase.FilterString;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmPurc_Create _frmPurc_Create = new frmPurc_Create(_frmMain);

            _frmPurc_Create.ShowDialog();

            this.LoadPurchaseAll();
        }

        private void Load_PageUpdatePurchase()
        {
            //default page//set HeadLine
            _frmMain.Set_HeadLine(_frmMain.lblHeader.Text + " > Update Purchase");

            //Clear Panel Body  
            _frmMain.panBody.Controls.Clear();

            //Load page Select order.
            pageUpdateProcessCard _pageUpdatePurchase = new pageUpdateProcessCard(_frmMain, purchaseData);
            _frmMain.panBody.Controls.Add(_pageUpdatePurchase);
            _pageUpdatePurchase.Dock = DockStyle.Fill;
            _pageUpdatePurchase.BringToFront();
        }

        private void btnUpdateProcessCard_Click(object sender, EventArgs e)
        {
            if (purchaseData.FFT_CODE == null || purchaseData.PURCHASE_NO == null || purchaseData.FLOW.FLOW_NAME == null || purchaseData.PART_NO == null || purchaseData.PRODUCT_PURCHASE == null || purchaseData.MODEL == null)
            {
                MessageBox.Show("Please select order for update order", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Load_PageUpdateProcessCard();
        }
        private void Load_PageUpdateProcessCard()
        {
            //default page//set HeadLine
            _frmMain.Set_HeadLine("Update Purchase");

            //Clear Panel Body  
            _frmMain.panBody.Controls.Clear();

            //Load page Select order.
            pageUpdateProcessCard _pageUpdatePurchase = new pageUpdateProcessCard(_frmMain, purchaseData);
            _frmMain.panBody.Controls.Add(_pageUpdatePurchase);
            _pageUpdatePurchase.Dock = DockStyle.Fill;
            _pageUpdatePurchase.BringToFront();
        }

        private void advgListPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (this.advgListPurchase.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        purchaseData = new PurchaseProperty
                        {
                            PURCHASE_NO = this.advgListPurchase.Rows[e.RowIndex].Cells["DOCUMENT_NO"].FormattedValue.ToString()
                            ,
                            FFT_CODE = this.advgListPurchase.Rows[e.RowIndex].Cells["FFT_CODE"].FormattedValue.ToString()
                            ,
                            FLOW = new FlowProperty { FLOW_NAME = this.advgListPurchase.Rows[e.RowIndex].Cells["FLOW_NAME"].FormattedValue.ToString() }
                            ,
                            PART_NO = this.advgListPurchase.Rows[e.RowIndex].Cells["PART_NO"].FormattedValue.ToString()
                            ,
                            PRODUCT_PURCHASE = this.advgListPurchase.Rows[e.RowIndex].Cells["PRODUCT_NAME"].FormattedValue.ToString()
                            ,
                            MODEL = this.advgListPurchase.Rows[e.RowIndex].Cells["MODEL_NO"].FormattedValue.ToString()
                            ,
                            PATH_PROCESS_CARD = this.advgListPurchase.Rows[e.RowIndex].Cells["PATH_PROCESS_CARD"].FormattedValue.ToString()

                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
