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
    public partial class pageTestManufacturing : UserControl
    {
        InputOrderControllers _controllers = new InputOrderControllers();
        FlowControllers _controllerFlow = new FlowControllers();
        ShipmentControllers _controllersShipment = new ShipmentControllers();

        FlowProperty _flow;

        public List<InputProperty> _listInputTestManufacturing = new List<InputProperty>();

        frmMain _frmMain;
        DataTable tableInputTest;

        public int HistoryCount;

        public pageTestManufacturing(frmMain obj)
        {
            InitializeComponent();
            _frmMain = obj;
        }

        private void Load_Flow()
        {
            _flow = new FlowProperty();
            _flow = _controllerFlow.CallFlowRMA();
            this.cmbSelect_FlowName.Text = _flow.FLOW_NAME.ToString();

            this.tableInputTest = GetTable();
        }

        private DataTable GetTable()
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

        private void LoadInput_History()
        {
            frmInput_History _frminput_history = new frmInput_History(_frmMain);
            _frminput_history.ShowDialog();
        }

        private void pageTestManufacturing_Load(object sender, EventArgs e)
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

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            this.LoadInput_History();
        }

        private void txtSerial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (this.txtSerial.Text.Trim() != "")
                {

                    InputProperty _input = new InputProperty();
                    _input.Order = new OrderProperty();
                    _input.Order.PURCHASR = new PurchaseProperty();
                    _input.Order.PURCHASR.FLOW = new FlowProperty();

                    _input.Order.FFT_ORDER_ID = _frmMain._order.FFT_ORDER_ID.ToString();
                    _input.SERIAL_NO = this.txtSerial.Text.ToString();
                    _input.Order.GROUP = this.lblGroup.Text.ToString().Trim();
                    _input.Order.PURCHASR.FLOW.FLOW_NAME = this.cmbSelect_FlowName.Text.ToString();
                    _input.INPUT_DATE = DateTime.Now.ToString("yyyy-MM-dd");

                    foreach (InputProperty _checkInput in _listInputTestManufacturing)
                    {
                        if (_checkInput.SERIAL_NO == _input.SERIAL_NO)
                        {
                            MessageBox.Show("Have Serial_NO : " + _checkInput.SERIAL_NO + " Duplicate", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.txtSerial.Clear();
                            return;
                        }
                    }
                    _listInputTestManufacturing.Add(_input);

                    this.tableInputTest.Rows.Add(
                        _input.Order.FFT_ORDER_ID,
                        _input.SERIAL_NO,
                        _input.Order.GROUP,
                        _input.Order.PURCHASR.FLOW.FLOW_NAME,
                        _input.INPUT_DATE
                        );

                    this.dgvInputRMA.DataSource = this.tableInputTest;

                    this.txtTotalQty.Text = Convert.ToString(_listInputTestManufacturing.Count());
                    this.txtHistory.Text = Convert.ToString(HistoryCount + _listInputTestManufacturing.Count());

                    this.txtSerial.Clear();
                }
                else
                { MessageBox.Show("Please input Serial_NO", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
            }
        }

    }
}
