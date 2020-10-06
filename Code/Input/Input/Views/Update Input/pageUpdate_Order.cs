using InputManagement.Controllers;

using InputManagement.Property;

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
    public partial class pageUpdate_Order : UserControl
    {
        InputOrderControllers _controllers = new InputOrderControllers();

        frmMain _frmMain;
        OrderProperty _order;

        int rowIndex_OldSelect;

   
        public pageUpdate_Order(frmMain obj)
        {
            InitializeComponent();
            _frmMain = obj;
        }

        private void pageUpdate_Order_Load(object sender, EventArgs e)
        {
            this.Page_Load();
        }
        private void Page_Load()
        {
            _order = new OrderProperty();
            this.SearchInputAll();

            this.lblFFT_ORDER_ID.Text = "- - - - - -";
            this.lblGroup.Text = "- - - - - -";
            this.txtQty.Clear();

        }
        private void SearchInputAll()
        {
            //get order to bindingSource.
            this.bindingSourceInputAll.DataSource = _controllers.SearchInputAll();
            this.adgvListInput.DataSource = this.bindingSourceInputAll;
        }
        private void bindingSourceInputAll_CurrentChanged(object sender, EventArgs e)
        {
            this.lblTotalRow.Text = "Total rows : " + this.bindingSourceInputAll.List.Count; ;
        }

        private void adgvListInput_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSourceInputAll.Filter = this.adgvListInput.FilterString;
        }

        private void adgvListInput_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSourceInputAll.Sort = this.adgvListInput.SortString;
        }
        private void adgvListInput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (this.adgvListInput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        _order = new OrderProperty
                        {
                            FFT_ORDER_ID = this.adgvListInput.Rows[e.RowIndex].Cells["FFT_ORDER_ID"].FormattedValue.ToString(),
                            GROUP = this.adgvListInput.Rows[e.RowIndex].Cells["GROUP"].FormattedValue.ToString(),
                            ORDER_QUANTITY = this.adgvListInput.Rows[e.RowIndex].Cells["QUANTITY"].FormattedValue.ToString()
                        };


                        if (_controllers.OrderInputExist(_order))
                        {
                            MessageBox.Show("FFT_ORDER_ID : " + _order.FFT_ORDER_ID + "\n" + "GROUT : " + _order.GROUP + "  Already Input.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.adgvListInput.Rows[e.RowIndex].Selected = false;
                            this.adgvListInput.Rows[this.rowIndex_OldSelect].Selected = true;
                            return;
                        }
                        else
                        {
                            this.lblFFT_ORDER_ID.Text = _order.FFT_ORDER_ID;
                            this.lblGroup.Text = _order.GROUP;
                            this.txtQty.Text = _order.ORDER_QUANTITY;

                            this.rowIndex_OldSelect = e.RowIndex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (this.txtQty.Text != "")
            {
                if (_order.FFT_ORDER_ID == "" || _order.FFT_ORDER_ID == null || _order.GROUP == "" || _order.GROUP == null)
                {
                    MessageBox.Show("Please Select FFT_ORDER_ID.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.txtQty.Clear();
                    return;
                }

                int qry;
                bool IsNumeric = int.TryParse(this.txtQty.Text, out qry);
                if (!IsNumeric)
                {
                    MessageBox.Show("Please input numeric Only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtQty.Text = _order.ORDER_QUANTITY;
                }
                else
                {
                    int orderQty = Convert.ToInt32(_controllers.GetOrderQty(_order));
                    int orderQtyHistory = Convert.ToInt32(_controllers.GetQtyHistory(_order));
                    int orderTotal = orderQtyHistory + qry;

                    if (orderTotal > orderQty)
                    {
                        DialogResult result = MessageBox.Show("Total input more than Order quantity."
                                                                + "\n" + "ORDER_QUANTITY : " + orderQty + " | TOTAL : " + orderTotal
                                                                + "\n" + "You want to change input Over YES | NO ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            return;
                        }
                        else
                        {
                            this.txtQty.Text = _order.ORDER_QUANTITY;
                            return;
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (_order.FFT_ORDER_ID == "" || _order.FFT_ORDER_ID == null || _order.GROUP == "" || _order.GROUP == null)
            {
                MessageBox.Show("Please Select FFT_ORDER_ID.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                if (this.txtQty.Text != "")
                {
                    int qty = Convert.ToInt32(this.txtQty.Text);
                    if (qty < 1)
                    {
                        MessageBox.Show("Can not change Quantity is 0.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        this.txtQty.Text = _order.ORDER_QUANTITY;
                        return;
                    }
                    else
                    {
                        _order.EMP = _frmMain._empLogin;
                        if (_order.ORDER_QUANTITY != this.txtQty.Text)
                        {
                            _order.ORDER_QUANTITY = this.txtQty.Text;
                            if (_controllers.UpdateInput(_order))
                            {
                                this.Page_Load();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please input Quantity.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                
            }
        }
    }
}
