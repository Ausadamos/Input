using BusinessData.Property;
using InputManagement.Models;
using InputManagement.Property;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Input.Controllers
{
    class SerialProductTypeController
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        SerialProductTypeModels _models = new SerialProductTypeModels();

        public List<SerialProductTypeProperty> SearchByProductTypeId(SerialProductTypeProperty dataItem)
        {
            List<SerialProductTypeProperty> _result = new List<SerialProductTypeProperty>();
            try
            {
                _resultData = _models.SearchByProductTypeId(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            SerialProductTypeProperty SerialProductTypeProperty = new SerialProductTypeProperty()
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["ID"].ToString(),
                                productTypeProperty = new ProductTypeProperty()
                                {
                                    ID = _resultData.ResultOnDb.Rows[i]["PRODUCT_TYPE_ID"].ToString()
                                },
                                serialTypeProperty = new SerialTypeProperty()
                                {
                                    ID = _resultData.ResultOnDb.Rows[i]["SERIAL_TYPE_ID"].ToString()
                                },
                                INUSE = _resultData.ResultOnDb.Rows[i]["INUSE"].ToString(),
                                DESCRIPTION = _resultData.ResultOnDb.Rows[i]["DESCRIPTION"].ToString(),
                                CREATE_USER = _resultData.ResultOnDb.Rows[i]["CREATE_USER"].ToString(),
                                LAST_USER = _resultData.ResultOnDb.Rows[i]["LAST_USER"].ToString(),
                                CREATE_DATE = _resultData.ResultOnDb.Rows[i]["CREATE_DATE"].ToString(),
                                LAST_DATE = _resultData.ResultOnDb.Rows[i]["LAST_DATE"].ToString(),
                            };

                            _result.Add(SerialProductTypeProperty);
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
