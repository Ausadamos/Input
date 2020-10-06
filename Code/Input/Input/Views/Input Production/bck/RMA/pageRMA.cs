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
    public partial class pageRMA : UserControl
    {
        string oldHeader;
        frmMain _frmMain;

        pageRMARework _pageRMARework;
        pageRMAInvestigate _pageRMAInvestigate;

        public pageRMA(frmMain obj )
        {
            InitializeComponent();
            _frmMain = obj;
            oldHeader = _frmMain.lblHeader.Text;
        }

        private void pageRMA_Load(object sender, EventArgs e)
        {
            _pageRMARework = new pageRMARework(_frmMain);
            _pageRMAInvestigate = new pageRMAInvestigate(_frmMain);
            this.rdoRMAInvastigate.Checked = true;
        }


        private void rdoRMAInvastigate_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoRMAInvastigate.Checked)
            {
                if (_pageRMAInvestigate._listInputRMAInvestigate.Count() > 0)
                {
                    return;
                }
                else
                {
                    if (_pageRMARework._listInputRMARework.Count() > 0)
                    {
                        DialogResult result = MessageBox.Show("Data not record." + "\n" + "Do you want to go to the RMA-Invastigate page Yes or No?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            this.Load_PageRMAInvestigate();
                        }
                        else
                        {
                            this.rdoRMARework.Checked = true;
                        }
                    }
                    else
                    {
                        this.Load_PageRMAInvestigate();
                    }
                }
            }
        }

        private void rdoRMARework_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoRMARework.Checked)
            {
                if (_pageRMARework._listInputRMARework.Count() > 0)
                {
                    return;
                }
                else
                {
                    if (_pageRMAInvestigate._listInputRMAInvestigate.Count() > 0)
                    {
                        DialogResult result = MessageBox.Show("Data not record." + "\n" + "Do you want to go to the RMA-Rework page Yes or No?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            this.Load_PageRMARework();
                        }
                        else
                        {
                            this.rdoRMAInvastigate.Checked = true;
                        }
                    }
                    else
                    {
                        this.Load_PageRMARework();
                    }
                }
            }
        }

        public void Load_PageRMAInvestigate()
        {
            //default page//set HeadLine
            _frmMain.Set_HeadLine(oldHeader + " > Investigate");

            //Clear Panel Body
            this.panBodyRMA.Controls.Clear();

            //Load page Select order.
            _pageRMARework = new pageRMARework(_frmMain);
            _pageRMAInvestigate = new pageRMAInvestigate(_frmMain);
            this.panBodyRMA.Controls.Add(_pageRMAInvestigate);
            _pageRMAInvestigate.Dock = DockStyle.Fill;
            _pageRMAInvestigate.BringToFront();
        }

        public void Load_PageRMARework()
        {
            //default page//set HeadLine
            _frmMain.Set_HeadLine(oldHeader + " > Rework");

            //Clear Panel Body
            this.panBodyRMA.Controls.Clear();

            //Load page Select order.
            _pageRMARework = new pageRMARework(_frmMain);
            this.panBodyRMA.Controls.Add(_pageRMARework);
            _pageRMARework.Dock = DockStyle.Fill;
            _pageRMARework.BringToFront();
        }
    }
}
