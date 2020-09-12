using Input.Controllers;

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
    public partial class frmSearch_SerialProgress : Form
    {
        SearchControllers _controllers = new SearchControllers();
        InputOrderControllers _inputControllers = new InputOrderControllers();
        ProcessControllers _processControllers = new ProcessControllers();

        List<ProcessProperty> _listProcess;
        List<ResultProperty> _listResult;
        SearchSerialProgressProperty _dataSearch;
        DateTime _dtNow;

        public frmSearch_SerialProgress()
        {
            InitializeComponent();
        }

        private void frmSearch_SerialProgress_Load(object sender, EventArgs e)
        {
            _dtNow = _inputControllers.GetDatetimeNow();
            this.Form_Load();
        }

        private void Form_Load()
        {
            this.rtxtSerial.Clear();
            this.lblTotalRow.Text = "Total rows : 0";

            this.dtpDate_Start.Value = _dtNow;
            this.dtpDate_Start.Checked = false;

            this.dtpDate_End.MinDate = _dtNow;
            this.dtpDate_End.Value = _dtNow;
            this.dtpDate_End.Checked = false;
            this.dtpDate_End.Enabled = false;


            this.rdoAll.Checked = true;
            this.rdoCurrent.Checked = false;

            this.GetProcess();
            this.cmbProcess.Text = "";

            this.GetResult();
            this.cmbStatus.Text = "";

            //Cleat filter all.
            this.bindingSourceSerialProgress.Filter = null;
            this.bindingSourceSerialProgress.Sort = null;
            this.advgListSerialProgress.ClearFilter();
            this.advgListSerialProgress.ClearSort();
            this.SearchSerialProgress();
        }

        private void SearchSerialProgress()
        {
            _dataSearch = GetDataSearch();
            this.bindingSourceSerialProgress.DataSource = _controllers.SearchSerialProgress(_dataSearch);
            this.advgListSerialProgress.DataSource = this.bindingSourceSerialProgress;
        }

        private SearchSerialProgressProperty GetDataSearch()
        {
            SearchSerialProgressProperty _result = new SearchSerialProgressProperty();
            _result.SERIAL = new List<string>();

            //## Get Serial.
            if (this.rtxtSerial.Text != "")
            {
                int countSerial = this.rtxtSerial.Lines.Count();
                for (int i = 0; i < countSerial; i++)
                {
                    string _serial = Convert.ToString(this.rtxtSerial.Lines[i]);
                    if (_serial != "")
                    {
                        if (!_result.SERIAL.Contains(_serial))
                        {
                            _result.SERIAL.Add(_serial.Trim());
                        }
                    }
                }
            }

            //## Get Status
            _result.STATUS = new ResultProperty {RESULT = this.cmbStatus.Items.Contains(this.cmbStatus.Text.Trim()) ? this.cmbStatus.Text.Trim() : "" };
            if (_result.STATUS.RESULT == "") { this.cmbStatus.Text = ""; }

            //## Get Process
            _result.PROCESS = new ProcessProperty { PROCESS_NAME = this.cmbProcess.Items.Contains(this.cmbProcess.Text.Trim()) ? this.cmbProcess.Text.Trim() : "" };
            if (_result.PROCESS.PROCESS_NAME == "") { this.cmbProcess.Text = ""; }

            //## Get Type Of Show Progress.
            _result.SELECT_SHOW_CURRENT_PROCESS = this.rdoCurrent.Checked;

            ////## Get FFT_ORDER_ID.
            _result.FFT_ORDER_ID = this.txtFFTOrder.Text.Trim() != "" ? this.txtFFTOrder.Text.Trim() : "";

            //## Get GROUP.
            _result.GROUP = this.txtGroup.Text.Trim() != "" ? this.txtGroup.Text.Trim() : "";
            _result.GROUP = _result.FFT_ORDER_ID != "" ? _result.GROUP : "";

            //## Get INPUT_DATE 
            string dateInput = this.dtpDate_Start.Value.ToString("yyyy-MM-dd");
            _result.INPUT_DATE = this.dtpDate_Start.Checked ? dateInput : "";

            //## Get INPUT_DATE_TO
            string dateInputTo = this.dtpDate_End.Value.ToString("yyyy-MM-dd");
            _result.INPUT_DATE_TO = this.dtpDate_End.Checked ? dateInputTo : "";
            _result.INPUT_DATE_TO = this.dtpDate_Start.Checked ? _result.INPUT_DATE_TO : "";

            return _result;
        }

        private void GetProcess()
        {
            this.cmbProcess.Items.Clear();
            _listProcess = _processControllers.SearchProcessAll();
            foreach (ProcessProperty _process in _listProcess)
            {
                this.cmbProcess.Items.Add(_process.PROCESS_NAME);
            }
        }
        private void GetResult()
        {
            this.cmbStatus.Items.Clear();
            _listResult = _processControllers.SearchResultAll();
            foreach (ResultProperty _result in _listResult)
            {
                this.cmbStatus.Items.Add(_result.RESULT);
            }
        }

        private void advgListSerialProgress_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSourceSerialProgress.Filter = this.advgListSerialProgress.FilterString;
        }

        private void advgListSerialProgress_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSourceSerialProgress.Sort = this.advgListSerialProgress.SortString;
        }

        private void bindingSourceSerialProgress_CurrentChanged(object sender, EventArgs e)
        {
            this.lblTotalRow.Text = "Total rows : " + this.bindingSourceSerialProgress.List.Count;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.SearchSerialProgress();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.Form_Load();
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

        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoAll.Checked)
            {
                this.SearchSerialProgress();
            }
            
        }

        private void rdoCurrent_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoCurrent.Checked)
            {
                this.SearchSerialProgress();
            } 
        }
    }
}
