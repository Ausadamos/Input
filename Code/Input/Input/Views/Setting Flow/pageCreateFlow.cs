using InputManagement.Property;
using Input.Controllers;
using BusinessData.Property;

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
    public partial class pageCreateFlow : UserControl
    {
        List<ProcessProperty> _listProcessAll;
        List<ProcessProperty> listSelectProcess = new List<ProcessProperty>();
        List<FlowProcessProperty> _listFlowProcess;
        FlowControllers _controllers = new FlowControllers();
        ProcessControllers _processControllers = new ProcessControllers();
        frmMain  _frmMain;

        public pageCreateFlow(frmMain obj)
        {
            InitializeComponent();
            _frmMain = obj;
        }

        private void pageCreateFlow_Load(object sender, EventArgs e)
        {
            this.txtFlowName.Text = _controllers.GetFlowName();
            this.SearchProcessAll();
        }

        private void SearchProcessAll()
        {
            //Get Process Fiberlaser in database(ja_test)
            _listProcessAll =  new List<ProcessProperty>();
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
                lstProcess.DataSource = null ;
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
                ////ADD Process Flow_process

                string title = Convert.ToString(lstProcess.SelectedValue);
                int indexInList = _listProcessAll.FindIndex(a => a.PROCESS_NAME.Contains(title));

                listSelectProcess.Add(_listProcessAll[indexInList]);
                _listProcessAll.RemoveAt(indexInList);

                this.ShowProcess();

            }
        }

        private void BackProcess()
        {
            //if (treeViewSetProcess.SelectedItem != null)
            //{

            //    //Remove Process Flow_process 

            //    string titleSelect = Convert.ToString(treeViewSetProcess.SelectedValue);
            //    int indexInList = listSelectProcess.FindIndex(a => a.PROCESS_NAME.Contains(titleSelect));

            //    _listProcessAll.Add(listSelectProcess[indexInList]);
            //    listSelectProcess.RemoveAt(indexInList);

            //    this.ShowProcess();

            //}
        }

        //Select Order Set Process
        private void MoveUp(TreeView treeViewSetProcess)
        {
            //string titleSelect = Convert.ToString(treeViewSetProcess.SelectedValue);
            //int indexInList = listSelectProcess.FindIndex(a => a.PROCESS_NAME.Contains(titleSelect));
            //if (indexInList > 0)
            //{
            //    listSelectProcess.Insert(indexInList - 1, listSelectProcess[indexInList]);
            //    listSelectProcess.RemoveAt(indexInList + 1);

            //    this.ShowProcess();
            //    treeViewSetProcess.SelectedIndex = indexInList - 1;
            //}

        }

        //Select Order Set Process
        private void MoveDown(TreeView treeViewSetProcess)
        {
            //string titleSelect = Convert.ToString(treeViewSetProcess.SelectedValue);
            //int indexInList = listSelectProcess.FindIndex(a => a.PROCESS_NAME.Contains(titleSelect));

            //if (indexInList < treeViewSetProcess.Items.Count - 1 & indexInList != -1)
            //{
            //    listSelectProcess.Insert(indexInList + 2, listSelectProcess[indexInList]);
            //    listSelectProcess.RemoveAt(indexInList);

            //    this.ShowProcess();
            //    treeViewSetProcess.SelectedIndex = indexInList + 1;
            //}
            
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
            if (listSelectProcess.Count == 0)
            {
                MessageBox.Show("Please Select Process For Create Flow", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
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
            //_flowInsert.FLOW = new FlowProperty {
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


            ////Insert Flow.
            //if (_controllers.InsertFlow(_flowInsert)){ _frmMain.Load_SetFlow(); }
            
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
            this.btnAdd.Enabled = true;

            this.btnRemove.Enabled = false;
            this.btnUp.Enabled = false;
            this.btnDown.Enabled = false;

           // this.treeViewSetProcess.ClearSelected();
        }

        private void treeViewSetProcess_Click(object sender, EventArgs e)
        {
            this.btnAdd.Enabled = false;

            this.btnRemove.Enabled = true;
            this.btnUp.Enabled = true;
            this.btnDown.Enabled = true;

            this.lstProcess.ClearSelected();
        }
    }
}
