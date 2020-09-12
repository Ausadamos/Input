using Input.Controllers;
using System.IO;
using InputManagement.Property;

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
    public partial class pageUpdateProcessCard : UserControl
    {
        PurchaseControllers _controllers = new PurchaseControllers();
        FlowControllers _flowControllers = new FlowControllers();
        PurchaseProperty _updatePurchase;
        List<FlowProperty> _listflow; 
        PurchaseProperty _updateOrder;
        frmMain _frmMain;
        FlowProperty _flow;
        string defaultlblPurchase = " ----- ";
        public pageUpdateProcessCard(frmMain obj , PurchaseProperty obj2)
        {
            InitializeComponent();
            _frmMain = obj;
            _updateOrder = obj2;
        }

        private void pageUpdatePurchase_Load(object sender, EventArgs e)
        {
            this.LoadPurchaseAll();
            this.SetFolw();
        }

        private void LoadPurchaseAll()
        {
            //this.lblPurchase.Text = defaultlblPurchase;
            //this.lblShowFileName.Text = defaultlblPurchase;
            //this.txtPathProcessCard.Clear();
            //this.bindingSourcePurcAll.DataSource = _controllers.LoadPurchaseAll();
            //this.advgListPurchase.DataSource = this.bindingSourcePurcAll;

            //// Check and visible columns["ID"].
            //var _columnVis_ID = advgListPurchase.Columns["ID"];
            //if (_columnVis_ID != null && _columnVis_ID.Visible)
            //{ advgListPurchase.Columns["ID"].Visible = false; }

            this.lblPurchase.Text = _updateOrder.PURCHASE_NO;
            this.lblFFTCode.Text = _updateOrder.FFT_CODE;
            this.txtFlow.Text = _updateOrder.FLOW.FLOW_NAME;
            this.lblPART_NO.Text = _updateOrder.PART_NO;
            this.lblModelNO.Text = _updateOrder.MODEL;
            this.lblProductName.Text = _updateOrder.PRODUCT_PURCHASE;
            this.lblShowFileName.Text = _updateOrder.PATH_PROCESS_CARD == "N/A" ? defaultlblPurchase : Path.GetFileName(_updateOrder.PATH_PROCESS_CARD);
            this.txtPathProcessCard.Text = _updateOrder.PATH_PROCESS_CARD;

            //Set new Property
            _updatePurchase = new PurchaseProperty();
        }
        private void SetFolw()
        {
            _listflow = new List<FlowProperty>();
            _listflow = _flowControllers.LoadFlow();
            this.cmbFlow.Items.Clear();
            this.cmbFlow.Items.Add("-Select Flow-");
            foreach (FlowProperty _flow in _listflow)
            {
                this.cmbFlow.Items.Add(_flow.FLOW_NAME);
            }

            if (cmbFlow.FindString(this.txtFlow.Text) != -1)
            {
                this.cmbFlow.SelectedItem = this.txtFlow.Text;
            }
            else
            {
                this.cmbFlow.SelectedIndex = 0;
            }


        }

        private void dgvFlow_FilterStringChanged(object sender, EventArgs e)
        {
            //this.bindingSourcePurcAll.Filter = this.advgListPurchase.FilterString;
        }

        private void bindingSourcePurcAll_CurrentChanged(object sender, EventArgs e)
        {
           //this.lblTotalRow.Text = "Total rows : " + this.bindingSourcePurcAll.List.Count;
        }

        private void dgvFlow_SortStringChanged(object sender, EventArgs e)
        {
           // this.bindingSourcePurcAll.Sort = this.advgListPurchase.SortString;
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

        private void advgListPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //    {
            //        if (this.advgListPurchase.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //        {
            //            //get data for update path processcard
            //            _updatePurchase = new PurchaseProperty
            //            {
            //                PURCHASE_NO = this.advgListPurchase.Rows[e.RowIndex].Cells["DOCUMENT_NO"].FormattedValue.ToString(),
            //                FFT_CODE = this.advgListPurchase.Rows[e.RowIndex].Cells["FFT_CODE"].FormattedValue.ToString(),
            //                PART_NO = this.advgListPurchase.Rows[e.RowIndex].Cells["PART_NO"].FormattedValue.ToString(),
            //                PRODUCT_PURCHASE = this.advgListPurchase.Rows[e.RowIndex].Cells["PRODUCT_NAME"].FormattedValue.ToString(),
            //                MODEL = this.advgListPurchase.Rows[e.RowIndex].Cells["MODEL_NO"].FormattedValue.ToString(),
            //                PATH_PROCESS_CARD = this.advgListPurchase.Rows[e.RowIndex].Cells["PATH_PROCESS_CARD"].FormattedValue.ToString()
            //            };

            //            this.lblPurchase.Text = _updatePurchase.PURCHASE_NO;
            //            this.txtPathProcessCard.Text = _updatePurchase.PATH_PROCESS_CARD;
            //            this.lblShowFileName.Text = _updatePurchase.PATH_PROCESS_CARD == "N/A" ? defaultlblPurchase : Path.GetFileName(_updatePurchase.PATH_PROCESS_CARD);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = _listflow.FindIndex(x => x.FLOW_NAME == this.txtFlow.Text);
            _updateOrder.FLOW.FLOW_NAME = _listflow[index].FLOW_NAME;
            _updateOrder.FLOW.ID = _listflow[index].ID;
            _updateOrder.EMP = _frmMain._empLogin;

            if (_updateOrder.PURCHASE_NO != "" && _updateOrder.PURCHASE_NO != null)
            {
                if (this.txtPathProcessCard.Text != "")
                {
                    _updateOrder.PATH_PROCESS_CARD = this.txtPathProcessCard.Text.Replace(@"\", @"\\");
                    if (_controllers.UpdateProcessCardPurchase(_updateOrder))
                    {
                        this.LoadPurchaseAll();
                    }

                }
                else { MessageBox.Show("Please Choose file Processcaed ", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
            }
            else
            { MessageBox.Show("Please Select Purchase", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);}
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _frmMain.Load_SetPurchase();
        }

        private void cmbFlow_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstProcess.Items.Clear();
            if (this.cmbFlow.SelectedIndex == 0)
            {
                this.txtFlow.Text = _updateOrder.FLOW.FLOW_NAME;
                return;
            }
            else
            {
                this.txtFlow.Text = this.cmbFlow.SelectedItem.ToString();  
            }
            
            int no = 1;
            // if cmb purchase == "" & cmb flow != ""
            // Query by Flow name  , get process
            // Load process in list process (2.2)
            if (this.cmbFlow.Text != "")
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
    }
}
