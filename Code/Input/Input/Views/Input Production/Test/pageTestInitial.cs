using InputManagement.Property;
using InputManagement.Controllers;

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
    public partial class pageTestInitial : UserControl
    {
        public OrderProperty _orderInput;
        public List<OrderProperty> _listOrderInput = new List<OrderProperty>();

        InputOrderControllers _controllers = new InputOrderControllers();
        PurchaseControllers _controllersPurchase = new PurchaseControllers();

        List<PurchaseProperty> _listPurchase;
        frmMain _frmMain;
        pageTest _pageTest;
        DateTime _dataTimeNow;

        public pageTestInitial(frmMain obj, pageTest obj2)
        {
            InitializeComponent();
            _frmMain = obj;
            _pageTest = obj2;
        }

        private void LoadPuchaseOrder()
        {
            _listPurchase = _controllersPurchase.SearchPurchasesOrder(_frmMain._order);
            foreach (PurchaseProperty _purchase in _listPurchase)
            { this.cmbSelect_PurchaseNo.Items.Add(_purchase.PURCHASE_NO); }
            this.cmbSelect_PurchaseNo.SelectedIndex = 0;
        }

        private string getDateDifference(DateTime date1, DateTime date2)
        {
            TimeSpan ts = date1.Date - date2.Date;
            int differenceInDays = ts.Days + 1;
            string differenceAsString = differenceInDays.ToString();
            return differenceAsString;
        }

        private void LoadInput_History()
        {
            frmInput_History _frminput_history = new frmInput_History(_frmMain);
            _frminput_history.ShowDialog();
        }

        private void pageTestInitial_Load(object sender, EventArgs e)
        {
            this.txtFFT_ORDER_ID.Text = _frmMain._order.FFT_ORDER_ID;
            this.txtQtyOrder.Text = _frmMain._order.ORDER_QUANTITY;
            this.txtCustomer.Text = _frmMain._order.CONDITION.CUSTOMER_NAME;
            this.txtWorkOrder.Text = _frmMain._order.CONDITION.WORK_ORDER;
            this.txtPartNo.Text = _frmMain._order.CONDITION.PART_NO;
            this.cmbSelect_PurchaseNo.SelectedIndex = 0;

            _frmMain._order.ORDER_QUANTITY_HISTORY = _controllers.GetQtyHistory(_frmMain._order);
            this.txtHistory.Text = _frmMain._order.ORDER_QUANTITY_HISTORY;
            this.txtTotalQty.Text = this.txtHistory.Text;

            //Check textbox history 
            this.btnViewHistory.Visible = this.txtHistory.Text == "0" ? false : true;

            //Get time now In DB.
            _dataTimeNow = _controllers.GetDatetimeNow();

            this.dtpInputDate.MinDate = _dataTimeNow;

            this.dtpInputDate_Start.MinDate = _dataTimeNow;
            this.dtpInputDate_To.MinDate = _dataTimeNow.AddDays(1);

            this.SetClearSelectMoreOneDay();
            this.SetClearSelectOneDay();
            this.LoadPuchaseOrder();
        }

        private void SetStartSelectMoreOneDay()
        {
            this.rdoMore1Day.ForeColor = System.Drawing.Color.Black;

            //this.label13.Text = Input Date
            this.label13.Enabled = true;

            //this.label13.Text = To
            this.label14.Enabled = true;

            //this.label13.Text = Actual Q'ty / Day
            this.label16.Enabled = true;

            this.dtpInputDate_Start.Enabled = true;
            this.dtpInputDate_To.Enabled = true;
            this.txtQtyPerDay.Enabled = true;

            this.dtpInputDate_Start.Value = _dataTimeNow;

            //Set DateTimePicker + 1 Day.
            this.dtpInputDate_To.MinDate = _dataTimeNow;
            this.dtpInputDate_To.Value = _dataTimeNow;

            this.dtpInputDate_To.MinDate = _dataTimeNow.AddDays(1);
            this.dtpInputDate_To.Value = _dataTimeNow.AddDays(1);
        }
        private void SetClearSelectMoreOneDay()
        {
            this.rdoMore1Day.ForeColor = System.Drawing.Color.Gray;

            //this.label13.Text = Input Date
            this.label13.Enabled = false;

            //this.label13.Text = To
            this.label14.Enabled = false;

            //this.label13.Text = Actual Q'ty / Day
            this.label16.Enabled = false;


            this.dtpInputDate_Start.Value = _dataTimeNow;
            this.dtpInputDate_Start.Enabled = false;

            //Set DateTimePicker + 1 Day.
            this.dtpInputDate_To.MinDate = _dataTimeNow.AddDays(1);
            this.dtpInputDate_To.Value = _dataTimeNow.AddDays(1);
            this.dtpInputDate_To.Enabled = false;

            this.txtDateDiff.Text = "";

            this.txtQtyPerDay.Text = "";
            this.txtQtyPerDay.Enabled = false;

            this.txtHistory.Text = _frmMain._order.ORDER_QUANTITY_HISTORY;
            this.txtTotalQty.Text = this.txtHistory.Text;
        }
        private void SetStartSelectOneDay()
        {
            this.rdo1Day.ForeColor = System.Drawing.Color.Black;

            //this.label6.Text = Input Date
            this.label6.Enabled = true;

            //this.label11.Text = Actual Q'ty
            this.label11.Enabled = true;

            this.dtpInputDate.Enabled = true;
            this.dtpInputDate.Value = _dataTimeNow;

            this.txtQtyActual.Text = "0";
            this.txtQtyActual.Enabled = true;

        }
        private void SetClearSelectOneDay()
        {
            this.rdo1Day.ForeColor = System.Drawing.Color.Gray;

            //this.label6.Text = Input Date
            this.label6.Enabled = false;

            //this.label11.Text = Actual Q'ty
            this.label11.Enabled = false;

            this.dtpInputDate.Enabled = false;
            this.dtpInputDate.Value = _dataTimeNow;

            this.txtQtyActual.Text = "";
            this.txtQtyActual.Enabled = false;
        }

        private void bttNext_Click(object sender, EventArgs e)
        {
            _listOrderInput = new List<OrderProperty>();

            if (this.rdo1Day.Checked)
            {
                this.txtQtyActual.Text = this.txtQtyActual.Text == "" ? "0" : this.txtQtyActual.Text;
                int actualQtyInput = Convert.ToInt32(this.txtQtyActual.Text = this.txtQtyActual.Text);
                if (actualQtyInput < 1)
                {
                    MessageBox.Show("Please input Actual_Quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                //Check Over ORDER_QUANTITY.
                int orderQty = Convert.ToInt32(this.txtQtyOrder.Text);
                int orderTotal = Convert.ToInt32(this.txtTotalQty.Text);
                if (orderTotal > orderQty)
                {
                    DialogResult result = MessageBox.Show("Total input more than Order quantity." + "\n" + "You want to input Over YES | NO ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) { return; }
                }

                DateTime orderDate = this.dtpInputDate.Value.Date;
                _orderInput = new OrderProperty
                {
                    EMP = _frmMain._empLogin,
                    CONDITION = _frmMain._order.CONDITION ,
                    FFT_ORDER_ID = _frmMain._order.FFT_ORDER_ID.ToString(),
                    ORDER_TYPE_NAME = _frmMain._order.ORDER_TYPE_NAME,
                    ORDER_DATE = String.Format("{0:yyyy-MM-dd}", orderDate),
                    ORDER_QUANTITY = txtQtyActual.Text.ToString(),
                    PURCHASR = new PurchaseProperty { PURCHASE_NO = this.cmbSelect_PurchaseNo.Text.Trim() }

                };

                _listOrderInput.Add(_orderInput);
            }

            else if (this.rdoMore1Day.Checked)
            {
                this.txtQtyPerDay.Text = this.txtQtyPerDay.Text == "" ? "0" : this.txtQtyPerDay.Text;
                int actualQtyInput = Convert.ToInt32(this.txtQtyPerDay.Text);
                if (actualQtyInput < 1)
                {
                    MessageBox.Show("Please input Actual_Quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Check Over ORDER_QUANTITY.
                int orderQty = Convert.ToInt32(this.txtQtyOrder.Text);
                int orderTotal = Convert.ToInt32(this.txtTotalQty.Text);
                if (orderTotal > orderQty)
                {
                    DialogResult result = MessageBox.Show("Total input more than Order quantity." + "\n" + "You want to input Over YES | NO ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    { return; }
                }

                DateTime dateStart = this.dtpInputDate_Start.Value.Date;
                DateTime dateTo = this.dtpInputDate_To.Value.Date;

                do
                {
                    OrderProperty _order = new OrderProperty
                    {
                        EMP = _frmMain._empLogin,
                        CONDITION = _frmMain._order.CONDITION,
                        FFT_ORDER_ID = _frmMain._order.FFT_ORDER_ID.ToString(),
                        ORDER_TYPE_NAME = _frmMain._order.ORDER_TYPE_NAME,
                        ORDER_DATE = String.Format("{0:yyyy-MM-dd}", dateStart),
                        ORDER_QUANTITY = txtQtyPerDay.Text.ToString(),
                        PURCHASR = new PurchaseProperty { PURCHASE_NO = this.cmbSelect_PurchaseNo.Text.Trim() }
                    };
                    _listOrderInput.Add(_order);
                    dateStart = dateStart.AddDays(1);

                } while (dateStart <= dateTo);
            }
            else
            {
                MessageBox.Show("Please Select Input Date type `1 day` | `More than 1 day` ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Check Purchasr
            if (this.txtProductPurchase.Text == "")
            {
                MessageBox.Show("Not found Purchase No.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            this.Load_PageTestConfirm();
        }
        public void Load_PageTestConfirm()
        {
            //Clear Panel Body
            _frmMain.panBody.Controls.Clear();

            //Load page Select order.
            pageTest_Confirm _pageTest_Confirm = new pageTest_Confirm(this, _pageTest,_frmMain);
            _pageTest.panBodyTest.Controls.Add(_pageTest_Confirm);
            _pageTest_Confirm.Dock = DockStyle.Fill;
            _pageTest_Confirm.BringToFront();
        }

        private void rdoMore1Day_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMore1Day.Checked)
            {
                rdo1Day.Checked = false;
                this.SetClearSelectOneDay();

                this.SetStartSelectMoreOneDay();
            }
        }

        private void rdo1Day_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo1Day.Checked)
            {
                rdoMore1Day.Checked = false;
                this.SetClearSelectMoreOneDay();

                this.SetStartSelectOneDay();
            }
        }

        private void dtpInputDate_Start_ValueChanged(object sender, EventArgs e)
        {
            this.dtpInputDate_To.MinDate = this.dtpInputDate_Start.Value.AddDays(1);
            this.dtpInputDate_To.Value = this.dtpInputDate_Start.Value.AddDays(1);

            this.txtDateDiff.Text = this.getDateDifference(this.dtpInputDate_To.Value, this.dtpInputDate_Start.Value);
        }

        private void dtpInputDate_To_ValueChanged(object sender, EventArgs e)
        {
            this.txtDateDiff.Text = this.getDateDifference(this.dtpInputDate_To.Value, this.dtpInputDate_Start.Value);
        }

        private void txtDateDiff_TextChanged(object sender, EventArgs e)
        {
            int dateDiff;
            bool IsNumeric = int.TryParse(this.txtDateDiff.Text, out dateDiff);
            if (IsNumeric)
            {
                int orderQty = Convert.ToInt32(this.txtQtyOrder.Text);
                int orderHistory = Convert.ToInt32(this.txtHistory.Text);
                int result = orderQty - orderHistory;
                this.txtQtyPerDay.Text = dateDiff > 0 ? (result / dateDiff).ToString() : "0";
            }
        }

        private void txtQtyPerDay_TextChanged(object sender, EventArgs e)
        {
            if (this.txtQtyPerDay.Text != "")
            {
                int qtyPerDay;
                bool IsNumeric = int.TryParse(this.txtQtyPerDay.Text, out qtyPerDay);
                if (IsNumeric)
                {

                    int dateDiff = Convert.ToInt32(this.txtDateDiff.Text);
                    int totalInput = Convert.ToInt32(this.txtTotalQty.Text);
                    int inputHistory = Convert.ToInt32(_frmMain._order.ORDER_QUANTITY_HISTORY);
                    this.txtTotalQty.Text = dateDiff > 0 ? ((qtyPerDay * dateDiff) + inputHistory).ToString() : "0";
                }
                else
                {
                    MessageBox.Show("Please input numeric Only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtQtyPerDay.Text = "";
                }
            }
            else
            {
                this.txtHistory.Text = _frmMain._order.ORDER_QUANTITY_HISTORY;
                this.txtTotalQty.Text = this.txtHistory.Text;
            }
        }

        private void txtQtyActual_TextChanged(object sender, EventArgs e)
        {
            string _text = this.txtQtyActual.Text;
            if (_text != "")
            {
                int qty;
                bool isNumeric = int.TryParse(_text, out qty);
                if (isNumeric == false)
                {
                    MessageBox.Show("Please input numeric Only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtQtyActual.Text = "";
                }
                else
                {
                    int QtyHistory = Convert.ToInt32(this.txtHistory.Text);
                    int QtyActual = Convert.ToInt32(this.txtQtyActual.Text);
                    int QtyTotal = QtyHistory + QtyActual;
                    txtTotalQty.Text = Convert.ToString(QtyTotal);
                }
            }
            else
            {
                this.txtTotalQty.Text = this.txtHistory.Text;
            }
        }

        private void cmbSelect_PurchaseNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //******Check Work Order. *******************************

            string _PurchaseNo = this.cmbSelect_PurchaseNo.Text;
            int _indexPurchaseNo = this.cmbSelect_PurchaseNo.FindString(_PurchaseNo);
            if (_indexPurchaseNo >= 1)
            {
                foreach (PurchaseProperty _purchaseNo in _listPurchase)
                {
                    if (_PurchaseNo == _purchaseNo.PURCHASE_NO)
                    {
                        this.txtProductPurchase.Text = _purchaseNo.PRODUCT_PURCHASE.ToString();
                        this.txtFFTCode.Text = _purchaseNo.FFT_CODE.ToString();
                    }
                }
            }
            else
            {
                this.cmbSelect_PurchaseNo.SelectedIndex = 0;
                this.txtProductPurchase.Text = "";
                this.txtFFTCode.Text = "";
            }
        }

        private void cmbSelect_PurchaseNo_TextChanged(object sender, EventArgs e)
        {
            this.txtProductPurchase.Text = "";
            this.txtFFTCode.Text = "";
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            this.LoadInput_History();
        }
    }
}
