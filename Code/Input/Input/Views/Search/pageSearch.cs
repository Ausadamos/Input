using FiberLaserProcessManagement;
using FiberLaserProcessManagement.Property;
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
using System.Linq.Expressions;
using Input.Properties;
using System.Diagnostics;

namespace Input
{
    public partial class pageSearch : UserControl
    {
        bool searchStatus;

        private bool menubar = false;
        frmMain _frmMain;

        public pageSearch(frmMain obj)
        {
            InitializeComponent();
            _frmMain = obj;
        }

        public bool IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Name == formType.Name)
                {
                    form.BringToFront();
                    return true;
                }
            }
            return false;
        }

        private void pageSearch_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchDataDetail_Click(object sender, EventArgs e)
        {
            this.SearchDataDetail();
        }
        private void SearchDataDetail()
        {
            this.tmrSearchDetail.Start();
        }

        private void tmrSearchDetail_Tick(object sender, EventArgs e)
        {
            if (!menubar)
            {
                this.pnlSearchDataDetial.Width += 20;
                if (this.pnlSearchDataDetial.Width == 380)
                {
                    this.tmrSearchDetail.Stop();
                    menubar = true;

                }
            }
            else if (menubar)
            {
                this.pnlSearchDataDetial.Width -= 20;
                if (this.pnlSearchDataDetial.Width == 0)
                {
                    this.tmrSearchDetail.Stop();
                    menubar = false;
                }
            }
        }

        private void SearchProcess(object sender, EventArgs e)
        {
            var obj = (Bunifu.Framework.UI.BunifuThinButton2)sender;
            string processID = obj.Tag.ToString();
            if (processID == "5" || processID == "6" || processID == "7" || processID == "10" || processID == "11" || processID == "12")
            {
                MessageBox.Show("          Not available          "+Environment.NewLine,"Stop",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            //OutputOnDbProperty resultData = new OutputOnDbProperty();
            //resultData = fiberlaserManagement.SearchDataDetailInProcess(processID, searchStatus);
            //if (!resultData.StatusOnDb) { MessageBox.Show(resultData.MessageOnDb, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            // Open form search
            if (!IsFormOpen(typeof(frmSearchDataDetailInProcess)))
            {
                frmSearchDataDetailInProcess frmSearchProcessDetail = new frmSearchDataDetailInProcess(processID, SelectImageProcess(processID));
                frmSearchProcessDetail.Show();
            }
        }

        private Image SelectImageProcess(string processID)
        {
            Image result = null;

            switch (processID)
            {
                case "1": // ID 1 is Receiving Inspection
                    result = null;
                    break;
                case "2": // ID 2 is Yb Cutting
                    result = null;
                    break;
                case "3": // ID 3 is Process Fiber On Plate
                    result = Resources.Header_FiberOnPlate;
                    break;
                case "4": // ID 4 is Process Resonator Assembling 
                    result = Resources.Header_ResonatorAssembling;
                    break;
                case "5": // ID 5 is Process Resonator Test
                    result = Resources.Header_ResonatorTest;
                    break;
                case "6": // ID 6 is Process TFB Assembling
                    result = Resources.Header_TFBAssembling;
                    break;
                case "7": // ID 7 is Process Thermal Screening
                    result = Resources.Header_ThermalScreening;
                    break;
                case "8": // ID 8 is Process PD/Thermistor Assembling
                    result = Resources.Header_PDThermistor;
                    break;
                case "9": // ID 9 is Process Curing
                    result = Resources.Header_Curing;
                    break;
                case "10": // ID 10 is Burn-In
                    result = Resources.Header_BurIn;
                    break;
                case "11": // ID 11 is Final Assembling
                    result = Resources.Header_FinalAssembling;
                    break;
                case "12": // ID 12 is Packing
                    result = Resources.Header_Packing;
                    break;
            }
            return result; 
        }

        private void btnSearchSerial_Click(object sender, EventArgs e)
        {
            menubar = true;
            this.tmrSearchDetail.Start();
            if (!IsFormOpen(typeof(frmSearch_SerialInput)))
            {
                frmSearch_SerialInput _frmSearch_SerialInput = new frmSearch_SerialInput();
                _frmSearch_SerialInput.Show();
            }
        }

        private void btnSearchProgress_Click(object sender, EventArgs e)
        {
            menubar = true;
            this.tmrSearchDetail.Start();
            if (!IsFormOpen(typeof(frmSearch_SerialProgress)))
            {
                frmSearch_SerialProgress _frmSearch_SerialProgress = new frmSearch_SerialProgress();
                _frmSearch_SerialProgress.Show();
            }
        }

        private void btnSearchPurchase_Click(object sender, EventArgs e)
        {
            menubar = true;
            this.tmrSearchDetail.Start();
            if (!IsFormOpen(typeof(frmSearchPurchase)))
            {
                frmSearchPurchase _frmSearch_Purchase = new frmSearchPurchase();
                _frmSearch_Purchase.Show();
            }
        }

        private void btnSearchFlow_Click(object sender, EventArgs e)
        {
            menubar = true;
            this.tmrSearchDetail.Start();
            if (!IsFormOpen(typeof(frmSearchFlows)))
            {
                frmSearchFlows _frmSearch_Flow = new frmSearchFlows();
                _frmSearch_Flow.Show();
            }
        }

        private void btnSearchOrderGroup_Click(object sender, EventArgs e)
        {
            menubar = true;
            this.tmrSearchDetail.Start();
            if (!IsFormOpen(typeof(frmSearchOrderDetail)))
            {
                frmSearchOrderDetail _frmSearch_Orderdetail = new frmSearchOrderDetail();
                _frmSearch_Orderdetail.Show();
            }
        }


    }
}