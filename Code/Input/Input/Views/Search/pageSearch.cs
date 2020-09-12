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
    public partial class pageSearch : UserControl
    {
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

        private void btnSerialInput_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(frmSearch_SerialInput)))
            {
                frmSearch_SerialInput _frmSearch_SerialInput = new frmSearch_SerialInput();
                _frmSearch_SerialInput.Show();
            }
        }

        private void btnSerialProgress_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(frmSearch_SerialProgress)))
            {
                frmSearch_SerialProgress _frmSearch_SerialProgress = new frmSearch_SerialProgress();
                _frmSearch_SerialProgress.Show();
            }
        }
    }
}