using BusinessData.Property;

using InputManagement.Models;
using InputManagement.Property;

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace InputManagement.Controllers
{
    public class PurchaseControllers
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        PurchaseModels _models = new PurchaseModels();

        public DataTable LoadPurchaseAll()
        {
            DataTable _result = new DataTable();
            try
            {
                _resultData = _models.LoadPurchaseAll();
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

        public DataTable SearchDetailPurchaseByPurchase(PurchaseProperty dataItem)
        {
            DataTable _result = new DataTable();
            try
            {
                _resultData = _models.SearchDetailPurchaseByPurchase(dataItem);
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

        public List<PurchaseProperty> SearchPurchasesOrder(OrderProperty dataItem)
        {
            List<PurchaseProperty> _result = new List<PurchaseProperty>();
            try
            {
                _resultData = _models.SearchPurchasesOrder(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            PurchaseProperty _purchase = new PurchaseProperty
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["ID"].ToString(),
                                PURCHASE_NO = _resultData.ResultOnDb.Rows[i]["DOCUMENT_NO"].ToString(),
                                FFT_CODE = _resultData.ResultOnDb.Rows[i]["FFT_CODE"].ToString(),
                                FLOW = new FlowProperty { FLOW_NAME = _resultData.ResultOnDb.Rows[i]["FLOW_NAME"].ToString() },
                                PRODUCT_PURCHASE = _resultData.ResultOnDb.Rows[i]["PRODUCT_NAME"].ToString(),
                                PART_NO = _resultData.ResultOnDb.Rows[i]["PART_NO"].ToString(),
                                MODEL = _resultData.ResultOnDb.Rows[i]["MODEL_NO"].ToString(),
                                DATE = _resultData.ResultOnDb.Rows[i]["CREATE_DATE"].ToString(),
                            };
                            _result.Add(_purchase);
                        }
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
        public List<PurchaseProperty> ListPurchasesAll()
        {
            List<PurchaseProperty> _result = new List<PurchaseProperty>();
            try
            {
                _resultData = _models.LoadPurchaseAll();
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            PurchaseProperty _purchase = new PurchaseProperty
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["ID"].ToString(),
                                PURCHASE_NO = _resultData.ResultOnDb.Rows[i]["DOCUMENT_NO"].ToString(),
                                PRODUCT_PURCHASE = _resultData.ResultOnDb.Rows[i]["PRODUCT_NAME"].ToString(),
                                PART_NO = _resultData.ResultOnDb.Rows[i]["PART_NO"].ToString(),
                                MODEL = _resultData.ResultOnDb.Rows[i]["MODEL_NO"].ToString(),
                                DATE = _resultData.ResultOnDb.Rows[i]["CREATE_DATE"].ToString(),
                            };
                            _result.Add(_purchase);
                        }
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

        public List<PurchaseProperty> SearchPurchasesByProduct(PurchaseProperty dataItem)
        {
            List<PurchaseProperty> _result = new List<PurchaseProperty>();
            try
            {
                _resultData = _models.SearchPurchasesByProduct(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            PurchaseProperty _purchase = new PurchaseProperty
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["ID"].ToString(),
                                PURCHASE_NO = _resultData.ResultOnDb.Rows[i]["DOCUMENT_NO"].ToString(),
                                PRODUCT_PURCHASE = _resultData.ResultOnDb.Rows[i]["PRODUCT_NAME"].ToString(),
                                PART_NO = _resultData.ResultOnDb.Rows[i]["PART_NO"].ToString(),
                                MODEL = _resultData.ResultOnDb.Rows[i]["MODEL_NO"].ToString(),
                                DATE = _resultData.ResultOnDb.Rows[i]["CREATE_DATE"].ToString(),
                                FLOW = new FlowProperty { FLOW_NAME = _resultData.ResultOnDb.Rows[i]["FLOW_NAME"].ToString(), }
                            };
                            _result.Add(_purchase);
                        }
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

        public List<PurchaseProperty> LastPurchase(ShipmentProperty dataItem)
        {
            List<PurchaseProperty> _result = new List<PurchaseProperty>();
            try
            {
                _resultData = _models.LastPurchase(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            PurchaseProperty _purchase = new PurchaseProperty();
                            _purchase.FLOW = new FlowProperty();

                            _purchase.PURCHASE_NO = _resultData.ResultOnDb.Rows[i]["PURCHASE_NO"].ToString();
                            _purchase.FLOW.FLOW_NAME = _resultData.ResultOnDb.Rows[i]["FLOW_NAME"].ToString();


                            _result.Add(_purchase);
                        }
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

        public List<PurchaseProperty> UsedPurchase(ShipmentProperty dataItem)
        {
            List<PurchaseProperty> _result = new List<PurchaseProperty>();
            try
            {
                _resultData = _models.UsedPurchase(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            PurchaseProperty _purchase = new PurchaseProperty();
                            _purchase.FLOW = new FlowProperty();

                            _purchase.PURCHASE_NO = _resultData.ResultOnDb.Rows[i]["PURCHASE_NO"].ToString();
                            _purchase.FLOW.FLOW_NAME = _resultData.ResultOnDb.Rows[i]["FLOW_NAME"].ToString();

                            _result.Add(_purchase);
                        }
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

        public bool InsertNewPurchase(PurchaseProperty dataItem)
        {
            bool _result = false;
            try
            {
                _resultData = _models.InsertNewPurchase(dataItem);
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


        public bool UpdateProcessCardPurchase(PurchaseProperty dataItem, PurchaseProperty updatePurchase)
        {
            bool _result = false;
            try
            {
                _resultData = _models.UpdateProcessCardPurchase(dataItem, updatePurchase);
                if (_resultData.StatusOnDb == true)
                {
                    MessageBox.Show(_resultData.MessageOnDb, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _result = true;
                }
                else
                { MessageBox.Show(_resultData.MessageOnDb, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _result;
        }

        public List<SerialProductTypeProperty> SearchAllProductType()
        {
            List<SerialProductTypeProperty> _result = new List<SerialProductTypeProperty>();
            try
            {
                _resultData = _models.SearchAllProductType();
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            SerialProductTypeProperty _listproductType = new SerialProductTypeProperty
                            {
                                PRODUCT_TYPE = new ProductTypeProperty
                                {
                                    ID = _resultData.ResultOnDb.Rows[i]["ID"].ToString()
                                    ,
                                    PRODUCT_TITLE = _resultData.ResultOnDb.Rows[i]["PRODUCT_TITLE"].ToString()

                                }
                                ,
                                SERIAL_TYPE = new SerialTypeProperty
                                {
                                    SERIAL_FORMAT = _resultData.ResultOnDb.Rows[i]["SERIAL_FORMAT"].ToString()
                                    ,
                                    DETAIL = _resultData.ResultOnDb.Rows[i]["DETAIL"].ToString()

                                }
                                ,
                                INUSE = _resultData.ResultOnDb.Rows[i]["INUSE"].ToString()
                            };
                            _result.Add(_listproductType);
                        }
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

        public bool InsertProductType(SerialProductTypeProperty dataItem)
        {
            bool _result = false;
            try
            {
                _resultData = _models.InsertProductType(dataItem);
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

        public bool UpdateSerialFormat(SerialProductTypeProperty dataItem)
        {
            bool _result = false;
            try
            {
                _resultData = _models.UpdateSerialFormat(dataItem);
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
