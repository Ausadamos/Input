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
    public partial class frmSearch_SerialInput : Form
    {
        SearchControllers _controllers = new SearchControllers();
        InputOrderControllers _inputControllers = new InputOrderControllers();
        PurchaseControllers _purchaseControllers = new PurchaseControllers();

        List<PurchaseProperty> _listPurchase;
        SearchSerialInputProperty _dataSearch;
        DateTime _dtNow;
        public frmSearch_SerialInput()
        {
            InitializeComponent();
        }

        private void frmSearch_SerialInput_Load(object sender, EventArgs e)
        {
            _dtNow = _inputControllers.GetDatetimeNow();
            this.Form_Load();
        }

        private void Form_Load()
        {
            this.rtxtSerial.Clear();
            this.lblTotalRow.Text = "Total rows : 0";

            this.dtpInputDate_Start.Value = _dtNow;
            this.dtpInputDate_Start.Checked = false;

            this.dtpInputDate_End.MinDate = _dtNow;
            this.dtpInputDate_End.Value = _dtNow;
            this.dtpInputDate_End.Checked = false;
            this.dtpInputDate_End.Enabled = false;


            this.chkUse.Checked = true;
            this.chkCancel.Checked = true;

            this.txtFFTOrder.Clear();
            this.txtGroup.Clear();

            this.GetPurchase();
            this.cmbPurchase.Text = "";

            //Cleat filter all.
            this.bindingSourceSerialInput.Filter = null;
            this.bindingSourceSerialInput.Sort = null;
            this.advgListSerialInput.ClearFilter();
            this.advgListSerialInput.ClearSort();
            this.SearchSerialInput();
        }

        private void SearchSerialInput()
        {
            _dataSearch = GetDataSearch();
            this.bindingSourceSerialInput.DataSource = _controllers.SearchSerialInput(_dataSearch);
            this.advgListSerialInput.DataSource = this.bindingSourceSerialInput;
        }

        private SearchSerialInputProperty GetDataSearch()
        {
            SearchSerialInputProperty _result = new SearchSerialInputProperty();
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

            //## Get Purchase.
            _result.PURCHASE = this.cmbPurchase.Items.Contains(this.cmbPurchase.Text.Trim()) ? this.cmbPurchase.Text.Trim() : "";
            if (_result.PURCHASE == "") {this.cmbPurchase.Text = ""; }

            //## Get FFT_ORDER_ID.
            _result.FFT_ORDER_ID = this.txtFFTOrder.Text.Trim() != "" ? this.txtFFTOrder.Text.Trim() : "";

            //## Get GROUP.
            _result.GROUP = this.txtGroup.Text.Trim() != "" ? this.txtGroup.Text.Trim() : "";
            _result.GROUP = this.txtFFTOrder.Text.Trim() != "" ? _result.GROUP : "";

            //## Get INUSE 
            _result.INUSE = this.chkUse.Checked && !this.chkCancel.Checked ? "1" : "0";
            _result.INUSE = this.chkUse.Checked && this.chkCancel.Checked  ? "" : _result.INUSE;
            _result.INUSE = !this.chkUse.Checked && !this.chkCancel.Checked ? "" : _result.INUSE;

            //## Get INPUT_DATE 
            string dateInput = this.dtpInputDate_Start.Value.ToString("yyyy-MM-dd");
            _result.INPUT_DATE = this.dtpInputDate_Start.Checked ? dateInput : "";

            //## Get INPUT_DATE_TO
            string dateInputTo = this.dtpInputDate_End.Value.ToString("yyyy-MM-dd");
            _result.INPUT_DATE_TO = this.dtpInputDate_End.Checked ? dateInputTo : "";
            _result.INPUT_DATE_TO = this.dtpInputDate_Start.Checked ? _result.INPUT_DATE_TO : "";

            return _result;
        }

        private void GetPurchase()
        {
            this.cmbPurchase.Items.Clear();
             _listPurchase = _purchaseControllers.ListPurchasesAll();
            foreach (PurchaseProperty _purchase in _listPurchase)
            {
                this.cmbPurchase.Items.Add(_purchase.PURCHASE_NO);
            }
        }

        private void bindingSourceSerialInput_CurrentChanged(object sender, EventArgs e)
        {
            this.lblTotalRow.Text = "Total rows : " + this.bindingSourceSerialInput.List.Count;
        }

        private void advgListSerialInput_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSourceSerialInput.Filter = this.advgListSerialInput.FilterString;
        }

        private void advgListSerialInput_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSourceSerialInput.Sort = this.advgListSerialInput.SortString;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.SearchSerialInput();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {

            this.Form_Load();
        }

        private void dtpInputDate_Start_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpInputDate_Start.Checked)
            {
                this.dtpInputDate_End.Enabled = true;


                if (this.dtpInputDate_End.Checked)
                {
                    this.dtpInputDate_End.MinDate = this.dtpInputDate_Start.Value.AddDays(1);
                    this.dtpInputDate_End.Value = this.dtpInputDate_Start.Value.AddDays(1);
                }
                else
                {
                    this.dtpInputDate_End.MinDate = this.dtpInputDate_Start.Value.AddDays(1);
                    this.dtpInputDate_End.Value = this.dtpInputDate_Start.Value.AddDays(1);
                    this.dtpInputDate_End.Checked = false;
                }
            }
            else
            {
                this.dtpInputDate_End.MinDate = this.dtpInputDate_Start.Value.AddDays(1);
                this.dtpInputDate_End.Value = this.dtpInputDate_Start.Value.AddDays(1);
                this.dtpInputDate_End.Checked = false;
                this.dtpInputDate_End.Enabled = false;
            }
        }

    }
}
