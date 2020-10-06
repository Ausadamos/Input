using InputManagement.Property;
using InputManagement.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Input
{
    public partial class frmInput_History : Form
    {
        InputOrderControllers _controllers = new InputOrderControllers();
        frmMain _frmMain;

        public frmInput_History(frmMain obj)
        {
            InitializeComponent();
            _frmMain = obj;
        }

        private void frmInput_History_Load(object sender, EventArgs e)
        {

            //_frmMain._order.CONDITION = new ConditionProperty();
            SearchOrder();
        }
        private void SearchOrder()
        {
            //get order to bindingSource.
            this.bindingSourceHistory.DataSource = _controllers.GetQtyHistoryAll(_frmMain._order);
            this.adgvHistory.DataSource = this.bindingSourceHistory;
        }

        private void adgvHistory_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSourceHistory.Filter = this.adgvHistory.FilterString;
        }

        private void adgvHistory_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSourceHistory.Sort = this.adgvHistory.SortString;
        }

        private void bindingSourceHistory_CurrentChanged(object sender, EventArgs e)
        {
            this.lblTotalRow.Text = "Total rows : " + this.bindingSourceHistory.List.Count;
        }
    }
}
