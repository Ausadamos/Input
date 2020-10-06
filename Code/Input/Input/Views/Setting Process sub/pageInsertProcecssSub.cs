using CommonClassLibrary.Components;
using InputManagement.Controllers;
using InputManagement.Property;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Input
{
    public partial class pageInsertSubProcecss : UserControl
    {

        ProcessController _processControllers = new ProcessController();
        SubProductController _productSubController = new SubProductController();
        ProductTypeController _productTypeController = new ProductTypeController();
        ProcessController _processController = new ProcessController();
        ProcessSubController _processSubController = new ProcessSubController();

        List<ProcessSubProperty> _listProcess = new List<ProcessSubProperty>();
        List<ProcessSubProperty> _loadProcess;
        ProcessSubProperty _processUpdateStatus;

        frmMain _frmMain;

        public pageInsertSubProcecss(frmMain obj)
        {
            InitializeComponent();
            _frmMain = obj;
        }

        private void pageInsertSubProcecss_Load(object sender, EventArgs e)
        {
            this.SetPage();
            LoadProduct();
        }

        private void SetPage()
        {
            // Insert Process 
            this.rdoInsert.Checked = false;
            this.grpAddprocess.Enabled = false;
            this.txtInsertProcess.Clear();
            this.txtInsertProcess.Enabled = false;
            this.btnAdd.Enabled = false;

            //Update Process
            this.rdoUpdate.Checked = false;
            this.grpUpdate.Enabled = false;
            this.txtUpdate.Clear();
            this.txtUpdate.Enabled = false;
            this.cmbStatus.Items.Clear();
            this.cmbStatus.Enabled = false;
            this.btnUpdate.Enabled = false;


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

        //private void LoadProductType()
        //{
        //    cmbProductType.Items.Clear();
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

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbProduct.Text))
            {

                lstProcess.Items.Clear();
                groupBoxProcess.Enabled = false;
                cmbMainProcess.Items.Clear();
                LoadMainProcess();
            }
        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbProduct.Text))
            {
                LoadMainProcess();
                lstProcess.Items.Clear();
                cmbMainProcess.Enabled = true;
                groupBoxProcess.Enabled = false;
                cmbMainProcess.Focus();
            }
        }

        private void LoadMainProcess()
        {
            cmbMainProcess.Items.Clear();
            ProcessProperty PRODUCT_TYPE = new ProcessProperty()
            {
                PRODUCT_SUB_CODE = (cmbProduct.SelectedItem as ComboboxItem).Value.ToString()
            };

            List<ProcessProperty> listProcessProperty = _processController.SearchProcessByProductSubCode(PRODUCT_TYPE);


            foreach (ProcessProperty data in listProcessProperty.FindAll(x => x.INUSE == "True"))
            {

                ComboboxItem item = new ComboboxItem();
                item.Text = data.PROCESS_NAME;
                item.Value = data.ID;
                cmbMainProcess.Items.Add(item);

            }
        }

        private void cmbMainProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List Process
            this.rdoPrcessAll.Checked = true;
            this.lstProcess.Enabled = false;
            this.LoadProcess();
            this.SearchProcess();
            groupBoxProcess.Enabled = true;
        }

        private void LoadProcess()
        {
            _listProcess = _processSubController.SearchProcessSubByProcessMainId(new ProcessSubProperty { PROCESS_ID = (cmbMainProcess.SelectedItem as ComboboxItem).Value.ToString() });
        }

        private void rdoInsert_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoInsert.Checked)
            {
                this.lstProcess.SelectionMode = SelectionMode.None;
                this.CheckedInsertProcess();
                this.rdoUpdate.Checked = false;
                this.groupBoxProcess.Enabled = true;
            }
        }

        private void rdoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoUpdate.Checked)
            {
                this.lstProcess.SelectionMode = SelectionMode.One;
                this.CheckedUpdateStatusProcess();
                this.rdoInsert.Checked = false;
                this.groupBoxProcess.Enabled = true;
            }
        }

        private void CheckedInsertProcess()
        {
            // Insert Process 
            this.grpAddprocess.Enabled = true;
            this.txtInsertProcess.Clear();
            this.txtInsertProcess.Enabled = true;
            this.btnAdd.Enabled = true;

            //Update Process
            this.grpUpdate.Enabled = false;
            this.txtUpdate.Clear();
            this.txtUpdate.Enabled = false;
            this.cmbStatus.Items.Clear();
            this.cmbStatus.Enabled = false;
            this.btnUpdate.Enabled = false;

            this.lstProcess.Enabled = false;

        }

        private void CheckedUpdateStatusProcess()
        {
            //Update Process
            this.grpUpdate.Enabled = true;
            this.txtUpdate.Clear();
            this.txtUpdate.Enabled = true;
            this.cmbStatus.Items.Clear();
            this.cmbStatus.Items.Add("Use");
            this.cmbStatus.Items.Add("Cancel");
            this.cmbStatus.Enabled = true;
            this.btnUpdate.Enabled = true;

            // Insert Process 
            this.grpAddprocess.Enabled = false;
            this.txtInsertProcess.Clear();
            this.txtInsertProcess.Enabled = false;
            this.btnAdd.Enabled = false;

            this.lstProcess.Enabled = true;
        }

        private void rdoPrcessAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPrcessAll.Checked)
            {
                this.SearchProcess();
            }
        }

        private void rdoProcessInUse_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoProcessInUse.Checked)
            {
                this.SearchProcess();
            }
        }
        private void rdoProcessNonuse_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoProcessNonuse.Checked)
            {
                this.SearchProcess();
            }
        }

        private void SearchProcess()
        {
            this.lstProcess.SelectionMode = SelectionMode.One;

            _loadProcess = new List<ProcessSubProperty>();
            //Get Process Fiberlaser in database(ja_test)
            if (this.rdoProcessInUse.Checked)
            {
                _loadProcess = _listProcess.FindAll(x => x.INUSE == "True");
            }
            else if (this.rdoProcessNonuse.Checked)
            {
                _loadProcess = _listProcess.FindAll(x => x.INUSE == "False");
            }
            else if (this.rdoPrcessAll.Checked)
            {
                _loadProcess = _listProcess;
            }

            lstProcess.Items.Clear();
            foreach (ProcessSubProperty data in _loadProcess)
            {
                ListBoxItem item = new ListBoxItem();
                item.Text = data.SUB_PROCESS_NAME + " (id:" + data.PROCESS_SUB_ID + ")";
                item.Value = data.SUB_PROCESS_NAME;
                lstProcess.Items.Add(item);
            }

            this.lstProcess.SelectionMode = (this.rdoInsert.Checked) ? SelectionMode.None : (this.rdoUpdate.Checked) ? SelectionMode.One : SelectionMode.None;
        }

        private void lstProcess_Click(object sender, EventArgs e)
        {
            if (this.rdoUpdate.Checked)
            {
                if (this.lstProcess.SelectedItem != null)
                {
                    //*********//
                    //this.txtUpdate.Text = _listProcess[this.lstProcess.SelectedIndex].PROCESS_NAME;

                    ////string status = _listProcess[this.lstProcess.SelectedIndex].INUSE == "True" ? "Use" : "Cancel";
                    //int index = this.cmbStatus.FindString(status);
                    //this.cmbStatus.SelectedIndex = index;

                    //_processUpdateStatus = new ProcessProperty()
                    //{
                    //    PROCESS_NAME = _listProcess[this.lstProcess.SelectedIndex].PROCESS_NAME.ToString(),
                    //    INUSE = _listProcess[this.lstProcess.SelectedIndex].INUSE.ToString()
                    //};

                    string title = Convert.ToString(lstProcess.SelectedValue);
                    int indexInList = _listProcess.FindIndex(a => a.SUB_PROCESS_NAME.Contains(title));
                    this.txtUpdate.Text = _listProcess[indexInList].SUB_PROCESS_NAME;

                    string status = (_listProcess[indexInList].INUSE == "True") ? "USE" : "Cancel";
                    this.cmbStatus.SelectedIndex = this.cmbStatus.FindString(status);

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtInsertProcess.Text.Trim() == "")
            {
                MessageBox.Show("Plaease Input Process name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool status = true;
            string processName = this.txtInsertProcess.Text.Trim();

            foreach (ProcessSubProperty _process in _listProcess)
            {
                if (processName == _process.SUB_PROCESS_NAME.Trim())
                {
                    status = false;
                }
            }

            if (status == true)
            {
                ProcessSubProperty _addProcess = new ProcessSubProperty { SUB_PROCESS_NAME = processName, PROCESS_ID = (cmbMainProcess.SelectedItem as ComboboxItem).Value.ToString(), CREATE_USER = _frmMain._empLogin.code };

                //Insert Process.
                if (_processSubController.InsertProcessSub(_addProcess))
                {
                    this.SetPage();
                    //this.ResetInsertProcess();
                    this.LoadProcess();
                    this.SearchProcess();
                    this.groupBoxProcess.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Duplicate Process Sub Name.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtUpdate.Text == "")
            {
                MessageBox.Show("Please Select Process", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (this.cmbStatus.Text == "")
            {
                MessageBox.Show("Please Select Status", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            _processUpdateStatus = new ProcessSubProperty()
            {
                SUB_PROCESS_NAME = this.txtUpdate.Text
                ,
                INUSE = this.cmbStatus.Text
            };

            if (_processUpdateStatus.SUB_PROCESS_NAME == "" || _processUpdateStatus.SUB_PROCESS_NAME == null
                || _processUpdateStatus.INUSE == "" || _processUpdateStatus.INUSE == null)
            {
                MessageBox.Show("Not found Process ", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string oldStatus = _processUpdateStatus.INUSE == "Use" ? "1" : "0";
            string newStatus = this.cmbStatus.Text == "Cancel" ? "1" : "0";

            if (oldStatus == newStatus)
            {
                MessageBox.Show("Current status", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string _textStatus = this.cmbStatus.Text;
            int _indexStatus = this.cmbStatus.FindString(_textStatus);
            if (_indexStatus >= 0)
            {
                _processUpdateStatus.INUSE = this.cmbStatus.Text == "Use" ? "1" : "0";
                _processUpdateStatus.PROCESS_ID = (cmbMainProcess.SelectedItem as ComboboxItem).Value.ToString();
                _processUpdateStatus.LAST_USER = _frmMain._empLogin.code;

                // _currentCondition.EMP = frmMain._empLogin;
                if (_processSubController.UpdateProccessStatus(_processUpdateStatus))
                {
                    this.SetPage();
                    //this.ResetUpdateStatusProcess();
                    this.LoadProcess();
                    this.SearchProcess();

                    this.groupBoxProcess.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Not found Status", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }



        }

    }
}
