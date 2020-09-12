using BusinessData.Property;
using InputManagement.Models;
using InputManagement.Property;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Input.Controllers
{
    class GenerateSerialControllers
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        GenerateSerialModels _models = new GenerateSerialModels();
        public List<SerialProductTypeProperty> SearchSerialProductType()
        {
            List<SerialProductTypeProperty> _result = new List<SerialProductTypeProperty>();
            try
            {
                _resultData = _models.SearchProductType();
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            ProductTypeProperty _productType = new ProductTypeProperty
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["PRODUCT_TYPE_ID"].ToString(),
                                PRODUCT_TITLE = _resultData.ResultOnDb.Rows[i]["PRODUCT_TITLE"].ToString()
                            };

                            SerialTypeProperty _serialType = new SerialTypeProperty
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["SERIAL_TYPE_ID"].ToString(),
                                SERIAL_FORMAT = _resultData.ResultOnDb.Rows[i]["SERIAL_FORMAT"].ToString(),
                                DETAIL = _resultData.ResultOnDb.Rows[i]["DETAIL"].ToString()
                            };

                            SerialProductTypeProperty _serialProductType = new SerialProductTypeProperty
                            {
                                productTypeProperty = _productType,
                                serialTypeProperty = _serialType
                            };

                            _result.Add(_serialProductType);
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
    }
}
