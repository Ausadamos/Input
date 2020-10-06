
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
    public partial class pageInput_Confirm : UserControl
    {
        InputOrderControllers _controllers = new InputOrderControllers();
        pageInput_Main _pageInputMain;
        frmMain _frmMain;

        public pageInput_Confirm(pageInput_Main obj, frmMain obj2)
        {
            InitializeComponent();
            _pageInputMain = obj;
            _frmMain = obj2;
        }

        private void pageInput_Confirm_Load(object sender, EventArgs e)
        {
            this.txtTotelOrder.Text = "Total Input : " + _pageInputMain.txtDateDiff.Text + " Order";
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
            foreach (OrderProperty _input in _pageInputMain._listOrderInput)
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
            this.Load_PageInput();
        }

        private void Load_PageInput()
        {
            _frmMain.Set_HeadLine("Input > " + _frmMain._order.FFT_ORDER_ID);

            _frmMain.panBody.Controls.Clear();

            pageInput_Main _pageInput_Main = new pageInput_Main(_frmMain);
            _frmMain.panBody.Controls.Add(_pageInput_Main);
            _pageInput_Main.Dock = DockStyle.Fill;
            _pageInput_Main.BringToFront();
        }

        private void bttInput_Click(object sender, EventArgs e)
        {

            if (_controllers.InsertOrder(_pageInputMain._listOrderInput))
            {
                this.Load_PageInput();
            }

        }
    }
}
