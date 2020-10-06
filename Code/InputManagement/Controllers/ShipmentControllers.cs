using BusinessData.Property;
using InputManagement.Models;
using InputManagement.Property;
using System;
using System.Windows.Forms;

namespace InputManagement.Controllers
{
    public class ShipmentControllers
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        ShipmentModels _models = new ShipmentModels();

        public ShipmentProperty SearchSerailShipping(ShipmentProperty dataItem)
        {
            ShipmentProperty _result = new ShipmentProperty();
            try
            {
                _resultData = _models.SearchSerailShipping(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            _result.SERIAL_NO = _resultData.ResultOnDb.Rows[i]["SERIAL_NO"].ToString();
                            _result.ACTION = _resultData.ResultOnDb.Rows[i]["ACTION"].ToString();
                            _result.PRODUCT_CODE = _resultData.ResultOnDb.Rows[i]["PRODUCT_CODE"].ToString();
                            _result.SHIPMENT_DATE = _resultData.ResultOnDb.Rows[i]["SHIPMENT_DATE"].ToString();
                            _result.SHIPMENT_DATE_TXT = _resultData.ResultOnDb.Rows[i]["SHIPMENT_DATE_TXT"].ToString();
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
        public ShipmentProperty SearchSerailShippingReturn(ShipmentProperty dataItem)
        {
            ShipmentProperty _result = new ShipmentProperty();
            try
            {
                _resultData = _models.SearchSerailShippingReturn(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            _result.SERIAL_NO = _resultData.ResultOnDb.Rows[i]["SERIAL_NO"].ToString();
                            _result.ACTION = _resultData.ResultOnDb.Rows[i]["ACTION"].ToString();
                            _result.PRODUCT_CODE = _resultData.ResultOnDb.Rows[i]["PRODUCT_CODE"].ToString();
                            _result.SHIPMENT_DATE = _resultData.ResultOnDb.Rows[i]["SHIPMENT_DATE"].ToString();
                            //_test data
                            //_result.SHIPMENT_DATE ="10/01/1995";
                            _result.SHIPMENT_DATE_TXT = _resultData.ResultOnDb.Rows[i]["SHIPMENT_DATE_TXT"].ToString();
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
