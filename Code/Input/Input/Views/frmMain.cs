using InputManagement.Property;
using InputManagement;
using Login;
using Login.Property;

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
    public partial class frmMain : Form
    {
        public OrderProperty _order = new OrderProperty();
        LoginProperty _resultLogin = new LoginProperty();
        public  EmpProperty _empLogin = new EmpProperty();
        public frmMain()
        {   
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            //start program 
            Load_PageSearch();


            //===== For test program =======================================
            //_resultLogin = new LoginProperty();
            //_resultLogin.empDetial = new EmpProperty();
            //_resultLogin.loginStatus = true;
            //_resultLogin.empDetial.code = "S433";
            //_resultLogin.empDetial.name = "Jaturong";
            //_resultLogin.empDetial.sername = "Khiewdee";

            //if (_resultLogin.loginStatus == true)
            //{
            //    _empLogin = _resultLogin.empDetial;

            //    this.btnLogin.Visible = false;

            //    this.panShowName.Visible = true;
            //    this.panSettingTopic.Visible = true;

            //    this.btnInput.Visible = true;
            //    this.btnSetFlow.Visible = true;
            //    this.btnSetPurchase.Visible = true;
            //    this.btnUpdateInput.Visible = true;
            //    this.btnProcessSetting.Visible = true;
            //    this.btnCreateProductType.Visible = true;

            //    this.lblShowName.Text = String.Format("{0} {1}.", _empLogin.name, _empLogin.sername.Substring(0, 3));

            //}
        }

        public void Set_HeadLine(string text)
        {
            this.lblHeader.Text = text.Trim();
        }
        private void picMenu_Click(object sender, EventArgs e)
        {
            if (this.panBtn.Visible)
            {
                this.panBtn.Visible = false;
            }
            else
            {
                this.panBtn.Visible = true;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Load_PageSearch();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            frmLogin_Main _frmLogin = new frmLogin_Main();
            _frmLogin.ShowDialog();
            _resultLogin = _frmLogin._resultLogin;

            if (_resultLogin.loginStatus == true)
            {
                _empLogin = _resultLogin.empDetial;

                this.btnLogin.Visible = false;

                this.panShowName.Visible = true;
                this.panSettingTopic.Visible = true;

                this.btnInput.Visible = true;
                this.btnSetFlow.Visible = true;
                this.btnSetPurchase.Visible = true;
                this.btnUpdateInput.Visible = true;
                this.btnProcessSetting.Visible = true;
                this.btnSubProcessSetting.Visible = true;
                this.btnCreateProductType.Visible = true;
                this.btnPO.Visible = true;

                this.lblShowName.Text = String.Format("{0} {1}.", _empLogin.name, _empLogin.sername.Substring(0, 3));


                //if (_empPCControllors.CheckEmpPCExist(_empLogin) == true)
                //{
                //    this.bttNewOrder.Visible = true;
                //    this.panOnNewOrder.Visible = true;

                //    this.bttNewCondition.Visible = true;
                //    this.panOnNewCondition.Visible = true;

                //    this.bttUploadFile.Visible = true;
                //    this.panOnUploadFile.Visible = true;

                //    this.bttUpdateData.Visible = true;
                //    this.panOnUpdateData.Visible = true;

                //}
            }
        }
        private void lblLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want Logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.panShowName.Visible = false;
                this.panSettingTopic.Visible = false;

                this.btnLogin.Visible = true;

                //btn
                this.btnSearch.Visible = true;

                this.btnInput.Visible = false;
                this.btnSetFlow.Visible = false;
                this.btnSetPurchase.Visible = false;
                this.btnUpdateInput.Visible = false;
                this.btnProcessSetting.Visible = false;
                this.btnCreateProductType.Visible = false;
                this.btnPO.Visible = false;

                _empLogin = new EmpProperty();
                this.Load_PageSearch();
            }
        }
        private void picChangePass_Click(object sender, EventArgs e)
        {
            frmChangePass_Main _frmChangePass_Main = new frmChangePass_Main(_empLogin);
            _frmChangePass_Main.ShowDialog();
            if (_frmChangePass_Main.DialogResult == DialogResult.OK)
            {
                this.panShowName.Visible = false;
                this.panSettingTopic.Visible = false;

                this.btnLogin.Visible = true;

                this.btnSearch.Visible = true;

                this.btnInput.Visible = false;
                this.btnSetFlow.Visible = false;
                this.btnSetPurchase.Visible = false;
                this.btnUpdateInput.Visible = false;
                this.btnProcessSetting.Visible = false;
                this.btnCreateProductType.Visible = false;

                _empLogin = new EmpProperty();
                this.Load_PageSearch();
            }
        }
        private void btnInput_Click(object sender, EventArgs e)
        {
            this.Load_PageSelectOrder();
        }

        private void btnSetFlow_Click(object sender, EventArgs e)
        {
            this.Load_SetFlow();
        }
        private void btnUpdateInput_Click(object sender, EventArgs e)
        {
            this.Load_UpdateOrder();
        }
        private void btnSetPurchase_Click(object sender, EventArgs e)
        {
            this.Load_SetPurchase();
        }
        private void btnProcessSetting_Click(object sender, EventArgs e)
        {
            this.Load_InsertProcess();
        }

        private void btnSubProcessSetting_Click(object sender, EventArgs e)
        {
            this.Load_InsertSubProcess();
        }

        private void btnCreateProductType_Click(object sender, EventArgs e)
        {
           this.Load_pageAddProductType();
        }

        public void Load_PageSearch()
        {
            //default page//set HeadLine
            this.Set_HeadLine(btnSearch.Text);

            //Clear Panel Body
            this.panBody.Controls.Clear();

            //Load page Select order.
            pageSearch _pagesearch = new pageSearch(this);
            this.panBody.Controls.Add(_pagesearch);
            _pagesearch.Dock = DockStyle.Fill;
            _pagesearch.BringToFront();
        }
        private void Load_PageSelectOrder()
        {
            //default page//set HeadLine
            this.Set_HeadLine(btnInput.Text);

            //Clear Panel Body  
            this.panBody.Controls.Clear();

            //Load page Select order.
            pageInput_SelectOrder _pageOrder = new pageInput_SelectOrder(this);
            this.panBody.Controls.Add(_pageOrder);
            _pageOrder.Dock = DockStyle.Fill;
            _pageOrder.BringToFront();
        }
     
        public void Load_SetFlow()
        {
            //default page//set HeadLine
            this.Set_HeadLine(btnSetFlow.Text);

            //Clear Panel Body
            this.panBody.Controls.Clear();

            //Load page Select order.
            pageSetFlow _pageSetFlow = new pageSetFlow(this);
            this.panBody.Controls.Add(_pageSetFlow);
            _pageSetFlow.Dock = DockStyle.Fill;
            _pageSetFlow.BringToFront();
        }

        public void Load_SetPurchase()
        {
            //default page//set HeadLine
            this.Set_HeadLine(btnSetPurchase.Text);

            //Clear Panel Body
            this.panBody.Controls.Clear();

            //Load page Select order.
            pageSetPurchase_Main _pageSetPurchase = new pageSetPurchase_Main(this);
            this.panBody.Controls.Add(_pageSetPurchase);
            _pageSetPurchase.Dock = DockStyle.Fill;
            _pageSetPurchase.BringToFront();
        }


        private void Load_InsertProcess()
        {
            //default page//set HeadLine
            this.Set_HeadLine(btnProcessSetting.Text);

            //Clear Panel Body
            this.panBody.Controls.Clear();

            //Load page Select order.
            pageInsertProcecss _pageInsertProcess = new pageInsertProcecss(this);
            this.panBody.Controls.Add(_pageInsertProcess);
            _pageInsertProcess.Dock = DockStyle.Fill;
            _pageInsertProcess.BringToFront();
        }

        private void Load_InsertSubProcess()
        {
            //default page//set HeadLine
            this.Set_HeadLine(btnSubProcessSetting.Text);

            //Clear Panel Body
            this.panBody.Controls.Clear();

            //Load page Select order.
            pageInsertSubProcecss _pageInsertSubProcecss = new pageInsertSubProcecss(this);
            this.panBody.Controls.Add(_pageInsertSubProcecss);
            _pageInsertSubProcecss.Dock = DockStyle.Fill;
            _pageInsertSubProcecss.BringToFront();
        }

        

        private void Load_UpdateOrder()
        {
            //default page//set HeadLine
            this.Set_HeadLine(this.btnUpdateInput.Text);

            //Clear Panel Body
            this.panBody.Controls.Clear();

            //Load page Select order.
            pageUpdate_Order _pageUpdate_Order = new pageUpdate_Order(this);
            this.panBody.Controls.Add(_pageUpdate_Order);
            _pageUpdate_Order.Dock = DockStyle.Fill;
            _pageUpdate_Order.BringToFront();
        }

        private void Load_pageAddProductType()
        {
            //default page//set HeadLine
            this.Set_HeadLine("Create Product Type");
           
            //Clear Panel Body  
            this.panBody.Controls.Clear();

            //Load page Select order.
            pageCreate_ProductType _pageCreate_ProductType = new pageCreate_ProductType(this);
            this.panBody.Controls.Add(_pageCreate_ProductType);
            _pageCreate_ProductType.Dock = DockStyle.Fill;
            _pageCreate_ProductType.BringToFront();
        }

        private void btnPO_Click(object sender, EventArgs e)
        {
            this.Load_pageInsertPO();
        }
        private void Load_pageInsertPO()
        {
            //default page//set HeadLine
            this.Set_HeadLine(btnPO.Text);

            //Clear Panel Body  
            this.panBody.Controls.Clear();

            //Load page Select order.
            pageInsertPO _pageInsertPO = new pageInsertPO(this);
            this.panBody.Controls.Add(_pageInsertPO);
            _pageInsertPO.Dock = DockStyle.Fill;
            _pageInsertPO.BringToFront();
        }


    }
}
