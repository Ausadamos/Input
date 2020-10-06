using BusinessData.Property;
using FiberLaserProcessManagement;
using InputManagement.Controllers;
using InputManagement.Property;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Input
{
    public partial class frmSearchDataDetailInProcess : Form
    {
        Cls_FiberLaserProcessManagement fiberlaserManagement = new Cls_FiberLaserProcessManagement();
        InputOrderControllers _inputControllers = new InputOrderControllers();
        SearchDetailProperty search = new SearchDetailProperty();
        string processID;
        DataTable resultData;
        DateTime _dtNow;
        string whereDefault;
        public frmSearchDataDetailInProcess(string obj, Image _imageProcess)
        {
            InitializeComponent();
            picProcess.Image = _imageProcess;
            processID = obj;
        }
        private void frmSearchDataDetailInProcess_Load(object sender, EventArgs e)
        {
            _dtNow = _inputControllers.GetDatetimeNow();
            this.chkThisYear.Checked = true;
            this.chkFinalResult.Checked = true;
            this.chkFinalResult_OnChange(this, null);

            this.rtxtSerial.Text = "";
            this.txtFFTOrder.Text = "";
            this.txtGroup.Text = "";
            this.dtpDate_Start.Checked = false;
            this.dtpDate_End.Checked = false;

            bindingSourceData.Sort = null;
            bindingSourceData.Filter = null;

        }
        private void LoadData()
        {

        }
        private void manageData()
        {
            //orderPage = (resultData.Rows.Count % separatePage) > 0 ? (resultData.Rows.Count / separatePage) + 1 : (resultData.Rows.Count / separatePage);
            //List<DataTable> listPageData = new List<DataTable>();
            //int j = 1;
            //DataTable _dataTable = new DataTable();
            //foreach (DataRow item in resultData.Rows)
            //{
            //    item = _dataTable.NewRow();
            //    _dataTable.Add(item);
            //    if (_dataTable.Rows.Count % separatePage == 0)
            //    {
            //        listPageData.Add(_dataTable);
            //        _dataTable.Rows.Clear();
            //    }
            //}
            //if (_dataTable.Rows.Count > 0)
            //{
            //    listPageData.Add(_dataTable);
            //    _dataTable.Rows.Clear();
            //}
            //this.lblPageOf.Text = "1 / " + orderPage;
        }

        private void chkFinalResult_OnChange(object sender, EventArgs e)
        {
            //if (chkFinalResult.Checked)
            //{
            //    this.bindingSourceData.DataSource = resultData.Select("STATUS = 'Use'").CopyToDataTable();
            //    this.advgDataProcess.DataSource = this.bindingSourceData;
            //}
            //else
            //{
            //    this.bindingSourceData.DataSource = resultData;
            //    this.advgDataProcess.DataSource = this.bindingSourceData;
            //}
            //var _columnVis_ID = advgDataProcess.Columns["STATUS"];
            //if (_columnVis_ID != null && _columnVis_ID.Visible)
            //{
            //    advgDataProcess.Columns["STATUS"].Visible = false;
            //}
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.WhereData();
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.rtxtSerial.Text = "";
            this.txtFFTOrder.Text = "";
            this.txtGroup.Text = "";
            this.dtpDate_Start.Checked = false;
            this.dtpDate_End.Checked = false;
            bindingSourceData.DataSource = null;
            bindingSourceData.Filter = null;
            this.WhereData();
        }
        private void WhereData()
        {
            search = new SearchDetailProperty
            {
                SERIAL_MODULE = new List<string>(),
                FFT_ORDER_ID = txtFFTOrder.Text,
                GROUP = txtGroup.Text,
                INPUT_DATE = (this.dtpDate_Start.Checked) ? Convert.ToString(dtpDate_Start.Value.ToString("yyyy-MM-dd")) : "",
                INPUT_DATE_TO = (this.dtpDate_End.Checked) ? Convert.ToString(dtpDate_End.Value.ToString("yyyy-MM-dd")) : ""
            };
            foreach (string _doc in rtxtSerial.Lines)
            {
                //check dupiclate
                if (!search.SERIAL_MODULE.Contains(_doc))
                {
                    search.SERIAL_MODULE.Add(_doc.Trim());
                }
            }

            string where = "";
            //## WHERE Serial.
            string whereSerial = "";
            foreach (string _serial in search.SERIAL_MODULE)
            {
                if (_serial.Trim() != "")
                {
                    if (whereSerial == "") { whereSerial = "''" + _serial + "''"; }
                    else { whereSerial += ",''" + _serial + "''"; }
                }
            }

            if (whereSerial != "")
            {
                whereSerial = @" tb2.SERIAL IN (" + whereSerial + @") ";
                where = whereSerial;
            }

            //## WHERE FFT_ORDER
            if (search.FFT_ORDER_ID != "")
            {
                string whereOrder = "";
                if (where != "")
                {
                    whereOrder = @"AND tb1.FFT_ORDER_ID =  ''" + search.FFT_ORDER_ID + @"'' ";

                    where += whereOrder;
                }
                else
                {
                    whereOrder = @" tb1.FFT_ORDER_ID = ''" + search.FFT_ORDER_ID + @"''   ";

                    where = whereOrder;
                }
            }

            //## WHERE DATE/TO
            if (search.INPUT_DATE != "" && search.INPUT_DATE_TO != "")
            {
                string whereInputDate = "";
                if (where != "")
                {
                    whereInputDate = @"AND tb1.CREATE_DATE >=  ''" + search.INPUT_DATE + @"'' 
                    AND  tb1.CREATE_DATE <= ''" + search.INPUT_DATE_TO + "%" + "'' ";

                    where += whereInputDate;
                }
                else
                {
                    whereInputDate = @" tb1.CREATE_DATE >= ''" + search.INPUT_DATE + @"''  
                    AND  tb1.CREATE_DATE <= ''" + search.INPUT_DATE_TO + "%" + "''";

                    where = whereInputDate;
                }
            }
            //## WHERE DATE
            else if (search.INPUT_DATE != "" && search.INPUT_DATE_TO == "")
            {
                string whereInputDate = "";
                if (where != "")
                {
                    whereInputDate = @" AND tb1.CREATE_DATE LIKE ''" + search.INPUT_DATE + "%" + @"'' ";

                    where += whereInputDate;
                }
                else
                {
                    whereInputDate = @" tb1.CREATE_DATE LIKE ''" + search.INPUT_DATE + "%" + @"'' ";

                    where = whereInputDate;
                }
            }
            if (this.chkThisYear.Checked)
            {
                string whereThisYear = "";
                if (where != "")
                {
                    whereThisYear = @" AND YEAR(tb1.CREATE_DATE) = YEAR(NOW()) ";

                    where += whereThisYear;
                }
                else
                {
                    whereThisYear = @" YEAR(tb1.CREATE_DATE) = YEAR(NOW()) ";

                    where = whereThisYear;
                }
            }
            if (this.chkFinalResult.Checked)
            {
                string whereFinalResult = "";
                if (where != "")
                {
                    whereFinalResult = @" AND tb1.INUSE = ""1"" ";

                    where += whereFinalResult;
                }
                else
                {
                    whereFinalResult = @" tb1.INUSE = ""1"" ";

                    where = whereFinalResult;
                }
            }

            where = (where == "") ? "" : "WHERE " + where;
            OutputOnDbProperty resultData = new OutputOnDbProperty();
            resultData = fiberlaserManagement.SearchDataDetailInProcess(processID, where);
            if (!resultData.StatusOnDb) { MessageBox.Show(resultData.MessageOnDb, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            this.bindingSourceData.DataSource = resultData.ResultOnDb;
            advgDataProcess.DataSource = bindingSourceData;
        }
        private void bindingSourceData_CurrentChanged(object sender, EventArgs e)
        {
            this.lblTotalRow.Text = "Total rows : " + this.bindingSourceData.List.Count;
        }

        private void advgDataProcess_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSourceData.Sort = this.advgDataProcess.SortString;
        }

        private void advgDataProcess_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSourceData.Filter = this.advgDataProcess.FilterString;
        }


    }
}
