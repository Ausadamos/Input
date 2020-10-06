using BusinessData.Property;
using InputManagement.Models;
using InputManagement.Property;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InputManagement.Controllers
{
    public class SerialTypeController
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        SerialTypeModels _models = new SerialTypeModels();

        public List<SerialTypeProperty> Search()
        {
            List<SerialTypeProperty> _result = new List<SerialTypeProperty>();
            try
            {
                _resultData = _models.Search();
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            SerialTypeProperty SerialTypeProperty = new SerialTypeProperty()
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["ID"].ToString(),
                                SERIAL_FORMAT = _resultData.ResultOnDb.Rows[i]["SERIAL_FORMAT"].ToString(),
                                DETAIL = _resultData.ResultOnDb.Rows[i]["DETAIL"].ToString(),
                                DESCRIPTION = _resultData.ResultOnDb.Rows[i]["DESCRIPTION"].ToString(),
                                CREATE_USER = _resultData.ResultOnDb.Rows[i]["CREATE_USER"].ToString(),
                                LAST_USER = _resultData.ResultOnDb.Rows[i]["LAST_USER"].ToString(),
                                CREATE_DATE = _resultData.ResultOnDb.Rows[i]["CREATE_DATE"].ToString(),
                                LAST_DATE = _resultData.ResultOnDb.Rows[i]["LAST_DATE"].ToString(),

                            };
                            _result.Add(SerialTypeProperty);
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
