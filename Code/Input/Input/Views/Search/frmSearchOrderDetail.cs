using InputManagement.Controllers;
using InputManagement.Property;
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
    public partial class frmSearchOrderDetail : Form
    {
        SearchControllers _controllers = new SearchControllers();
        InputOrderControllers _inputControllers = new InputOrderControllers();

        SearchOrderDetailProperty search = new SearchOrderDetailProperty();
        DateTime _dtNow;

        public frmSearchOrderDetail()
        {
            InitializeComponent();
        }
        private void frmSearchOrderDetail_Load(object sender, EventArgs e)
        {
            _dtNow = _inputControllers.GetDatetimeNow();
            this.SetPage();

            btnSearch_Click(this, null);
        }
        private void SetPage()
        {
            this.lblTotalRow.Text = "Total rows : 0";

            this.dtpDate_Start.Value = _dtNow;
            this.dtpDate_Start.Checked = false;

            this.dtpDate_End.MinDate = _dtNow;
            this.dtpDate_End.Value = _dtNow;
            this.dtpDate_End.Checked = false;
            this.dtpDate_End.Enabled = false;

            this.rtxtFFTOrder.Text = "";
            this.txtProductSub.Text = "";
            this.txtCustomer.Text = "";
            this.bindingSourceData.Sort = null;
            this.bindingSourceData.Filter = null;

            this.chkThisYear.Checked = true;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            search = new SearchOrderDetailProperty
            {
                FFT_ORDER_ID = new List<string>(),
                CUSTOMER_NAME = (this.txtCustomer.Text != "") ? this.txtCustomer.Text : "",
                PRODUCT_SUB_NAME = (this.txtProductSub.Text != "") ? this.txtProductSub.Text : "",
                INPUT_DATE = (this.dtpDate_Start.Checked) ? Convert.ToString(dtpDate_Start.Value.ToString("yyyy-MM-dd")) : "",
                INPUT_DATE_TO = (this.dtpDate_End.Checked) ? Convert.ToString(dtpDate_End.Value.ToString("yyyy-MM-dd")) : "",
                THIS_YEAR = this.chkThisYear.Checked
            };
            foreach (string _doc in rtxtFFTOrder.Lines)
            {
                //check dupiclate
                if (!search.FFT_ORDER_ID.Contains(_doc))
                {
                    search.FFT_ORDER_ID.Add(_doc.Trim());
                }
            }
            this.bindingSourceData.DataSource = _controllers.SearchOrderDetail(search);
            this.advgDataProcess.DataSource = this.bindingSourceData;
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.SetPage();
        }
        private void bindingSourceData_CurrentChanged(object sender, EventArgs e)
        {
            this.lblTotalRow.Text = "Total rows : " + this.bindingSourceData.List.Count;
        }
        private void advgDataProcess_FilterStringChanged(object sender, EventArgs e)
        {
            bindingSourceData.Filter = advgDataProcess.FilterString;
        }
        private void advgDataProcess_SortStringChanged(object sender, EventArgs e)
        {
            bindingSourceData.Sort = advgDataProcess.SortString;
        }

        private void dtpDate_Start_ValueChanged(object sender, EventArgs e)
        {

            if (this.dtpDate_Start.Checked)
            {
                this.dtpDate_End.Enabled = true;


                if (this.dtpDate_End.Checked)
                {
                    this.dtpDate_End.MinDate = this.dtpDate_Start.Value.AddDays(1);
                    this.dtpDate_End.Value = this.dtpDate_Start.Value.AddDays(1);
                }
                else
                {
                    this.dtpDate_End.MinDate = this.dtpDate_Start.Value.AddDays(1);
                    this.dtpDate_End.Value = this.dtpDate_Start.Value.AddDays(1);
                    this.dtpDate_End.Checked = false;
                }
            }
            else
            {
                this.dtpDate_End.MinDate = this.dtpDate_Start.Value.AddDays(1);
                this.dtpDate_End.Value = this.dtpDate_Start.Value.AddDays(1);
                this.dtpDate_End.Checked = false;
                this.dtpDate_End.Enabled = false;
            }
        }
    }
}
