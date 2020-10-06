using BusinessData.Property;
using InputManagement.Models;
using InputManagement.Property;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InputManagement.Controllers
{
    public class SubProductController
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        SubProductModels _models = new SubProductModels();

        public List<SubProductProperty> Search()
        {
            List<SubProductProperty> _result = new List<SubProductProperty>();
            try
            {
                _resultData = _models.Search();
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            SubProductProperty productSubProperty = new SubProductProperty()
                            {
                                PRODUCT_MAIN_CODE = _resultData.ResultOnDb.Rows[i]["PRODUCT_MAIN_CODE"].ToString(),
                                PRODUCT_SUB_CODE = _resultData.ResultOnDb.Rows[i]["PRODUCT_SUB_CODE"].ToString(),
                                PRODUCT_SUB_NAME = _resultData.ResultOnDb.Rows[i]["PRODUCT_SUB_NAME"].ToString(),
                                DESCRIPTION = _resultData.ResultOnDb.Rows[i]["DESCRIPTION"].ToString(),
                                CREATE_USER = _resultData.ResultOnDb.Rows[i]["CREATE_USER"].ToString(),
                                LAST_USER = _resultData.ResultOnDb.Rows[i]["LAST_USER"].ToString(),
                                CREATE_DATE = _resultData.ResultOnDb.Rows[i]["CREATE_DATE"].ToString(),
                                LAST_DATE = _resultData.ResultOnDb.Rows[i]["LAST_DATE"].ToString(),
                            };
                            _result.Add(productSubProperty);
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
        public List<SubProductProperty> SearchSubProduct(string mainProduct)
        {
            List<SubProductProperty> result = new List<SubProductProperty>();
            SubProductProperty dataItem = new SubProductProperty { PRODUCT_MAIN_CODE = mainProduct };
            try
            {
                _resultData = _models.SearchSubProduct(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            SubProductProperty item = new SubProductProperty
                            {
                                PRODUCT_SUB_CODE = _resultData.ResultOnDb.Rows[i]["PRODUCT_SUB_CODE"].ToString(),
                                PRODUCT_SUB_NAME = _resultData.ResultOnDb.Rows[i]["PRODUCT_SUB_NAME"].ToString()
                            };
                            result.Add(item);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
        }
    }
}
