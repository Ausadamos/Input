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
    public partial class pageTest : UserControl
    {
        string oldHeader;

        frmMain _frmMain;

        pageTestInitial _pageTestInitial;
        pageTestManufacturing _pageTestManufacturing;

        public pageTest(frmMain obj)
        {
            InitializeComponent();
            _frmMain = obj;
            oldHeader = _frmMain.lblHeader.Text;
        }

        private void pageTest_Load(object sender, EventArgs e)
        {
            _pageTestInitial = new pageTestInitial(_frmMain,this);
            _pageTestManufacturing = new pageTestManufacturing(_frmMain);

            this.rdoTestInitial.Checked = true;
        }

        private void rdoTestInitial_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoTestInitial.Checked)
            {
                if (_pageTestManufacturing._listInputTestManufacturing.Count() > 0)
                {
                    DialogResult result = MessageBox.Show("Data not Save." + "\n" + "Do you want to go to the RMA-Innitial page Yes or No?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        this.Load_PageTestInitial();
                    }
                    else
                    {
                        this.rdoTestInitial.Checked = true;
                    }
                }
                else
                {
                    bool isOpen = false;
                    foreach (Control ctrl in this.panBodyTest.Controls)
                    {
                        if (ctrl.Name == "pageTestInitial")
                        {isOpen = true;}
                    }
                    if (!isOpen)
                    {
                        this.Load_PageTestInitial();
                    }
                }
            }
        }

        private void rdoTestManufac_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoTestManufac.Checked)
            {
                //Check Action On Page TestInitial before change.
                if (_pageTestInitial.rdo1Day.Checked || _pageTestInitial.rdoMore1Day.Checked || _pageTestInitial.cmbSelect_PurchaseNo.FindString(_pageTestInitial.cmbSelect_PurchaseNo.Text) > 0 || _pageTestInitial._listOrderInput.Count() > 0)
                {
                    DialogResult result = MessageBox.Show("Data not Save." + "\n" + "Do you want to go to the Test-Manufacturing page Yes or No?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        this.Load_PageTestManufacturing();
                    }
                    else
                    {
                        this.rdoTestInitial.Checked = true;
                    }
                }
                else
                {
                    bool isOpen = false;
                    foreach (Control ctrl in this.panBodyTest.Controls)
                    {
                        if (ctrl.Name == "pageTestManufacturing")
                        {isOpen = true;}
                    }
                    if (!isOpen)
                    {
                        this.Load_PageTestManufacturing();
                    }
                } 
            }
        }

        public void Load_PageTestInitial()
        {
            //default page//set HeadLine
            _frmMain.Set_HeadLine(oldHeader + " > Teset Initial");

            //Clear Panel Body
            this.panBodyTest.Controls.Clear();

            //Load page Select order.
            _pageTestInitial = new pageTestInitial(_frmMain,this);
            this.panBodyTest.Controls.Add(_pageTestInitial);
            _pageTestInitial.Dock = DockStyle.Fill;
            _pageTestInitial.BringToFront();
        }

        public void Load_PageTestManufacturing()
        {
            //default page//set HeadLine
            _frmMain.Set_HeadLine(oldHeader + " > Test Manufacturing");

            //Clear Panel Body
            this.panBodyTest.Controls.Clear();

            //Load page Select order.
            _pageTestManufacturing = new pageTestManufacturing(_frmMain);
            this.panBodyTest.Controls.Add(_pageTestManufacturing);
            _pageTestManufacturing.Dock = DockStyle.Fill;
            _pageTestManufacturing.BringToFront();
        }
    }
}
