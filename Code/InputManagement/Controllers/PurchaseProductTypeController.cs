using BusinessData.Property;
using InputManagement.Models;
using InputManagement.Property;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InputManagement.Controllers
{
    public class PurchaseProductTypeController
    {

        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        PurchaseProductTypeModels _models = new PurchaseProductTypeModels();

        public List<PurchaseProductTypeProperty> Search(PurchaseProductTypeProperty dataItem)
        {
            List<PurchaseProductTypeProperty> _result = new List<PurchaseProductTypeProperty>();
            try
            {
                _resultData = _models.Search(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            PurchaseProductTypeProperty _purchaseProductTypeProperty = new PurchaseProductTypeProperty
                            {

                                PRODUCT_TYPE = new ProductTypeProperty
                                {
                                    PRODUCT_SUB_CODE = _resultData.ResultOnDb.Rows[i]["PRODUCT_SUB_CODE"].ToString(),
                                    PRODUCT_TITLE = _resultData.ResultOnDb.Rows[i]["PRODUCT_TITLE"].ToString(),
                                },
                                PURCHASE = new PurchaseProperty
                                {
                                    ID = _resultData.ResultOnDb.Rows[i]["PURCHASE_ID"].ToString(),
                                    PURCHASE_NO = _resultData.ResultOnDb.Rows[i]["PURCHASE_NO"].ToString(),
                                },
                                MODEL = new ModelProperty
                                {
                                    MODEL_NO = _resultData.ResultOnDb.Rows[i]["MODEL_NO"].ToString(),
                                },
                                PART_NO = new PartNoProperty
                                {
                                    PART_NO = _resultData.ResultOnDb.Rows[i]["PART_NO"].ToString(),
                                },
                                PURCHASE_FFTCODE = new PurchaseFftCodeProperty
                                {
                                    FFT_CODE = new FftCodeProperty
                                    {
                                        FFT_CODE = _resultData.ResultOnDb.Rows[i]["FFT_CODE"].ToString(),
                                    }
                                }

                            };
                            _result.Add(_purchaseProductTypeProperty);
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