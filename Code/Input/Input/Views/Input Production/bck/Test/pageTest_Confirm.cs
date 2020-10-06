
using InputManagement.Property;

using Input.Controllers;

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
    public partial class pageTest_Confirm : UserControl
    {
        InputOrderControllers _controllers = new InputOrderControllers();

        pageTestInitial _pageTestInitial;
        pageTest _pageTest;
        frmMain _frmMain;

        public pageTest_Confirm(pageTestInitial obj, pageTest obj2,frmMain obj3)
        {
            InitializeComponent();
            _pageTestInitial = obj;
            _pageTest = obj2;
            _frmMain = obj3;
        }

        private void pageInput_Confirm_Load(object sender, EventArgs e)
        {
            this.txtTotelOrder.Text = "Total Input : " + _pageTestInitial.txtDateDiff.Text + " Order";
            this.dgvOrderInput.DataSource = this.OrderInputAll();
        }

        private DataTable OrderInputAll()
        {
            // Here we create a DataTable with four columns.
            DataTable table = new DataTable();
            table.Columns.Add("FFT_ORDER_ID", typeof(string));
            table.Columns.Add("ORDER_DATE", typeof(string));
            table.Columns.Add("ORDER_QUANTITY", typeof(string));
            table.Columns.Add("EMP", typeof(string));

            DataTable tableInput = table;
            foreach (OrderProperty _input in _pageTestInitial._listOrderInput)
            {
                tableInput.Rows.Add(
                    _input.FFT_ORDER_ID.ToString()
                    , _input.ORDER_DATE.ToString()
                    , _input.ORDER_QUANTITY.ToString()
                    , _input.EMP.code.ToString());
            }

            return tableInput;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Load_PageTestInitial();
        }

        private void Load_PageTestInitial()
        {
            _frmMain.panBody.Controls.Clear();

            pageTestInitial _pageTestInitial = new pageTestInitial(_frmMain, _pageTest);
            _pageTestInitial.Dock = DockStyle.Fill;
            _pageTestInitial.BringToFront();
        }

        private void bttInput_Click(object sender, EventArgs e)
        {
            if (_controllers.InsertOrder(_pageTestInitial._listOrderInput))
            {
                this.Load_PageTestInitial();
            }

        }
    }
}
