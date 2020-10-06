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
    public partial class frmSearchFlows : Form
    {

        SearchControllers _controllers = new SearchControllers();
        InputOrderControllers _inputControllers = new InputOrderControllers();

        SearchOrderDetailProperty search = new SearchOrderDetailProperty();

        public frmSearchFlows()
        {
            InitializeComponent();
        }

        private void frmSearchFlows_Load(object sender, EventArgs e)
        {
            this.bindingSourceData.DataSource = _controllers.SearchFlow();
            this.adgvFlow.DataSource = this.bindingSourceData;
        }

    }
}
