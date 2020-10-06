using BusinessData.Property;
using CommonClassLibrary.Components;
using InputManagement.Controllers;
using InputManagement.Property;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Input
{
    public partial class pageCreateFlow : UserControl
    {
        List<ProcessProperty> _listProcessAll;
        List<ProcessProperty> listSelectProcess = new List<ProcessProperty>();
        List<FlowProcessProperty> _listFlowProcess;
        FlowControllers _controllers = new FlowControllers();
        frmMain _frmMain;
        SubProductController _productSubController = new SubProductController();
        ProcessController _processControllers = new ProcessController();
        ProductTypeController _productTypeController = new ProductTypeController();
        ProcessSubController _processSubController = new ProcessSubController();
        FlowProcess_FlowProcessSubController _flowProcess_FlowProcessSubController = new FlowProcess_FlowProcessSubController();

        List<ProcessSubProperty> _listProcessSub = new List<ProcessSubProperty>();
        List<ProcessProperty> _listProcess = new List<ProcessProperty>();

        int ProcessSubIdSelected = 0;

        public pageCreateFlow(frmMain obj)
        {
            InitializeComponent();
            _frmMain = obj;
        }

        private void pageCreateFlow_Load(object sender, EventArgs e)
        {
            this.txtFlowName.Text = _controllers.GetFlowName();
            LoadProduct();

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
        }

        private void SearchProcessAll()
        {
            //Get Process Fiberlaser in database(ja_test)
            _listProcessAll = new List<ProcessProperty>();
            _listProcessAll = _processControllers.SearchProcessAll();

            this.ShowProcess();

        }
        private void ShowProcess()
        {

            if (_listProcessAll.Count >= 0)
            {
                //Show Process Left side ********
                List<DropDownProperty> listShowProcess = new List<DropDownProperty>();

                foreach (ProcessProperty _process in _listProcessAll)
                {
                    DropDownProperty dropProcess = new DropDownProperty
                    {
                        Value = _process.PROCESS_NAME
                        ,
                        Text = "(ID " + _process.ID + ") " + _process.PROCESS_NAME
                    };
                    listShowProcess.Add(dropProcess);
                }
                lstProcess.DataSource = null;
                lstProcess.DataSource = listShowProcess;
                lstProcess.DisplayMember = "Text";
                lstProcess.ValueMember = "Value";

                //******************************
            }

            if (listSelectProcess.Count >= 0)
            {
                //Show Process Right side ********
                List<DropDownProperty> listSelectProcess = new List<DropDownProperty>();
                int number = 1;
                foreach (ProcessProperty _process in this.listSelectProcess)
                {
                    DropDownProperty SelectProcess = new DropDownProperty
                    {
                        Value = _process.PROCESS_NAME
                    ,
                        Text = "(" + number + ") " + _process.PROCESS_NAME
                    };
                    listSelectProcess.Add(SelectProcess);

                    number = number + 1;
                }
                //treeViewSetProcess.DataSource = null;
                //treeViewSetProcess.DataSource = listSelectProcess;
                //treeViewSetProcess.DisplayMember = "Text";
                //treeViewSetProcess.ValueMember = "Value";
            }
        }

        private void AddProcess()
        {
            if (lstProcess.SelectedItem != null)
            {

                if (treeViewSetProcess.Nodes.Count > 0)
                {

                    foreach (TreeNode tn in treeViewSetProcess.Nodes)
                    {
                        if ((lstProcess.SelectedItem as ListBoxItem).Value.ToString() == tn.Name)
                        {
                            MessageBox.Show("Process Duplicate", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                    }


                }

                string title = lstProcess.SelectedItem.ToString();
                treeViewSetProcess.Nodes.Add((lstProcess.SelectedItem as ListBoxItem).Value.ToString(), title);

            }
        }

        private void BackProcess()
        {

            if (treeViewSetProcess.SelectedNode != null)
            {
                if (treeViewSetProcess.SelectedNode.Parent == null)
                {

                    treeViewSetProcess.Nodes.Remove(treeViewSetProcess.SelectedNode);

                    //Remove Process Flow_process 

                    //string titleSelect = Convert.ToString(treeViewSetProcess.SelectedValue);
                    //int indexInList = listSelectProcess.FindIndex(a => a.PROCESS_NAME.Contains(titleSelect));

                    //_listProcessAll.Add(listSelectProcess[indexInList]);
                    //listSelectProcess.RemoveAt(indexInList);

                    //this.ShowProcess();

                }
                else
                {
                    treeViewSetProcess.Nodes.Remove(treeViewSetProcess.SelectedNode);
                }
            }

        }



        //Select Order Set Process
        private void MoveUp(TreeView treeViewSetProcess)
        {
            if (treeViewSetProcess.SelectedNode != null)
            {
                TreeNode node = this.treeViewSetProcess.SelectedNode.Clone() as TreeNode;
                if (treeViewSetProcess.SelectedNode.Parent == null)
                {
                    this.treeViewSetProcess.BeginUpdate();
                    if (this.treeViewSetProcess.SelectedNode.Index > 0)
                    {
                        this.treeViewSetProcess.Nodes.Insert(this.treeViewSetProcess.SelectedNode.Index - 1, node);
                        this.treeViewSetProcess.Nodes.RemoveAt(this.treeViewSetProcess.SelectedNode.Index);
                    }
                    this.treeViewSetProcess.EndUpdate();

                    this.treeViewSetProcess.SelectedNode = node;
                    this.treeViewSetProcess.Select();
                }
                else
                {
                    this.treeViewSetProcess.BeginUpdate();
                    if (this.treeViewSetProcess.SelectedNode.Index > 0)
                    {
                        this.treeViewSetProcess.SelectedNode.Parent.Nodes.Insert(this.treeViewSetProcess.SelectedNode.Index - 1, node);
                        this.treeViewSetProcess.SelectedNode.Parent.Nodes.RemoveAt(this.treeViewSetProcess.SelectedNode.Index);
                    }
                    this.treeViewSetProcess.EndUpdate();

                    this.treeViewSetProcess.SelectedNode = node;
                    this.treeViewSetProcess.Select();
                }
                treeViewSetProcess.ExpandAll();
            }
        }

        //Select Order Set Process
        private void MoveDown(TreeView treeViewSetProcess)
        {

            if (treeViewSetProcess.SelectedNode != null)
            {
                TreeNode node = this.treeViewSetProcess.SelectedNode.Clone() as TreeNode;
                if (treeViewSetProcess.SelectedNode.Parent == null)
                {
                    this.treeViewSetProcess.BeginUpdate();

                    this.treeViewSetProcess.Nodes.Insert(this.treeViewSetProcess.SelectedNode.Index + 2, node);
                    this.treeViewSetProcess.Nodes.RemoveAt(this.treeViewSetProcess.SelectedNode.Index);

                    this.treeViewSetProcess.EndUpdate();

                    this.treeViewSetProcess.SelectedNode = node;
                    this.treeViewSetProcess.Select();
                }
                else
                {
                    this.treeViewSetProcess.BeginUpdate();

                    this.treeViewSetProcess.SelectedNode.Parent.Nodes.Insert(this.treeViewSetProcess.SelectedNode.Index + 2, node);
                    this.treeViewSetProcess.SelectedNode.Parent.Nodes.RemoveAt(this.treeViewSetProcess.SelectedNode.Index);

                    this.treeViewSetProcess.EndUpdate();

                    this.treeViewSetProcess.SelectedNode = node;
                    this.treeViewSetProcess.Select();
                }
                treeViewSetProcess.ExpandAll();
            }

        }

        private void lstProcess_DoubleClick(object sender, EventArgs e)
        {
            this.AddProcess();
        }
        private void treeViewSetProcess_DoubleClick(object sender, EventArgs e)
        {
            this.BackProcess();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.CreateFlow();

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            _frmMain.Load_SetFlow();
        }
        private void CreateFlow()
        {
            if (treeViewSetProcess.Nodes.Count == 0)
            {
                MessageBox.Show("Please Select Process For Create Flow", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            int NOProcess = 0;
            int NOProcessSub = 0;

            List<ProcessFlowProperty> _listFlowProcess = new List<ProcessFlowProperty>();
            List<ProcessSubFlowProperty> _listFlowProcessSub = new List<ProcessSubFlowProperty>();

            foreach (TreeNode processMainNode in treeViewSetProcess.Nodes)
            {
                NOProcessSub = 0;

                FlowProperty _flowProperty = new FlowProperty
                {
                    FLOW_NAME = txtFlowName.Text,
                    FLOW_TYPE = new FlowTypeProperty
                    {
                        ID = "1"
                    },
                    PRODUCT_SUB_CODE = (cmbProduct.SelectedItem as ComboboxItem).Value.ToString()

                };

                ProcessFlowProperty _flowProcessProperty = new ProcessFlowProperty
                {
                    FLOW = _flowProperty,
                    PROCESS = new ProcessProperty()
                    {
                        ID = processMainNode.Name.ToString()
                    },
                    NO = (++NOProcess).ToString(),
                    CREATE_USER = _frmMain._empLogin.code
                };

                _listFlowProcess.Add(_flowProcessProperty);

                foreach (TreeNode processSubNode in processMainNode.Nodes)
                {
                    ProcessSubFlowProperty _flowProcessSubProperty = new ProcessSubFlowProperty
                    {
                        FLOW = _flowProperty,
                        PROCESS_SUB = new ProcessSubProperty
                        {
                            PROCESS_SUB_ID = processSubNode.Name
                        },
                        NO = (++NOProcessSub).ToString(),
                        CREATE_USER = _frmMain._empLogin.code

                    };
                    _listFlowProcessSub.Add(_flowProcessSubProperty);
                }


            }

            ////Get Procress for get id
            //List<ProcessProperty> _getProcess = new List<ProcessProperty>();
            //for (int i = 0; i < treeViewSetProcess.Items.Count; i++)
            //{
            //    int NOProcess = i + 1;
            //    ProcessProperty _process = new ProcessProperty()
            //    {
            //        ID = listSelectProcess[i].ID.ToString()
            //        ,
            //        PROCESS_NAME = listSelectProcess[i].PROCESS_NAME.ToString()
            //        ,
            //        NO = NOProcess.ToString()
            //    };
            //    _getProcess.Add(_process);
            //}

            //FlowProcessProperty _flowInsert = new FlowProcessProperty();
            //_flowInsert.FLOW = new FlowProperty
            //{
            //    FLOW_NAME = txtFlowName.Text
            //};

            //_flowInsert.PROCESS = new List<ProcessProperty>();
            //_flowInsert.PROCESS = _getProcess;
            //////Get Process ID.
            ////foreach (ProcessProperty _process in _getProcess)
            ////{
            ////    foreach (ProcessProperty _processAll in _listProcessAll)
            ////    {
            ////        if (_process.PROCESS_NAME == _processAll.PROCESS_NAME)
            ////        {
            ////            ProcessProperty _orderprocess = new ProcessProperty()
            ////            {
            ////                ID = _processAll.ID
            ////                ,NO  = _process.NO
            ////                ,PROCESS_NAME = _processAll.PROCESS_NAME 
            ////            };
            ////            _flowInsert.PROCESS.Add(_orderprocess);
            ////        }
            ////    }
            ////}

            //// Check Flow process
            //_listFlowProcess = new List<FlowProcessProperty>();
            //string countNoProcess = Convert.ToString(_getProcess.Count);
            //_listFlowProcess = _controllers.CheckDuplicateFlowProcess(countNoProcess);

            //bool status = false;
            //foreach (FlowProcessProperty flow in _listFlowProcess)
            //{
            //    int j = 0;
            //    for (int i = 0; i < Convert.ToInt16(countNoProcess); i++)
            //    {
            //        status = false;
            //        if (flow.PROCESS[i].PROCESS_NAME.ToString() == listSelectProcess[i].PROCESS_NAME.ToString())
            //        {
            //            status = true;
            //        }
            //        if (!status)
            //        {
            //            break;
            //        }
            //    }
            //    if (status)
            //    {
            //        MessageBox.Show("Duplicate Flow name : " + flow.FLOW.FLOW_NAME, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //}


            ////for (int i = 0; i < _listFlowProcess.Count; i++)
            ////{
            ////    int checkFlow = 0;
            ////    for (int j = 0; j < _listFlowProcess[i].PROCESS.Count; j++)
            ////    {
            ////        if (_listFlowProcess[i].PROCESS[j].ID == _flowInsert.PROCESS[j].ID)
            ////        {
            ////            checkFlow = checkFlow + 1;
            ////            if (checkFlow == _flowInsert.PROCESS.Count)
            ////            {
            ////                MessageBox.Show("Have FlowProcess in Database " +
            ////                    "\n" + "Flow name : " + _listFlowProcess[i].FLOW.FLOW_NAME +
            ////                    "\n" + "Status : " + _listFlowProcess[i].FLOW.STATUS, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ////                return;
            ////            }
            ////        }
            ////        else { break; }
            ////    }
            ////}




            //Insert Flow.
            //if (_controllers.InsertFlow(_flowInsert)) { _frmMain.Load_SetFlow(); }

            FlowProcess_FlowProcessSubProperty flowProcess_FlowProcessSubProperty = new FlowProcess_FlowProcessSubProperty
            {
                listProcessFlowProperty = _listFlowProcess,
                listProcessSubFlowProperty = _listFlowProcessSub
            };

            if (_flowProcess_FlowProcessSubController.Insert(flowProcess_FlowProcessSubProperty))
            {
                _frmMain.Load_SetFlow();
                btnBack.PerformClick();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddProcess();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.BackProcess();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            this.MoveUp(treeViewSetProcess);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            this.MoveDown(treeViewSetProcess);
        }

        private void lstProcess_Click(object sender, EventArgs e)
        {
            this.btnAddProcess.Enabled = true;

            this.btnRemoveProcess.Enabled = false;
            this.btnUpProcess.Enabled = false;
            this.btnDownProcess.Enabled = false;

            // this.treeViewSetProcess.ClearSelected();
        }

        private void treeViewSetProcess_Click(object sender, EventArgs e)
        {
            this.btnAddProcess.Enabled = false;

            this.btnRemoveProcess.Enabled = true;
            this.btnUpProcess.Enabled = true;
            this.btnDownProcess.Enabled = true;

            this.lstProcess.ClearSelected();
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbProduct.Text))
            {

                if (treeViewSetProcess.Nodes.Count > 0)
                {
                    DialogResult result = MessageBox.Show("คุณมีการจัด Flow อยู่ ยืนยันการเปลี่ยน Product หรือไม่", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        treeViewSetProcess.Nodes.Clear();
                    }
                    else
                    {
                        return;
                    }
                }

                lstSubProcess.Items.Clear();
                txtProcessSelected.Text = "XXX";
                ProcessSubIdSelected = 0;
                LoadMainProcess();

            }
        }

        //private void LoadProductType()
        //{

        //    ProductTypeProperty PRODUCT_TYPE = new ProductTypeProperty()
        //    {
        //        PRODUCT_SUB_CODE = (cmbProduct.SelectedItem as ComboboxItem).Value.ToString()
        //    };
        //    List<ProductTypeProperty> listProductTypeProperty = _productTypeController.SearchByProductSubCode(PRODUCT_TYPE);
        //    foreach (ProductTypeProperty data in listProductTypeProperty)
        //    {
        //        ComboboxItem item = new ComboboxItem();
        //        item.Text = data.PRODUCT_TITLE;
        //        item.Value = data.ID;
        //        cmbProductType.Items.Add(item);
        //    }
        //}

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (treeViewSetProcess.Nodes.Count > 0)
            {
                DialogResult result = MessageBox.Show("คุณมีการจัด Flow อยู่ ยืนยันการเปลี่ยน Product Type หรือไม่", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    treeViewSetProcess.Nodes.Clear();
                }
                else
                {
                    return;
                }
            }

            lstProcess.Items.Clear();


            if (!string.IsNullOrWhiteSpace(cmbProduct.Text))
            {
                LoadMainProcess();
                foreach (ProcessProperty data in _listProcess)
                {
                    ListBoxItem item = new ListBoxItem();
                    item.Text = data.PROCESS_NAME;
                    item.Value = data.ID;
                    lstProcess.Items.Add(item);
                }
                lstSubProcess.Items.Clear();
                txtProcessSelected.Text = "XXX";
            }
            else
            {

                lstSubProcess.Items.Clear();
                txtProcessSelected.Text = "XXX";
            }

        }

        private void LoadMainProcess()
        {

            ProcessProperty _processProperty = new ProcessProperty()
            {
                PRODUCT_SUB_CODE = (cmbProduct.SelectedItem as ComboboxItem).Value.ToString()
            };

            _listProcess = _processControllers.SearchProcessByProductSubCode(_processProperty);

            lstProcess.Items.Clear();
            foreach (ProcessProperty data in _listProcess.FindAll(x => x.INUSE == "True"))
            {
                ListBoxItem item = new ListBoxItem();
                item.Text = data.PROCESS_NAME;
                item.Value = data.ID;
                lstProcess.Items.Add(item);
            }
        }

        private void cmbMainProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstSubProcess.Items.Clear();
            if (!string.IsNullOrWhiteSpace(cmbProduct.Text))
            {
                this.LoadProcess();
            }

        }

        private void LoadProcess()
        {
            _listProcessSub = _processSubController.SearchProcessSubByProcessMainId(new ProcessSubProperty { PROCESS_ID = treeViewSetProcess.SelectedNode.Name });
            lstSubProcess.Items.Clear();
            foreach (ProcessSubProperty data in _listProcessSub.FindAll(x => x.INUSE == "True"))
            {
                ListBoxItem item = new ListBoxItem();
                item.Text = data.SUB_PROCESS_NAME;
                item.Value = data.PROCESS_SUB_ID;
                lstSubProcess.Items.Add(item);
            }
        }

        private void treeViewSetProcess_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewSetProcess.SelectedNode.Parent == null)
            {
                LoadProcess();
                txtProcessSelected.Text = treeViewSetProcess.SelectedNode.Text;
                ProcessSubIdSelected = int.Parse(treeViewSetProcess.SelectedNode.Name);

                btnRemoveProcess.Enabled = true;
                btnRemoveProcessSub.Enabled = false;

                btnUpProcess.Enabled = true;
                btnDownProcess.Enabled = true;
                btnUpProcessSub.Enabled = false;
                btnDownProcessSub.Enabled = false;

            }
            else
            {
                btnRemoveProcess.Enabled = false;
                btnRemoveProcessSub.Enabled = true;


                btnUpProcess.Enabled = false;
                btnDownProcess.Enabled = false;
                btnUpProcessSub.Enabled = true;
                btnDownProcessSub.Enabled = true;

            }

        }

        private void lstSubProcess_DoubleClick(object sender, EventArgs e)
        {
            this.AddProcessSub();
        }

        private void AddProcessSub()
        {

            if (lstSubProcess.SelectedItem != null)
            {


                if (ProcessSubIdSelected != 0)
                {
                    foreach (TreeNode tn in treeViewSetProcess.Nodes[ProcessSubIdSelected.ToString()].Nodes)
                    {
                        if ((lstSubProcess.SelectedItem as ListBoxItem).Value.ToString() == tn.Name)
                        {
                            MessageBox.Show("Process Duplicate", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                    }
                }

                treeViewSetProcess.Nodes[ProcessSubIdSelected.ToString()].Nodes.Add((lstSubProcess.SelectedItem as ListBoxItem).Value.ToString(), (lstSubProcess.SelectedItem as ListBoxItem).Text.ToString());
                treeViewSetProcess.ExpandAll();
                //string title = lstProcess.SelectedItem.ToString();
                //treeViewSetProcess.Nodes.Add((lstProcess.SelectedItem as ListBoxItem).Value.ToString(), title);

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProcessSub_Click(object sender, EventArgs e)
        {
            this.AddProcessSub();
        }
    }

}
