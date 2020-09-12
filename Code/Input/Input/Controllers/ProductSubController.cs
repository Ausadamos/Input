using BusinessData.Property;
using InputManagement.Models;
using InputManagement.Property;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Input.Controllers
{
    class ProductSubController
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        ProductSubModels _models = new ProductSubModels();

        public List<ProductSubProperty> Search()
        {
            List<ProductSubProperty> _result = new List<ProductSubProperty>();
            try
            {
                _resultData = _models.Search();
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            ProductSubProperty productSubProperty = new ProductSubProperty()
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
    }
}
