using Input.Controllers;
using InputManagement.Property;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Input
{
    public partial class frmPurc_Create : Form
    {
        FlowControllers _flowControllers = new FlowControllers();
        PurchaseControllers _controllers = new PurchaseControllers();
        GenerateSerialControllers _generateSerialControllers = new GenerateSerialControllers();
        FlowProcessProperty _flowProcess = new FlowProcessProperty();

        List<SerialProductTypeProperty> _serialProductType;
        PurchaseProperty _purchase;
        FlowProperty _flow;


        frmMain _frmMain;

        string _defaultExSertila;

        public frmPurc_Create(frmMain obj)
        {
            InitializeComponent();
            _frmMain = obj;
            _defaultExSertila = this.lblExSerialFormat.Text;
        }

        private void frmPurc_Create_Load(object sender, EventArgs e)
        {
            this.txtFFTCode.Clear();
            this.txtModel.Clear();
            this.txtPartNo.Clear();
            this.txtProduct.Clear();
            this.txtPurchaseNo.Clear();
            this.txtPathProcessCard.Clear();

            this.cmbPurchase.Items.Clear();
            this.cmbFlow.Items.Clear();
            this.cmbProductType.Items.Clear();

            this.rdoCopyFlow.Checked = true;
            this.rdoSelectFlow.Checked = false;
            this.cmbFlow.Enabled = false;
            this.Load_ProductType();

        }
        private void Load_ProductType()
        {
            this.cmbProductType.Items.Add("- SELECT PRODUCT TYPE -");
            this.cmbProductType.SelectedIndex = 0;
            _serialProductType = _generateSerialControllers.SearchSerialProductType();
            foreach (SerialProductTypeProperty _serialProType in _serialProductType)
            {
                this.cmbProductType.Items.Add(_serialProType.productTypeProperty.PRODUCT_TITLE.ToString());
            }
        }

        private void rdoCopyFlow_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoCopyFlow.Checked)
            {
                // ***** if  rdo Copy Flow check true *****
                //clear cmb copy flow & cmb flow & list process
                //Get list Purchase in database(ja_test) in combobox Purchase (1.1)

                this.cmbPurchase.Enabled = true;
                this.cmbFlow.Enabled = false;
                this.cmbPurchase.Items.Clear();
                this.cmbFlow.Items.Clear();
                this.lstProcess.Items.Clear();
                this.cmbPurchase.Text = "";

                List<PurchaseProperty> _listPurchase = new List<PurchaseProperty>();
                _listPurchase = _controllers.ListPurchasesAll();
                foreach (PurchaseProperty _Purchase in _listPurchase)
                {
                    cmbPurchase.Items.Add(_Purchase.PURCHASE_NO);
                }
            }
            else if (this.rdoSelectFlow.Checked)
            {
                // ***** if  rdo Flow check true *****
                // disable cmb purchase 
                //clear cmb copy flow & cmb flow & list process
                //Get Flow name in combobox Flow (2.1)

                this.cmbFlow.Enabled = true;
                this.cmbPurchase.Enabled = false;
                this.cmbPurchase.Items.Clear();
                this.cmbFlow.Items.Clear();
                this.lstProcess.Items.Clear();
                this.cmbPurchase.Text = "";
                this.cmbFlow.Text = "";

                List<FlowProperty> _listflow = new List<FlowProperty>();
                _listflow = _flowControllers.LoadFlow();
                foreach (FlowProperty _flow in _listflow)
                {
                    cmbFlow.Items.Add(_flow.FLOW_NAME);
                }
            }
        }

        private void cmbPurchase_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ***** After Select Purchase *****
            //Clear cmb Flow & list process
            //Query by purchase , get flow name & process
            //Load Flow name in cmb Flow & set cmb.text = Flow (1.2)
            this.cmbFlow.Text = "";
            this.cmbFlow.Items.Clear();
            this.lstProcess.Items.Clear();

            if (this.cmbPurchase.Text != "")
            {
                _purchase = new PurchaseProperty();
                {
                    _purchase.PURCHASE_NO = this.cmbPurchase.Text.ToString();
                }

                _flowProcess = _flowControllers.SearchFlowNameByPurchase(_purchase);
                if (_flowProcess.FLOW == null)
                {
                    MessageBox.Show("Not found Process flow " + "\n" + "Please check name purchase", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                cmbFlow.Items.Add(_flowProcess.FLOW.FLOW_NAME);
                cmbFlow.Text = _flowProcess.FLOW.FLOW_NAME;
            }
        }

        private void cmbFlow_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstProcess.Items.Clear();

            // if cmb purchase & cmb flow != "" 
            // Load process in list process (1.3)
            int no = 1;
            if (this.cmbPurchase.Text != "" && this.cmbFlow.Text != "")
            {
                foreach (ProcessProperty _process in _flowProcess.PROCESS)
                {
                    lstProcess.Items.Add(no + "_" + _process.PROCESS_NAME);
                    no += 1;
                }
            }

            // if cmb purchase == "" & cmb flow != ""
            // Query by Flow name  , get process
            // Load process in list process (2.2)
            else if (this.cmbPurchase.Text == "" && this.cmbFlow.Text != "")
            {
                List<ProcessProperty> _listProcess = new List<ProcessProperty>();
                _flow = new FlowProperty
                {
                    FLOW_NAME = this.cmbFlow.Text.ToString()
                };
                _listProcess = _flowControllers.SearchProcessByFlowName(_flow);

                foreach (ProcessProperty _process in _listProcess)
                {
                    lstProcess.Items.Add(no + "_" + _process.PROCESS_NAME);
                    no += 1;
                }
            }
        }
        //by Boat 03/11/2019
        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblExSerialFormat.Text = (this.cmbProductType.SelectedIndex != 0)
                ? _serialProductType[this.cmbProductType.SelectedIndex - 1].serialTypeProperty.DETAIL.ToString() : _defaultExSertila;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            PurchaseProperty _addPurchase = new PurchaseProperty
            {
                PURCHASE_NO = this.txtPurchaseNo.Text.Trim(),
                FLOW = new FlowProperty { FLOW_NAME = this.cmbFlow.Text },
                PART_NO = this.txtPartNo.Text.Trim(),
                PRODUCT_PURCHASE = this.txtProduct.Text.Trim(),
                MODEL = this.txtModel.Text.Trim(),
                FFT_CODE = this.txtFFTCode.Text.Trim(),
                EMP = _frmMain._empLogin,
                PATH_PROCESS_CARD = this.txtPathProcessCard.Text.Trim().Replace(@"\", @"\\"),
                PRODUCT_TYPE = new ProductTypeProperty { PRODUCT_TITLE = this.cmbProductType.Text.Trim() }

            };

            if (_addPurchase.PURCHASE_NO == "")
            {
                MessageBox.Show("Please input Purchase No.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (_addPurchase.PRODUCT_PURCHASE == "")
            {
                MessageBox.Show("Please input Product", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (_addPurchase.MODEL == "")
            {
                MessageBox.Show("Please input Model", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (_addPurchase.PART_NO == "")
            {
                MessageBox.Show("Please input Part_No", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (_addPurchase.FFT_CODE == "")
            {
                MessageBox.Show("Please input FFT_Code", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (_addPurchase.FLOW.FLOW_NAME == "")
            {
                MessageBox.Show("Please Select Flow", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (_addPurchase.PATH_PROCESS_CARD == "")
            {
                MessageBox.Show("Please Choose Flie Process Card", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (_addPurchase.PRODUCT_TYPE.PRODUCT_TITLE == "")
            {
                MessageBox.Show("Please Select Product Type", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            if (_controllers.InsertNewPurchase(_addPurchase))
            {
                this.frmPurc_Create_Load(this.Tag, null);
            }

        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";

            openFileDialog1.Filter = @"Excel Files (.xls)|*.xls|Excel Files (.xlsx)| *.xlsx |Excel Files (.xlsm) | *.xlsm";

            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtPathProcessCard.Text = openFileDialog1.FileName;
                this.lblShowFileName.Text = Path.GetFileName(openFileDialog1.FileName);
            }
        }


    }
}
