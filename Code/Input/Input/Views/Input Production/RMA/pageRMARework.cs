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
    public partial class pageRMARework : UserControl
    {
        InputOrderControllers _controllers = new InputOrderControllers();
        PurchaseControllers _controllerPurchase = new PurchaseControllers();
        FlowControllers _controllerFlow = new FlowControllers();
        ShipmentControllers _controllersShipment = new ShipmentControllers();

        public List<PurchaseProperty> _listPurchase;
        public FlowProcessProperty _flowProcess = new FlowProcessProperty();
        public ShipmentProperty _serialCheck;
        public List<InputProperty> _listInputRMARework = new List<InputProperty>();

        InputProperty _input;
        DataTable tableRMA;
        PurchaseProperty _purchase;
        frmMain _frmMain;
        public int HistoryCount;


        public pageRMARework(frmMain obj)
        {
            InitializeComponent();
            _frmMain = obj;
        }

        private void pageRMARework_Load(object sender, EventArgs e)
        {
            //_listInputRMARework = new List<InputProperty>();
            this.lblFFTOrderID.Text = _frmMain._order.FFT_ORDER_ID.ToString();
            this.txtQtyOrder.Text = _frmMain._order.ORDER_QUANTITY.ToString();

            _frmMain._order.ORDER_QUANTITY_HISTORY = _controllers.GetQtyHistory(_frmMain._order);
            this.txtHistory.Text = _frmMain._order.ORDER_QUANTITY_HISTORY;
            this.HistoryCount = Convert.ToInt32(_frmMain._order.ORDER_QUANTITY_HISTORY);
            if (_frmMain._order.ORDER_QUANTITY_HISTORY == "0")
            {
                this.lblGroup.Text = "1";
                btnViewHistory.Visible = false;
            }
            else
            {
                this.lblGroup.Text = Convert.ToString(Convert.ToInt32(_frmMain._order.ORDER_QUANTITY_HISTORY.Count()) + 1);
                btnViewHistory.Visible = true;
            }
            this.tableRMA = GetTable();
            this.txtTotalQty.Text = "0";
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            this.LoadInput_History();
        }
        private void LoadInput_History()
        {
            frmInput_History _frminput_history = new frmInput_History(_frmMain);
            _frminput_history.ShowDialog();
        }

        private void rdoLastPurchase_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txtSerial.Text.Trim() != "")
            {
                this.Get_purchaseBySerial();
            }
        }

        private void rdoUsedPurchase_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txtSerial.Text.Trim() != "")
            {
                this.Get_purchaseBySerial();
            }
        }

        private void rdoAllPurchase_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txtSerial.Text.Trim() != "")
            {
                this.Get_purchaseBySerial();
            }
        }
        private void txtSerial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {

                if (this.txtSerial.Text.Trim() != "")
                {

                    SetPage();

                    //Check Serial in Shippmet
                    _input = new InputProperty();
                    _input.Order = new OrderProperty();
                    _input.Order.PURCHASR = new PurchaseProperty();
                    _input.Order.PURCHASR.FLOW = new FlowProperty();
                    _input.Process = new ProcessProperty();

                    _input.SERIAL_NO = txtSerial.Text.ToString();

                    if (this.CheckSerialNOExistInShipment())
                    {
                        foreach (InputProperty _checkInput in _listInputRMARework)
                        {
                            if (_checkInput.SERIAL_NO == _input.SERIAL_NO)
                            {
                                MessageBox.Show("Have Serial_NO : " + _checkInput.SERIAL_NO + " Duplicate", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                this.txtSerial.Clear();
                                return;
                            }
                        }

                    }
                    else { return; }

                    this.Get_purchaseBySerial();
                }
                else
                { MessageBox.Show("Please input Serial_NO", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop); }

            }
        }
        private void cmbSelect_PurchaseNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProcess.Items.Clear();
            cmbProcess.Text = "";
            cmbProcess.Items.Add("- Select Process -");
            cmbProcess.SelectedItem = 0;

            if (cmbSelect_PurchaseNo.SelectedIndex != 0)
            {
                cmbProcess.SelectedIndex = 0;

                _purchase = new PurchaseProperty();
                {
                    _purchase.PURCHASE_NO = this.cmbSelect_PurchaseNo.Text.ToString();
                }
                _flowProcess = _controllerFlow.SearchFlowNameByPurchase(_purchase);
                txtFlowName.Text = _flowProcess.FLOW.FLOW_NAME;
                foreach (ProcessProperty _process in _flowProcess.PROCESS)
                {
                    cmbProcess.Items.Add(_process.PROCESS_NAME);
                }

            }
            else
            {
                this.txtFlowName.Clear();
            }
        }
        private void cmbProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProcess.SelectedIndex != 0)
            {
                btnAdd.Enabled = true;

                _input.SERIAL_NO = txtSerial.Text.ToString();
                _input.Order.FFT_ORDER_ID = _frmMain._order.FFT_ORDER_ID.ToString();
                _input.Order.GROUP = this.lblGroup.Text.ToString().Trim();
                _input.Order.PURCHASR.FLOW.FLOW_NAME = this.txtFlowName.Text.ToString();
                //_input.Process.ID = _flowProcess.PROCESS
                _input.Process.PROCESS_NAME = cmbProcess.Text.ToString();
                _input.INPUT_DATE = DateTime.Now.ToString("yyyy-MM-dd");

            }
            else
            {
                btnAdd.Enabled = false;
            }
        }


        private void Get_purchaseBySerial()
        {
            // Get Purchase & Flow & Process
            _listPurchase = new List<PurchaseProperty>();
            _serialCheck = new ShipmentProperty();
            _serialCheck.SERIAL_NO = txtSerial.Text.ToString().Trim();

            if (rdoLastPurchase.Checked)
            {
                _listPurchase = _controllerPurchase.LastPurchase(_serialCheck);
            }
            else if (rdoUsedPurchase.Checked)
            {
                _listPurchase = _controllerPurchase.UsedPurchase(_serialCheck);
            }
            else if (rdoAllPurchase.Checked)
            {
                _listPurchase = _controllerPurchase.ListPurchasesAll();
            }
            else { MessageBox.Show("Please Select Button Purchase", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }

            this.Set_Purchase();

        }
        private void Set_Purchase()
        {
            this.cmbSelect_PurchaseNo.Items.Clear();
            this.cmbSelect_PurchaseNo.Items.Add("- Select Purchase -");

            foreach (PurchaseProperty _Purchase in _listPurchase)
            {
                if (_Purchase.PURCHASE_NO != "")
                {
                    this.cmbSelect_PurchaseNo.Items.Add(_Purchase.PURCHASE_NO);
                }
                else
                {
                    MessageBox.Show("Not found Purchase" + "\n" + "Please Check Serial : " + this.txtSerial.Text, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.txtSerial.Clear();
                    this.SetPage();
                    return;
                }

            }
            if (rdoLastPurchase.Checked)
            {
                cmbSelect_PurchaseNo.SelectedIndex = 1;

            }
            else if (rdoUsedPurchase.Checked || rdoAllPurchase.Checked)
            {
                cmbSelect_PurchaseNo.SelectedIndex = 0;
                cmbProcess.Items.Clear();
                cmbProcess.Text = "";
                cmbProcess.Items.Add("- Select Process -");
                cmbProcess.SelectedItem = 0;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // ADD DATA
            _listInputRMARework.Add(_input);

            tableRMA.Rows.Add(
                    _input.Order.FFT_ORDER_ID,
                    _input.SERIAL_NO,
                    _input.Order.GROUP,
                    _input.Order.PURCHASR.FLOW.FLOW_NAME,
                    //_input.Process.ID,
                    _input.Process.PROCESS_NAME,
                    _input.INPUT_DATE
                    );
            this.dgvInputRMA.DataSource = this.tableRMA;

            this.txtTotalQty.Text = Convert.ToString(_listInputRMARework.Count());
            this.txtHistory.Text = Convert.ToString(HistoryCount + _listInputRMARework.Count());

            this.btnAdd.Enabled = false;
            this.txtSerial.Clear();
            this.SetPage();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_listInputRMARework.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want back page", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    this.Clear_page();
                }
            }
            Clear_page();
        }
        private bool CheckSerialNOExistInShipment()
        {
            // Check Serial in Shipment //

            bool statusSerail = false;
            _serialCheck = new ShipmentProperty();
            _serialCheck.SERIAL_NO = txtSerial.Text.ToString().Trim();
            ShipmentProperty _shippingReturn = new ShipmentProperty();
            ShipmentProperty _shipping = _controllersShipment.SearchSerailShipping(_serialCheck);

            if (_shipping.SERIAL_NO != "" && _shipping.SERIAL_NO != null)
            {
                _shippingReturn = _controllersShipment.SearchSerailShippingReturn(_serialCheck);
            }
            else
            {
                MessageBox.Show("Serial_NO : " + _serialCheck.SERIAL_NO + " Not Already Shipping  From " + "\n" + "Program Shipping", "Stop"
                                , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtSerial.Clear();
                return statusSerail;
            }
            if (_shippingReturn.SERIAL_NO != "" && _shippingReturn.SERIAL_NO != null)
            {
                DateTime dateShipping = Convert.ToDateTime(string.Format("{0:yyyy/MM/dd}", _shipping.SHIPMENT_DATE));
                DateTime dateShippingReturn = Convert.ToDateTime(string.Format("{0:yyyy/MM/dd}", _shippingReturn.SHIPMENT_DATE));
                if (dateShippingReturn > dateShipping)
                {
                    statusSerail = true;
                }
                else
                {
                    MessageBox.Show("Serial_NO : " + _shipping.SERIAL_NO + "had already been sent for customer and not return." + "/n" +
                         "If " + _shipping.SERIAL_NO + " have receive, Please  Scan Serial at the  Program: shipping in Function : Return Product" + "/n" +
                         "at the QA and the Service Center.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.txtSerial.Clear();
                    return statusSerail;
                }
                return statusSerail;
            }
            else
            {
                MessageBox.Show("Serial_NO : " + _shipping.SERIAL_NO + "had already been sent for customer and not return." + "/n" +
                         "If " + _shipping.SERIAL_NO + " have receive, Please  Scan Serial at the  Program: shipping in Function : Return Product" + "/n" +
                         "at the QA and the Service Center.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtSerial.Clear();
                return statusSerail;
            }

        }
        

        
        public void SetPage()
        {

            this.cmbSelect_PurchaseNo.Items.Clear();
            this.cmbSelect_PurchaseNo.Text = "";
            this.cmbSelect_PurchaseNo.Items.Add("- Select Purchase -");
            this.cmbSelect_PurchaseNo.SelectedItem = 0;
            this.cmbSelect_PurchaseNo.Enabled = true;

            this.txtFlowName.Clear();

            this.cmbProcess.Items.Clear();
            this.cmbProcess.Text = "";
            this.cmbProcess.Items.Add("- Select Process -");
            this.cmbProcess.SelectedItem = 0;
        }
        public void Clear_page()
        {
            _frmMain.Set_HeadLine(_frmMain.btnInput.Text);
            _frmMain.panBody.Controls.Clear();

            pageInput_SelectOrder _pageInput = new pageInput_SelectOrder(_frmMain);
            _frmMain.panBody.Controls.Add(_pageInput);
            _pageInput.Dock = DockStyle.Fill;
            _pageInput.BringToFront();

        }
        public DataTable GetTable()
        {

            DataTable table = new DataTable();
            table.Columns.Add("FFT_ORDER_ID", typeof(string));
            table.Columns.Add("SERIAL_NO", typeof(string));
            table.Columns.Add("GROUP", typeof(string));
            table.Columns.Add("FLOW_NAME", typeof(string));
            //table.Columns.Add("PROCESS_ID", typeof(string));
            table.Columns.Add("PROCESS_START", typeof(string));
            table.Columns.Add("INPUT_DATE", typeof(string));

            return table;
        }

        
    }
}
