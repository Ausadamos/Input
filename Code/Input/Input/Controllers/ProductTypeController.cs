using BusinessData.Property;
using InputManagement.Models;
using InputManagement.Property;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Input.Controllers
{
    class ProductTypeController
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        ProductTypeModels _models = new ProductTypeModels();

        //public List<ProductTypeProperty> Search()
        //{
        //    List<ProductTypeProperty> _result = new List<ProductTypeProperty>();
        //    try
        //    {
        //        _resultData = _models.Search();
        //        if (_resultData.StatusOnDb == true)
        //        {
        //            if (_resultData.ResultOnDb.Rows.Count > 0)
        //            {
        //                for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
        //                {

        //                }
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show(_resultData.MessageOnDb, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        return _result;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return _result;
        //    }
        //}

        public List<ProductTypeProperty> SearchByProductSubCode(ProductTypeProperty dataItem)
        {
            List<ProductTypeProperty> _result = new List<ProductTypeProperty>();
            try
            {
                _resultData = _models.SearchByProductSubCode(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            ProductTypeProperty ProductTypeProperty = new ProductTypeProperty()
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["ID"].ToString(),
                                PRODUCT_TITLE = _resultData.ResultOnDb.Rows[i]["PRODUCT_TITLE"].ToString(),
                                PRODUCT_SUB_CODE = _resultData.ResultOnDb.Rows[i]["PRODUCT_SUB_CODE"].ToString(),
                                DESCRIPTION = _resultData.ResultOnDb.Rows[i]["DESCRIPTION"].ToString(),
                                CREATE_USER = _resultData.ResultOnDb.Rows[i]["CREATE_USER"].ToString(),
                                LAST_USER = _resultData.ResultOnDb.Rows[i]["LAST_USER"].ToString(),
                                CREATE_DATE = _resultData.ResultOnDb.Rows[i]["CREATE_DATE"].ToString(),
                                LAST_DATE = _resultData.ResultOnDb.Rows[i]["LAST_DATE"].ToString(),
                            };

                            _result.Add(ProductTypeProperty);
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
