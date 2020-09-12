using CommonClassLibrary.Components;
using Input.Controllers;
using InputManagement.Property;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Input
{
    public partial class pageCreate_ProductType : UserControl
    {
        PurchaseControllers _controller = new PurchaseControllers();
        List<SerialProductTypeProperty> _listSerialProduct = new List<SerialProductTypeProperty>();
        List<SerialProductTypeProperty> listHistoryFormat = new List<SerialProductTypeProperty>();
        List<SerialProductTypeProperty> listInuseFormat = new List<SerialProductTypeProperty>();

        List<SerialTypeProperty> listSerialTypeProperty;

        ProductSubController _productSubController = new ProductSubController();
        ProductTypeController _productTypeController = new ProductTypeController();
        SerialProductTypeController _serialProductTypeController = new SerialProductTypeController();
        SerialTypeController _serialTypeController = new SerialTypeController();

        frmMain _frmMain;
        string _defultExSerial;


        public pageCreate_ProductType(frmMain obj)
        {
            InitializeComponent();
            _frmMain = obj;
            _defultExSerial = this.lblShowExFormatSerial.Text;
        }

        private void pageCreate_ProductType_Load(object sender, EventArgs e)
        {
            this.btnCreate.Enabled = false;
            listSerialTypeProperty = _serialTypeController.Search();
            LoadProduct();


        }
        private void SetPage()
        {
            this.txtProductTitle.Text = "";
            this.txtProductFormat.Text = "";
            lstHis.Items.Clear();
            this.lstHis.Enabled = this.lstHis.Items.Count == 0 ? false : true;
            this.lstProductType.SelectionMode = SelectionMode.None;
            this.lstHis.SelectionMode = SelectionMode.None;
            this.lstProductType.SelectionMode = SelectionMode.One;
            this.lstHis.SelectionMode = SelectionMode.One;
        }
        private void Load_ProductType()
        {
            this.SetPage();

            this.lstProductType.DataSource = null;
            lstProductType.Items.Clear();

            ProductTypeProperty productTypeProperty = new ProductTypeProperty()
            {
                PRODUCT_SUB_CODE = (cmbProduct.SelectedItem as ComboboxItem).Value.ToString()
            };

            List<ProductTypeProperty> listProductTypeProperty = _productTypeController.SearchByProductSubCode(productTypeProperty);
            foreach (ProductTypeProperty data in listProductTypeProperty)
            {

                ListBoxItem item = new ListBoxItem();
                item.Text = data.PRODUCT_TITLE;
                item.Value = data.ID;
                lstProductType.Items.Add(item);

            };

        }


        private void LoadProduct()
        {
            cmbProduct.Items.Clear();
            List<ProductSubProperty> listProductSubProperty = _productSubController.Search();
            foreach (ProductSubProperty data in listProductSubProperty)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = data.PRODUCT_SUB_NAME;
                item.Value = data.PRODUCT_SUB_CODE;
                cmbProduct.Items.Add(item);
            }
        }

        private void txtProductTitle_TextChanged(object sender, EventArgs e)
        {
            this.CheckInput();
        }

        private void txtProductFormat_TextChanged(object sender, EventArgs e)
        {
            this.lblShowExFormatSerial.Text = (this.txtProductFormat.Text != "") ? "yyXXXX" + this.txtProductFormat.Text : this._defultExSerial;
            this.lblExYear.Visible = (this.txtProductFormat.Text != "") ? true : false;
            this.lblExNumberSerial.Visible = (this.txtProductFormat.Text != "") ? true : false;

            this.CheckInput();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {

            SerialProductTypeProperty _insertProductType = new SerialProductTypeProperty();
            _insertProductType.productTypeProperty = new ProductTypeProperty();
            _insertProductType.serialTypeProperty = new SerialTypeProperty();

            //********** GET DATA **********//
            _insertProductType.productTypeProperty.PRODUCT_TITLE = this.txtProductTitle.Text.ToString().Trim();
            _insertProductType.productTypeProperty.PRODUCT_SUB_CODE = (cmbProduct.SelectedItem as ComboboxItem).Value.ToString();
            _insertProductType.serialTypeProperty.SERIAL_FORMAT = this.txtProductFormat.Text.ToString().Trim();
            _insertProductType.serialTypeProperty.DETAIL = this.lblShowExFormatSerial.Text.ToString().Trim();


            //********** Check PRODUCT TITLE **********//
            if (_insertProductType.productTypeProperty.PRODUCT_TITLE == null || _insertProductType.productTypeProperty.PRODUCT_TITLE == "")
            { MessageBox.Show("Not Found PRODUCT_TITLE" + "\n\n" + "Please Check TITLE BOX ", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }

            //********* Check SERIAL FORMAT **********//
            if (_insertProductType.serialTypeProperty.SERIAL_FORMAT == null || _insertProductType.serialTypeProperty.SERIAL_FORMAT == "")
            { MessageBox.Show("Not Found SERIAL_FORMAT" + "\n\n" + "Please Check FORMAT BOX ", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }

            //********* Check SERIAL DETIAL **********//
            if (_insertProductType.serialTypeProperty.DETAIL == null || _insertProductType.serialTypeProperty.DETAIL == "")
            { MessageBox.Show("Not Found SERIAL_DETIAL" + "\n\n" + "Please Check FORMAT BOX ", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }

            //Insert Product Type//
            if (_controller.InsertProductType(_insertProductType))
            {
                listSerialTypeProperty = _serialTypeController.Search();
                this.Load_ProductType();
            }

        }
        private void CheckInput()
        {
            this.btnCreate.Enabled = (this.txtProductTitle.Text != "") ? (this.txtProductFormat.Text != "") ? true : false : false;
        }

        private void lstProductType_Click(object sender, EventArgs e)
        {
            if (lstProductType.SelectedItem != null)
            {

                SerialProductTypeProperty SerialProductTypeProperty = new SerialProductTypeProperty()
                {
                    productTypeProperty = new ProductTypeProperty()
                    {
                        ID = (lstProductType.SelectedItem as ListBoxItem).Value.ToString()
                    }

                };

                List<SerialProductTypeProperty> listSerialProductTypeProperty = _serialProductTypeController.SearchByProductTypeId(SerialProductTypeProperty);

                listHistoryFormat = listSerialProductTypeProperty.FindAll(x => x.INUSE == "False");
                listInuseFormat = listSerialProductTypeProperty.FindAll(x => x.INUSE == "True");


                string title = (lstProductType.SelectedItem as ListBoxItem).Text.ToString();
                //int indexInList = listInuseFormat.FindIndex(a => a.productTypeProperty.ID.Contains(title));

                this.txtProductTitle.Text = (lstProductType.SelectedItem as ListBoxItem).Text.ToString();

                //กรณีเพิ่ม Product type ใหม่
                if (listInuseFormat.Count > 0)
                {
                    this.txtProductFormat.Text = listSerialTypeProperty.Find(x => x.ID == listInuseFormat[0].serialTypeProperty.ID).SERIAL_FORMAT;

                }
                else
                {
                    this.txtProductFormat.Text = "";
                }


                lstHis.Items.Clear();

                foreach (SerialProductTypeProperty item in listHistoryFormat)
                {
                    lstHis.Items.Add(listSerialTypeProperty.Find(x => x.ID == item.serialTypeProperty.ID).SERIAL_FORMAT);
                }
                this.lstHis.Enabled = this.lstHis.Items.Count == 0 ? false : true;

            }

        }

        private void lstHis_Click(object sender, EventArgs e)
        {
            //string title = Convert.ToString(lstHis.SelectedItem);
            //int indexInList = listHistoryFormat.FindIndex(a => a.SERIAL_TYPE.SERIAL_FORMAT.Contains(title));
            //this.txtProductFormat.Text = listHistoryFormat[indexInList].SERIAL_TYPE.SERIAL_FORMAT;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(this.txtProductTitle.Text.Trim()))
            {
                MessageBox.Show("Can't set serial title because not found serial title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtProductFormat.Text.Trim()))
            {
                MessageBox.Show("Can't set serial format because not found serial format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(this.lblShowExFormatSerial.Text.ToString().Trim()))
            {
                MessageBox.Show("Can't set serial format because not found serial detail format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listInuseFormat.Count == 0)
            {
                MessageBox.Show("Can't set serial title because not found Product Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            SerialProductTypeProperty setFormat = new SerialProductTypeProperty
            {
                productTypeProperty = new ProductTypeProperty { PRODUCT_TITLE = this.txtProductTitle.Text.Trim(), ID = (lstProductType.SelectedItem as ListBoxItem).Value.ToString(), PRODUCT_SUB_CODE = (cmbProduct.SelectedItem as ComboboxItem).Value.ToString() }
                ,
                serialTypeProperty = new SerialTypeProperty
                {
                    ID = listInuseFormat[0].serialTypeProperty.ID,

                    SERIAL_FORMAT = this.txtProductFormat.Text.Trim()
                    ,
                    DETAIL = this.lblShowExFormatSerial.Text.ToString().Trim()
                }
            };

            if (_controller.UpdateSerialFormat(setFormat))
            {
                listSerialTypeProperty = _serialTypeController.Search();
                this.Load_ProductType();
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbProduct.Text))
            {
                listHistoryFormat.Clear();
                listInuseFormat.Clear();
                this.Load_ProductType();
            }
        }

        private void lstProductType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
