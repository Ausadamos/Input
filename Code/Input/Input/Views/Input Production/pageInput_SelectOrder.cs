using InputManagement.Property;
using Input.Controllers;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Input
{
    public partial class pageInput_SelectOrder : UserControl
    {
        InputOrderControllers _controllers = new InputOrderControllers();
        frmMain _frmMain;
        public pageInput_SelectOrder(frmMain obj)
        {
            InitializeComponent();
            _frmMain = obj;
        }
        private void pageInput_SelectOrder_Load(object sender, EventArgs e)
        {
            this.PageLoad();

            //Declaration class OrderProperty & Conditionproperty 
            _frmMain._order = new OrderProperty();
            _frmMain._order.CONDITION = new ConditionProperty();
        }
        private void PageLoad()
        {
            this.bttInput.Visible = false;

            //Have action when listbox check.
            this.ckbDataThisYear.Checked = true;
        }
        private void txtFFT_Order_ID_TextChanged(object sender, EventArgs e)
        {
            //Check OrderID IN textbox 
            if (txtFFT_Order_ID.Text.Length >= 1)
            {
                this.bttInput.Visible = true;
            }
            else if (txtFFT_Order_ID.Text.Length < 1)
            {
                this.bttInput.Visible = false;
            }

        }
        private void bttInput_Click(object sender, EventArgs e)
        {
            if (_frmMain._order.ORDER_TYPE_NAME == "RMA")
            {
                this.Load_PageRMA();
            }
            else if (_frmMain._order.ORDER_TYPE_NAME == "Rework")
            {
                this.Load_PageRework();
            }
            else if (_frmMain._order.ORDER_TYPE_NAME == "Test")
            {
                this.Load_PageInputTest();
            }
            else
            {
                this.Load_PageInput();
            }
        }

        public void Load_PageInput( )
        {
            _frmMain.Set_HeadLine("Input > " + _frmMain._order.FFT_ORDER_ID);
            
            _frmMain.panBody.Controls.Clear();

            pageInput_Main _pageInput_Main = new pageInput_Main(_frmMain);
            _frmMain.panBody.Controls.Add(_pageInput_Main);
            _pageInput_Main.Dock = DockStyle.Fill;
            _pageInput_Main.BringToFront();
        }
        public void Load_PageRework()
        {
            _frmMain.Set_HeadLine("Rework > " + _frmMain._order.FFT_ORDER_ID);

            _frmMain.panBody.Controls.Clear();

            pageRework_Main _pageRework = new pageRework_Main(_frmMain);
            _frmMain.panBody.Controls.Add(_pageRework);
            _pageRework.Dock = DockStyle.Fill;
            _pageRework.BringToFront();
        }
        public void Load_PageInputTest()
        {
            _frmMain.Set_HeadLine("Test > " + _frmMain._order.FFT_ORDER_ID);

            _frmMain.panBody.Controls.Clear();

            pageTest _pageTest = new pageTest(_frmMain);
            _frmMain.panBody.Controls.Add(_pageTest);
            _pageTest.Dock = DockStyle.Fill;
            _pageTest.BringToFront();
        }
        public void Load_PageRMA()
        {
            _frmMain.Set_HeadLine("RMA > " + _frmMain._order.FFT_ORDER_ID);

            _frmMain.panBody.Controls.Clear();

            pageRMA _pageInput_Main = new pageRMA(_frmMain);
            _frmMain.panBody.Controls.Add(_pageInput_Main);
            _pageInput_Main.Dock = DockStyle.Fill;
            _pageInput_Main.BringToFront();
        }

        

        private void ckbDataThisYear_CheckedChanged(object sender, EventArgs e)
        {
            bool _checked = this.ckbDataThisYear.Checked;
            if (_checked == true)
            {
                this.SearchOrderInThisYear();
            }
            else
            {
                this.SearchOrderAll();
            }
        }
        private void SearchOrderInThisYear()
        {
            //get order to bindingSource.
            this.bindingSourceOrder.DataSource = _controllers.SearchOrderInThisYear();
            this.adgvOrder.DataSource = this.bindingSourceOrder;
        }
        private void SearchOrderAll()
        {
            //get order to bindingSource.
            this.bindingSourceOrder.DataSource = _controllers.SearchOrderAll();
            this.adgvOrder.DataSource = this.bindingSourceOrder;
        }
        private void bindingSourceOrder_CurrentChanged(object sender, EventArgs e)
        {
            this.lblTotalRow.Text = "Total rows : " + this.bindingSourceOrder.List.Count;
        }

        private void adgvOrder_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSourceOrder.Filter = this.adgvOrder.FilterString;
        }

        private void adgvOrder_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSourceOrder.Sort = this.adgvOrder.SortString;
        }

        private void adgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (this.adgvOrder.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        //-------------------  Get Order ------------------------------
                        _frmMain._order = new OrderProperty
                        {
                            FFT_ORDER_ID = this.adgvOrder.Rows[e.RowIndex].Cells["FFT_ORDER_ID"].FormattedValue.ToString()
                            ,ORDER_QUANTITY = this.adgvOrder.Rows[e.RowIndex].Cells["ORDER_QUANTITY"].FormattedValue.ToString()
                            ,ORDER_TYPE_NAME = this.adgvOrder.Rows[e.RowIndex].Cells["ORDER_TYPE_NAME"].FormattedValue.ToString()
                            ,ORDER_DATE = this.adgvOrder.Rows[e.RowIndex].Cells["ORDER_DATE"].FormattedValue.ToString()
                        };
      

                        //-------------------  Get Condition ------------------------------
                        //Call ConditionProperty in OrderProperty
                        _frmMain._order.CONDITION = new ConditionProperty
                        {
                            CUSTOMER_NAME = this.adgvOrder.Rows[e.RowIndex].Cells["CUSTOMER_NAME"].FormattedValue.ToString()
                            ,PRODUCT_NAME = this.adgvOrder.Rows[e.RowIndex].Cells["PRODUCT_NAME"].FormattedValue.ToString()
                            ,PART_NO = this.adgvOrder.Rows[e.RowIndex].Cells["PART_NO"].FormattedValue.ToString()
                            ,WORK_ORDER = this.adgvOrder.Rows[e.RowIndex].Cells["WORK_ORDER"].FormattedValue.ToString()
                        };

                        this.txtFFT_Order_ID.Text = _frmMain._order.FFT_ORDER_ID;
                        this.txtType.Text = _frmMain._order.ORDER_TYPE_NAME;
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
