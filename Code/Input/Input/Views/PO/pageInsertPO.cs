using Input.Controllers;
using InputManagement.Property;
using Login.Property;
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
    public partial class pageInsertPO : UserControl
    {
        frmMain frm;
        InputOrderControllers _controller = new InputOrderControllers();
        PurchaseOrderProperty _data;


        public pageInsertPO(frmMain obj)
        {
            InitializeComponent();
            frm = obj;
        }

        private void pageInsertPO_Load(object sender, EventArgs e)
        {
            this.ClearPage();
        }
        private void ClearPage()
        {
            this.txtSerial.Clear();
            this.lblFFT_OR.Text = " - ";
            this.lblFFT_OR.Text = " - ";
            this.lblGroup.Text = " - ";
            this.lblInputtype.Text = " - ";
            this.txtPO.Clear();
            this.btnSave.Enabled = false;
            this.txtPO.Enabled = false;
        }
 
        private void txtSerial_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (txtSerial.Text == "")
                {
                    MessageBox.Show("Please Input Serial","Stop",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.ClearPage();
                    return;
                }

                this.btnSave.Enabled = (this.txtSerial.Text.Count() > 0) ? true : false;

                InputProperty _searchSerial = new InputProperty
                {
                    SERIAL_NO = txtSerial.Text.Trim()
                };

                _data = new PurchaseOrderProperty();
                _data = _controller.SearchSerialUpdatePO(_searchSerial);
                if (_data.Order == null || _data.Flow == null || _data.Input == null || _data.Serial == null)
                {
                    MessageBox.Show("Not found data Please Check Serial","Stop",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    this.ClearPage();
                    return;
                }
                this.lblFFT_OR.Text = _data.Order.FFT_ORDER_ID;
                this.lblGroup.Text = _data.Order.GROUP;
                this.lblInputtype.Text = _data.Input.ORDER_TYPE_NAME;
                this.txtPO.Text = (_data.PO != "" || _data.PO != null) ?_data.PO:"";
                this.txtPO.Enabled = true;

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            PurchaseOrderProperty _insertPO = new PurchaseOrderProperty
            {
                PO = txtPO.Text.Trim()
            };
            _insertPO.Order = new OrderProperty
            {
                FFT_ORDER_ID = lblFFT_OR.Text.Trim(),
                GROUP = lblGroup.Text.Trim()
            };
            _insertPO.Order.EMP = new EmpProperty
            {
                code = frm._empLogin.code
            };
            _insertPO.Flow = new FlowProperty
            {
                ID = _data.Flow.ID.ToString() 
            };
            _insertPO.Serial = new SerialProperty
            {
                ID = _data.Serial.ID.ToString()
            };

            if (_insertPO.PO == "" || _insertPO.PO ==null)
            {
                MessageBox.Show("Not found PO Please Check PO", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.ClearPage();
                return;
            }
            if (_insertPO.Order.FFT_ORDER_ID == "" || _insertPO.Order.FFT_ORDER_ID == null)
            {
                MessageBox.Show("Not found FFT_ORDER_ID Please Check FFT_ORDER_ID", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.ClearPage();
                return;
            }
            if (_insertPO.Order.GROUP == "" || _insertPO.Order.GROUP == null)
            {
                MessageBox.Show("Not found GROUP Please Check GROUP", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.ClearPage();
                return;
            }
            if (_insertPO.Order.EMP.code == "" || _insertPO.Order.EMP.code == null)
            {
                MessageBox.Show("Not found CODE_EMP Please Check CODE_EMP", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.ClearPage();
                return;
            }
            if (_insertPO.Flow.ID == "" || _insertPO.Flow.ID == null)
            {
                MessageBox.Show("Not found FLOW_ID Please Check FLOW_ID", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.ClearPage();
                return;
            }
            if (_insertPO.Serial.ID == "" || _insertPO.Serial.ID == null)
            {
                MessageBox.Show("Not found Serial_ID Please Check Serial_ID", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.ClearPage();
                return;
            }

            //insert
            if (_controller.SearchPO(_insertPO))
            {
                this.ClearPage();
            }
            

            
        }

        
    }
}
