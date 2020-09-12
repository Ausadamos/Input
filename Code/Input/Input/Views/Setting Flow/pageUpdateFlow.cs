using Input.Controllers;
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
    public partial class pageUpdateFlow : UserControl
    {
        FlowControllers _controller = new FlowControllers();
        List<ProcessProperty> _listprocess = new List<ProcessProperty>();
        FlowProperty _flow;
        frmMain _frmMain;
        string _defaultFlowName = "- - - - - -";

        public pageUpdateFlow(frmMain obj)
        {
            InitializeComponent();
            _frmMain = obj;
        }

        private void pageUpdateFlow_Load(object sender, EventArgs e)
        {
            this.PageLoad();
        }
        private void PageLoad()
        {
            this.cmbStatus.Items.Clear();
            this.lblFlowName.Text = "- - - - - -";

            this.cmbStatus.Items.Add("- - - - -");
            this.cmbStatus.SelectedIndex = 0;

            this.LoadFlowAll();
        }
        private void LoadFlowAll()
        {
            //Get Flow Fiberlaser in database(ja_test)
            //get order to bindingSource.
            this.bindingSourceFlow.DataSource = _controller.LoadFlowAll();
            this.dgvFlow.DataSource = this.bindingSourceFlow;

        }
        private void dgvFlow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    this.cmbStatus.Items.Clear();
                    this.cmbStatus.Items.Add("Use");
                    this.cmbStatus.Items.Add("Cancel");
                    if (this.dgvFlow.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        this.dgvFlow.CurrentRow.Selected = true;

                        //Get FlowProperty
                        //This Column in "adgvCondition" is visible.
                        _flow = new FlowProperty
                        {
                            FLOW_NAME = this.dgvFlow.Rows[e.RowIndex].Cells["FLOW_NAME"].FormattedValue.ToString(),
                            STATUS = this.dgvFlow.Rows[e.RowIndex].Cells["STATUS"].FormattedValue.ToString()
                        };

                        this.lblFlowName.Text = _flow.FLOW_NAME;
                        this.cmbStatus.Text = _flow.STATUS;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if(this.lblFlowName.Text == _defaultFlowName)
            {
                MessageBox.Show("Please Select Flow", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (this.cmbStatus.Text == "")
            {
                MessageBox.Show("Please Select Status Flow", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
            if (this.cmbStatus.Text != _flow.STATUS)
            {
                if (_flow.FLOW_NAME != "" || _flow.FLOW_NAME != null
                   || _flow.STATUS != "" || _flow.STATUS != null)
                {
                    string _textStatus = this.cmbStatus.Text;
                    int _indexStatus = this.cmbStatus.FindString(_textStatus);
                    if (_indexStatus >= 0)
                    {
                        _flow.INUSE = this.cmbStatus.Text == "Use" ? "1" : "0";
                        _controller.UpdateStatus(_flow);
                    }
                    this.PageLoad();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _frmMain.Load_SetFlow();
        }

        private void bindingSourceFlow_CurrentChanged(object sender, EventArgs e)
        {
            this.lblTotalRow.Text = "Total rows : " + this.bindingSourceFlow.List.Count;
        }

        private void dgvFlow_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSourceFlow.Filter = this.dgvFlow.FilterString;
        }

        private void dgvFlow_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSourceFlow.Sort = this.dgvFlow.SortString;
        }

       
    }
}
