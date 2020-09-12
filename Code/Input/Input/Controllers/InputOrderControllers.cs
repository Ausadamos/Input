using BusinessData.Property;

using InputManagement.Property;
using InputManagement.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace Input.Controllers
{
    public class InputOrderControllers
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        InputOrderModels _models = new InputOrderModels();

        public DataTable SearchOrderInThisYear()
        {
            DataTable _result = new DataTable();
            try
            {
                _resultData = _models.SearchOrderInThisYear();
                if (_resultData.StatusOnDb == true)
                {
                    DataTable tableMain = _resultData.ResultOnDb;
                    _resultData = _models.GetOrderActualInput();
                    if (_resultData.StatusOnDb == true)
                    {
                        DataTable tableOrderActualInput = _resultData.ResultOnDb;
                        var JoinResult = (from tableFFT_ORDER in tableMain.AsEnumerable()
                                          join tableINPUT in tableOrderActualInput.AsEnumerable() on tableFFT_ORDER.Field<string>("FFT_ORDER_ID") equals tableINPUT.Field<string>("FFT_ORDER_ID") into tempJoin
                                          from leftJoin in tempJoin.DefaultIfEmpty()
                                          select new
                                          {
                                                FFT_ORDER_ID = tableFFT_ORDER.Field<string>("FFT_ORDER_ID"),
                                                ORDER_DATE = tableFFT_ORDER.Field<string>("ORDER_DATE"),
                                                INPUT_STATUS = (leftJoin == null ? 0 - tableFFT_ORDER.Field<int>("ORDER_QUANTITY"):(int)leftJoin.Field<decimal>("ACTUAL_INPUT")- tableFFT_ORDER.Field<int>("ORDER_QUANTITY")) < 0 ? "Incomplete" : "Complete",
                                                ORDER_QUANTITY = tableFFT_ORDER.Field<int>("ORDER_QUANTITY"),
                                                ACTUAL_INPUT = leftJoin == null ? 0 : (int)leftJoin.Field<decimal>("ACTUAL_INPUT"),
                                                INPUT_DIFF = leftJoin == null ? 0 - tableFFT_ORDER.Field<int>("ORDER_QUANTITY") : (int)leftJoin.Field<decimal>("ACTUAL_INPUT") - tableFFT_ORDER.Field<int>("ORDER_QUANTITY"),
                                                ORDER_TYPE_NAME = tableFFT_ORDER.Field<string>("ORDER_TYPE_NAME"),
                                                PRODUCT_NAME = tableFFT_ORDER.Field<string>("PRODUCT_NAME"),
                                                CUSTOMER_NAME = tableFFT_ORDER.Field<string>("CUSTOMER_NAME"),
                                                WORK_ORDER = tableFFT_ORDER.Field<string>("WORK_ORDER"),
                                                PART_NO = tableFFT_ORDER.Field<string>("PART_NO"),
                                                SPEC_NO = tableFFT_ORDER.Field<string>("SPEC_NO"),
                                                SHIPPING_DESTINATION = tableFFT_ORDER.Field<string>("SHIPPING_DESTINATION"),
                                                CUSTOMER_REQUEST = tableFFT_ORDER.Field<string>("CUSTOMER_REQUEST"),

                                        }).ToList();

                        string json = JsonConvert.SerializeObject(JoinResult);
                        _result = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable))); 
                    }
                    else
                    {
                        MessageBox.Show(_resultData.MessageOnDb, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }  
                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _result;
        }

        public bool OrderInputExist(OrderProperty dataItem)
        {
            bool _result = true;
            try
            {
                _resultData = _models.SearchOrderInput(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    _result = _resultData.ResultOnDb.Rows.Count > 0 ? true : false;
                    return _result;
                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return _result;
        }

        public DataTable SearchInputAll()
        {
            DataTable _result = new DataTable();
            try
            {
                _resultData = _models.SearchInputAll();
                if (_resultData.StatusOnDb == true)
                {
                    _result = _resultData.ResultOnDb;
                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return _result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return _result;
            }
        }

        public DataTable SearchOrderAll()
        {
            DataTable _result = new DataTable();
            try
            {
                _resultData = _models.SearchOrderAll();
                if (_resultData.StatusOnDb == true)
                {
                    DataTable tableMain = _resultData.ResultOnDb;
                    _resultData = _models.GetOrderActualInput();
                    if (_resultData.StatusOnDb == true)
                    {
                        DataTable tableOrderActualInput = _resultData.ResultOnDb;
                        var JoinResult = (from tableFFT_ORDER in tableMain.AsEnumerable()
                                          join tableINPUT in tableOrderActualInput.AsEnumerable() on tableFFT_ORDER.Field<string>("FFT_ORDER_ID") equals tableINPUT.Field<string>("FFT_ORDER_ID") into tempJoin
                                          from leftJoin in tempJoin.DefaultIfEmpty()
                                          select new
                                          {
                                              FFT_ORDER_ID = tableFFT_ORDER.Field<string>("FFT_ORDER_ID"),
                                              ORDER_DATE = tableFFT_ORDER.Field<string>("ORDER_DATE"),
                                              INPUT_STATUS = (leftJoin == null ? 0 - tableFFT_ORDER.Field<int>("ORDER_QUANTITY") : (int)leftJoin.Field<decimal>("ACTUAL_INPUT") - tableFFT_ORDER.Field<int>("ORDER_QUANTITY")) < 0 ? "Incomplete" : "Complete",
                                              ORDER_QUANTITY = tableFFT_ORDER.Field<int>("ORDER_QUANTITY"),
                                              ACTUAL_INPUT = leftJoin == null ? 0 : (int)leftJoin.Field<decimal>("ACTUAL_INPUT"),
                                              INPUT_DIFF = leftJoin == null ? 0 - tableFFT_ORDER.Field<int>("ORDER_QUANTITY") : (int)leftJoin.Field<decimal>("ACTUAL_INPUT") - tableFFT_ORDER.Field<int>("ORDER_QUANTITY"),
                                              ORDER_TYPE_NAME = tableFFT_ORDER.Field<string>("ORDER_TYPE_NAME"),
                                              PRODUCT_NAME = tableFFT_ORDER.Field<string>("PRODUCT_NAME"),
                                              CUSTOMER_NAME = tableFFT_ORDER.Field<string>("CUSTOMER_NAME"),
                                              WORK_ORDER = tableFFT_ORDER.Field<string>("WORK_ORDER"),
                                              PART_NO = tableFFT_ORDER.Field<string>("PART_NO"),
                                              SPEC_NO = tableFFT_ORDER.Field<string>("SPEC_NO"),
                                              SHIPPING_DESTINATION = tableFFT_ORDER.Field<string>("SHIPPING_DESTINATION"),
                                              CUSTOMER_REQUEST = tableFFT_ORDER.Field<string>("CUSTOMER_REQUEST"),

                                          }).ToList();

                        string json = JsonConvert.SerializeObject(JoinResult);
                        _result = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
                    }
                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return _result;

        }

        public bool InsertOrder(List<OrderProperty> dataItem)
        {
            bool _result = false;
            try
            {
                _resultData = _models.InsertOrder(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    MessageBox.Show(_resultData.MessageOnDb, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _result = true;
                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return _result;
        }

        public bool UpdateInput(OrderProperty dataItem)
        {
            bool _result = false;
            try
            {
                _resultData = _models.UpdateInput(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    MessageBox.Show(_resultData.MessageOnDb, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _result = true;
                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return _result;
        }

        public string GetQtyHistory(OrderProperty dataItem)
        {
            string _result = "0";
            try
            {
                _resultData = _models.SearchOrderHistory(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        int Qty = 0;
                        int qtyOrderHistory;
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            qtyOrderHistory = Convert.ToInt32(_resultData.ResultOnDb.Rows[i]["QUANTITY"].ToString());
                            Qty = Qty + qtyOrderHistory;

                        }
                        _result = Qty.ToString();
                    }
                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _result;

        }

        public string GetOrderQty(OrderProperty dataItem)
        {
            string _result = "0";
            try
            {
                _resultData = _models.SeachOrderQty(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        _result = _resultData.ResultOnDb.Rows[0]["ORDER_QUANTITY"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _result;
        }

        public DataTable GetQtyHistoryAll(OrderProperty dataItem)
        {
            DataTable _result = new DataTable();
            try
            {
                _resultData = _models.SearchOrderHistory(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    _result = _resultData.ResultOnDb;
                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return _result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return _result;
            }

        }


        public DateTime GetDatetimeNow()
        {
            DateTime _result = DateTime.Now;
            string _datetimenow = "";
            try
            {
                _resultData = _models.GetDatetimeNow_InDB();
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        _datetimenow = _resultData.ResultOnDb.Rows[0]["DATETIME_NOW"].ToString();
                        _result = Convert.ToDateTime(_datetimenow);
                    }
                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return _result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return _result;
            }
        }
        public PurchaseOrderProperty SearchSerialUpdatePO (InputProperty dataItem)
        {
            PurchaseOrderProperty _result = new PurchaseOrderProperty();
            try
            {
                _resultData = _models.SearchSerialUpdatePO(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        _result.Serial = new SerialProperty
                        {
                            ID = _resultData.ResultOnDb.Rows[0]["ID_SERIAL"].ToString(),
                            SERIAL = _resultData.ResultOnDb.Rows[0]["SERIAL"].ToString()
                        };
                        _result.Order = new OrderProperty
                        {
                            FFT_ORDER_ID = _resultData.ResultOnDb.Rows[0]["FFT_ORDER_ID"].ToString(),
                            GROUP = _resultData.ResultOnDb.Rows[0]["GROUP"].ToString()
                        };
                        _result.Flow = new FlowProperty
                        {
                            ID = _resultData.ResultOnDb.Rows[0]["FLOW_ID"].ToString(),
                        };
                        _result.Input = new InputtypeProperty
                        {
                            ORDER_TYPE_NAME = _resultData.ResultOnDb.Rows[0]["INPUT_TYPE"].ToString()
                        };
                        _result.PO = _resultData.ResultOnDb.Rows[0]["PO"].ToString();
                    }

                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return _result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return _result;
            }
        }

        public bool SearchPO(PurchaseOrderProperty dataItem)
        {
            bool _result = false;
            try
            {
                _resultData = _models.SearchPO(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    MessageBox.Show(_resultData.MessageOnDb, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _result = true;
                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return _result;
        }

    }
}
