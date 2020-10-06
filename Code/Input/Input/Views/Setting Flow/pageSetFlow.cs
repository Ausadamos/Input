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
    public partial class pageSetFlow : UserControl
    {

        FlowControllers _controller = new FlowControllers();
        frmMain _frmMain;

        public pageSetFlow(frmMain obj)
        {
            InitializeComponent();
            _frmMain = obj;
        }

        private void pageSetFlow_1_Load(object sender, EventArgs e)
        {
            this.LoadFlowAll();
        }

        private void LoadFlowAll()
        {
            //get order to bindingSource.
            this.bindingSourceFlowAll.DataSource = _controller.LoadFlowAll();
            this.advgListFlow.DataSource = this.bindingSourceFlowAll;
        }

        private void advgListFlow_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSourceFlowAll.Filter = this.advgListFlow.FilterString;
        }

        private void advgListFlow_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSourceFlowAll.Sort = this.advgListFlow.SortString;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            _frmMain.Set_HeadLine(_frmMain.lblHeader.Text + " > Create Flow");

            this.Load_pageCreateFlow();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _frmMain.Set_HeadLine(_frmMain.lblHeader.Text + " > Update Flow");

            Load_pageUpdateFlow();
        }
        private void Load_pageCreateFlow()
        {
            //Clear Panel Body
            _frmMain.panBody.Controls.Clear();
           
            //Load page create flow 
            pageCreateFlow _pageCreateFlow = new pageCreateFlow(_frmMain);
            _frmMain.panBody.Controls.Add(_pageCreateFlow);
            _pageCreateFlow.Dock = DockStyle.Fill;
            _pageCreateFlow.BringToFront();

        }
        private void Load_pageUpdateFlow()
        {
            //Clear Panel Body
            _frmMain.panBody.Controls.Clear();

            //Load page create flow 
            pageUpdateFlow _updateFlow = new pageUpdateFlow(_frmMain);
            _frmMain.panBody.Controls.Add(_updateFlow);
            _updateFlow.Dock = DockStyle.Fill;
            _updateFlow.BringToFront();
        }

        private void bindingSourceFlowAll_CurrentChanged(object sender, EventArgs e)
        {
            this.lblTotalRow.Text = "Total rows : " + this.bindingSourceFlowAll.List.Count;
        }




    }
}
