using CommonClassLibrary.Components;
using InputManagement.Controllers;
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




        List<SerialProductTypeProperty> _listSerialProductTypeProperty;
        List<ProductTypeProperty> _listProductTypeProperty;
        List<SerialTypeProperty> listSerialTypeProperty;

        PurchaseProperty _purchase;
        FlowProperty _flow;

        SubProductController _productSubController = new SubProductController();
        ProductTypeController _productTypeController = new ProductTypeController();
        SerialProductTypeController _serialProductTypeController = new SerialProductTypeController();
        SerialTypeController _serialTypeController = new SerialTypeController();

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
            //this.Load_ProductType();
            LoadProduct();
            listSerialTypeProperty = _serialTypeController.Search();
        }

        private void LoadProduct()
        {
            cmbProduct.Items.Clear();
            List<SubProductProperty> listProductSubProperty = _productSubController.Search();
            foreach (SubProductProperty data in listProductSubProperty)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = data.PRODUCT_SUB_NAME;
                item.Value = data.PRODUCT_SUB_CODE;
                cmbProduct.Items.Add(item);
            }
            cmbProduct.SelectedIndex = -1;
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbProduct.Text))
            {
                Load_ProductType();
                this.lblExSerialFormat.Text = "";
                rdoCopyFlow.PerformClick();
            }
        }

        private void Load_ProductType()
        {
            cmbProductType.Items.Clear();

            this.cmbProductType.SelectedIndex = -1;

            ProductTypeProperty _productTypeProperty = new ProductTypeProperty()
            {
                PRODUCT_SUB_CODE = (cmbProduct.SelectedItem as ComboboxItem).Value.ToString()
            };

            _listProductTypeProperty = _productTypeController.SearchByProductSubCode(_productTypeProperty);

            foreach (ProductTypeProperty data in _listProductTypeProperty)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = data.PRODUCT_TITLE;
                item.Value = data.ID;
                cmbProductType.Items.Add(item);
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
                this.treeViewSetProcess.Nodes.Clear();
                this.cmbPurchase.Text = "";

                if (cmbProduct.Text != "")
                {
                    List<PurchaseProperty> _listPurchase = new List<PurchaseProperty>();

                    _listPurchase = _controllers.SearchPurchasesByProduct(new PurchaseProperty { PRODUCT_TYPE = new ProductTypeProperty { PRODUCT_SUB_CODE = (cmbProduct.SelectedItem as ComboboxItem).Value.ToString() } });
                    foreach (PurchaseProperty _Purchase in _listPurchase)
                    {
                        cmbPurchase.Items.Add(_Purchase.PURCHASE_NO);
                    }
                }
                createTree();

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
                this.treeViewSetProcess.Nodes.Clear();
                this.cmbPurchase.Text = "";
                this.cmbFlow.Text = "";

                //List<FlowProperty> _listflow = new List<FlowProperty>();
                //_listflow = _flowControllers.LoadFlow();
                //foreach (FlowProperty _flow in _listflow)
                //{
                //    cmbFlow.Items.Add(_flow.FLOW_NAME);
                //}

                if (cmbProduct.Text != "")
                {
                    List<FlowProperty> _listFlow = new List<FlowProperty>();

                    _listFlow = _flowControllers.SearchFlowByProduct(new FlowProperty { PRODUCT_SUB_CODE = (cmbProduct.SelectedItem as ComboboxItem).Value.ToString() });



                    foreach (FlowProperty _Flow in _listFlow)
                    {
                        cmbFlow.Items.Add(_Flow.FLOW_NAME);
                    }
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
            this.treeViewSetProcess.Nodes.Clear();

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

            createTree();
        }

        private void cmbFlow_SelectedIndexChanged(object sender, EventArgs e)
        {
            createTree();
        }

        private void createTree()
        {
            this.treeViewSetProcess.Nodes.Clear();

            // if cmb purchase & cmb flow != "" 
            // Load process in list process (1.3)
            int no = 1;
            int noSub = 1;

            List<ProcessProperty> _listProcess = new List<ProcessProperty>();
            List<ProcessSubProperty> _listProcessSub = new List<ProcessSubProperty>();
            _flow = new FlowProperty
            {
                FLOW_NAME = this.cmbFlow.Text.ToString()
            };
            _listProcess = _flowControllers.SearchProcessByFlowName(_flow);
            _listProcessSub = _flowControllers.SearchProcessSubByFlowName(_flow);

            foreach (ProcessProperty _process in _listProcess)
            {
                noSub = 1;
                treeViewSetProcess.Nodes.Add(no + "_" + _process.PROCESS_NAME);
                foreach (ProcessSubProperty _processSub in _listProcessSub.FindAll(x => x.PROCESS_ID == _process.ID))
                {
                    treeViewSetProcess.Nodes[treeViewSetProcess.Nodes.Count - 1].Nodes.Add(noSub + "_" + _processSub.SUB_PROCESS_NAME);
                    noSub += 1;
                }

                no += 1;
            }

            //by Boat 03/11/2019
        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {


            _listSerialProductTypeProperty = _serialProductTypeController.SearchByProductTypeId(new SerialProductTypeProperty { PRODUCT_TYPE = new ProductTypeProperty { ID = (cmbProductType.SelectedItem as ComboboxItem).Value.ToString() } });
            _listSerialProductTypeProperty = _listSerialProductTypeProperty.FindAll(x => x.INUSE == "True");


            this.lblExSerialFormat.Text = _listSerialProductTypeProperty.Count == 0 ? _defaultExSertila : listSerialTypeProperty.Find(x => x.ID == _listSerialProductTypeProperty[0].SERIAL_TYPE.ID).SERIAL_FORMAT;

            //this.lblExSerialFormat.Text = (this.cmbProductType.SelectedIndex != 0)
            //    ? _listProductTypeProperty[this.cmbProductType.SelectedIndex - 1].SERIAL_TYPE.DETAIL.ToString() : _defaultExSertila;
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
                this.Close();
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

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void rdoSelectFlow_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
