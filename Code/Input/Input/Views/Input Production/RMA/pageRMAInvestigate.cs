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
    public partial class pageRMAInvestigate : UserControl
    {
        InputOrderControllers _controllers = new InputOrderControllers();
        FlowControllers _controllerFlow = new FlowControllers();
        ShipmentControllers _controllersShipment = new ShipmentControllers();

        ShipmentProperty _serialCheck;
        FlowProperty _flow;
        public List<InputProperty> _listInputRMAInvestigate = new List<InputProperty>();

        frmMain _frmMain;
        DataTable tableRMA;

        public int HistoryCount;
        public pageRMAInvestigate(frmMain obj)
        {
            InitializeComponent();
            _frmMain = obj;
        }

        private void pageRMAInvestigate_Load(object sender, EventArgs e)
        {
            
            this.lblFFTOrderID.Text = _frmMain._order.FFT_ORDER_ID.ToString();
            this.txtQtyOrder.Text = _frmMain._order.ORDER_QUANTITY.ToString();

            _frmMain._order.ORDER_QUANTITY_HISTORY = _controllers.GetQtyHistory(_frmMain._order);
            this.txtHistory.Text = _frmMain._order.ORDER_QUANTITY_HISTORY;
            this.HistoryCount = Convert.ToInt32(_frmMain._order.ORDER_QUANTITY_HISTORY);

            if (_frmMain._order.ORDER_QUANTITY_HISTORY == "0")
            {
                this.lblGroup.Text = "1";
                this.btnViewHistory.Visible = false;
            }
            else
            {
                this.lblGroup.Text = Convert.ToString(Convert.ToInt32(_frmMain._order.ORDER_QUANTITY_HISTORY.Count()) + 1);
                this.btnViewHistory.Visible = true;
            }

            this.txtTotalQty.Text = "0";
            this.Load_Flow();


        }
        private void Load_Flow()
        {
            _flow = new FlowProperty();
            _flow = _controllerFlow.CallFlowRMA();
            this.cmbSelect_FlowName.Text = _flow.FLOW_NAME.ToString();

            this.tableRMA = GetTable();
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

        private void txtSerial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (this.txtSerial.Text.Trim() != "")
                {

                    InputProperty _input = new InputProperty();
                    _input.Order = new OrderProperty();
                    _input.Order.PURCHASR = new PurchaseProperty()
                    {
                        //ID : 0 = No purchase.(N/A)
                        ID = "0"
                    };
                    _input.Order.PURCHASR.FLOW = new FlowProperty()
                    {
                        FLOW_NAME = this.cmbSelect_FlowName.Text.ToString()
                    };

                    _input.Order.FFT_ORDER_ID = _frmMain._order.FFT_ORDER_ID.ToString();
                    _input.SERIAL_NO = this.txtSerial.Text.ToString();
                    _input.Order.GROUP = this.lblGroup.Text.ToString().Trim();
                    _input.INPUT_DATE = DateTime.Now.ToString("yyyy-MM-dd");

                    if (this.CheckSerialNOExistInShipment())
                    {
                        foreach (InputProperty _checkInput in _listInputRMAInvestigate)
                        {
                            if (_checkInput.SERIAL_NO == _input.SERIAL_NO)
                            {
                                MessageBox.Show("Have Serial_NO : " + _checkInput.SERIAL_NO + " Duplicate", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                this.txtSerial.Clear();
                                return;
                            }
                        }
                        _listInputRMAInvestigate.Add(_input);
                    }
                    else { return; }

                    tableRMA.Rows.Add(
                        _input.Order.FFT_ORDER_ID,
                        _input.SERIAL_NO,
                        _input.Order.GROUP,
                        _input.Order.PURCHASR.FLOW.FLOW_NAME,
                        _input.INPUT_DATE
                        );

                    this.dgvInputRMA.DataSource = this.tableRMA;

                    this.txtTotalQty.Text = Convert.ToString(_listInputRMAInvestigate.Count());
                    this.txtHistory.Text = Convert.ToString(HistoryCount + _listInputRMAInvestigate.Count());

                    this.txtSerial.Clear();
                }
                else
                { MessageBox.Show("Please input Serial_NO", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
            }
        }

        private bool CheckSerialNOExistInShipment()
        {
            // Check Serial in Shipment //

            bool statusSerail = false;
            _serialCheck = new ShipmentProperty();
            _serialCheck.SERIAL_NO = this.txtSerial.Text.ToString().Trim();
            ShipmentProperty _shippingReturn = new ShipmentProperty();
            ShipmentProperty _shipping = _controllersShipment.SearchSerailShipping(_serialCheck);

            if (_shipping.SERIAL_NO != "")
            {
                _shippingReturn = _controllersShipment.SearchSerailShippingReturn(_serialCheck);
            }
            else
            {
                MessageBox.Show("Serial_NO : " + _serialCheck.SERIAL_NO + " Not Already Shipping  From " + "\n" + " Program Shipping", "Stop"
                                , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtSerial.Clear();

                return statusSerail;
            }
            if (_shippingReturn.SERIAL_NO != "")
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


        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_listInputRMAInvestigate.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want back page", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    this.Clear_page();
                }

            }
            this.Clear_page();
        }

        public DataTable GetTable()
        {

            DataTable table = new DataTable();
            table.Columns.Add("FFT_ORDER_ID", typeof(string));
            table.Columns.Add("SERIAL_NO", typeof(string));
            table.Columns.Add("GROUP", typeof(string));
            table.Columns.Add("FLOW_NAME", typeof(string));
            table.Columns.Add("INPUT_DATE", typeof(string));

            return table;
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
             List<InputProperty> TEst = _listInputRMAInvestigate;
        }
    }
}

