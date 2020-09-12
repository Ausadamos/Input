using BusinessData.Property;
using InputManagement.Models;
using InputManagement.Property;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Input.Controllers
{
    public class FlowControllers
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        FlowModels _models = new FlowModels();

        public DataTable LoadFlowAll()
        {
            DataTable _result = new DataTable();
            try
            {
                _resultData = _models.LoadFlowAll();
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

        public List<FlowProperty> LoadFlow()
        {
            List<FlowProperty> _result = new List<FlowProperty>();
            try
            {
                _resultData = _models.LoadFlow();
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            FlowProperty _flow = new FlowProperty
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["FLOW_ID"].ToString()
                                ,
                                FLOW_NAME = _resultData.ResultOnDb.Rows[i]["FLOW_NAME"].ToString()

                            };
                            _result.Add(_flow);
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

        public string GetFlowName()
        {
            string _result = "Err????"; ;
            try
            {
                _resultData = _models.GetMaxFlowName();
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        string[] arr = _resultData.ResultOnDb.Rows[0]["MAX_FLOW"].ToString().Split('-');

                        int maxNum;
                        bool isNumeric = int.TryParse(arr[1], out maxNum);
                        if (!isNumeric)
                        {
                            isNumeric = int.TryParse(arr[2], out maxNum);
                        }
                        if (isNumeric)
                        {
                            if (maxNum == 0)
                            {
                                _result = "FLW-0001";
                            }
                            else
                            {
                                maxNum += 1;
                                if (maxNum < 10)
                                {
                                    _result = "FLW-000" + maxNum;
                                }
                                else if (maxNum < 100)
                                {
                                    _result = "FLW-00" + maxNum;
                                }
                                else if (maxNum < 1000)
                                {
                                    _result = "FLW-0" + maxNum;
                                }
                                else
                                {
                                    _result = "FLW-" + maxNum;
                                }
                            }
                        }
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

        public bool InsertFlow(FlowProcessProperty dataItem)
        {
            bool _result = false;
            try
            {
                _resultData = _models.InsertFlow(dataItem);
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

        public bool UpdateStatus(FlowProperty dataItem)
        {
            bool _result = false;
            try
            {
                _resultData = _models.UpdateStatus(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    MessageBox.Show(_resultData.MessageOnDb, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _result = true;
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

        public FlowProcessProperty SearchFlowNameByPurchase(PurchaseProperty dataItem)
        {
            FlowProcessProperty _result = new FlowProcessProperty();
            try
            {
                _resultData = _models.SearchFlowNameByPurchase(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        _result.FLOW = new FlowProperty
                        {
                            FLOW_NAME = _resultData.ResultOnDb.Rows[0]["FLOW_NAME"].ToString()
                        };

                        _result.PROCESS = new List<ProcessProperty>();
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            ProcessProperty _process = new ProcessProperty
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["PROCESS_ID"].ToString(),
                                PROCESS_NAME = _resultData.ResultOnDb.Rows[i]["PROCESS_NAME"].ToString()
                            };
                            _result.PROCESS.Add(_process);
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
        public List<ProcessProperty> SearchProcessByFlowName(FlowProperty dataItem)
        {
            List<ProcessProperty> _result = new List<ProcessProperty>();
            try
            {
                _resultData = _models.SearchProcessByFlowName(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            ProcessProperty _Process = new ProcessProperty
                            {
                                PROCESS_NAME = _resultData.ResultOnDb.Rows[i]["PROCESS_NAME"].ToString(),

                            };
                            _result.Add(_Process);
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
        public List<FlowProcessProperty> CheckDuplicateFlowProcess(string dataItem)
        {
            List<FlowProcessProperty> _result = new List<FlowProcessProperty>();

            string flowName = "";
            try
            {
                _resultData = _models.CheckDuplicateFlowProcess(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            FlowProcessProperty _flow = new FlowProcessProperty();
                            if (_resultData.ResultOnDb.Rows[i]["FLOW_NAME"].ToString() != flowName)
                            {
                                flowName = _resultData.ResultOnDb.Rows[i]["FLOW_NAME"].ToString();

                                _flow.FLOW = new FlowProperty
                                {
                                    FLOW_NAME = _resultData.ResultOnDb.Rows[i]["FLOW_NAME"].ToString()
                                ,
                                    ID = _resultData.ResultOnDb.Rows[i]["ID"].ToString()
                                ,
                                    STATUS = _resultData.ResultOnDb.Rows[i]["STATUS"].ToString()
                                };

                                _flow.PROCESS = new List<ProcessProperty>();
                                for (int j = 0; j < _resultData.ResultOnDb.Rows.Count; j++)
                                {
                                    if (_resultData.ResultOnDb.Rows[i]["FLOW_NAME"].ToString() == _resultData.ResultOnDb.Rows[j]["FLOW_NAME"].ToString())
                                    {

                                        ProcessProperty _Process = new ProcessProperty
                                        {
                                            ID = _resultData.ResultOnDb.Rows[j]["PROCESS_ID"].ToString()
                                          ,
                                            PROCESS_NAME = _resultData.ResultOnDb.Rows[j]["PROCESS_NAME"].ToString()
                                          ,
                                            //  NO = _resultData.ResultOnDb.Rows[j]["NO"].ToString()
                                        };

                                        _flow.PROCESS.Add(_Process);
                                    }

                                }
                                _result.Add(_flow);
                            }

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
        public FlowProperty CallFlowRMA()
        {
            FlowProperty _result = new FlowProperty();
            try
            {
                _resultData = _models.CallFlowRMA();
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            _result.FLOW_NAME = _resultData.ResultOnDb.Rows[i]["FLOW_NAME"].ToString();

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
