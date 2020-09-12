using BusinessData.Property;
using InputManagement.Models;
using InputManagement.Property;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Input.Controllers
{
    class ProcessControllers
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        ProcessModels _models = new ProcessModels();
        public bool InsertProcess(ProcessProperty dataItem)
        {
            bool _result = false;
            try
            {
                _resultData = _models.InsertProcess(dataItem);
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

        public bool UpdateProccessStatus(ProcessProperty dataItem)
        {
            bool _result = false;
            try
            {
                _resultData = _models.UpdateProccessStatus(dataItem);
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

        public List<ProcessProperty> SearchProcessAll()
        {
            List<ProcessProperty> _result = new List<ProcessProperty>();
            try
            {
                _resultData = _models.SearchProcessAll();
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            ProcessProperty _process = new ProcessProperty()
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["ID"].ToString(),
                                PROCESS_NAME = _resultData.ResultOnDb.Rows[i]["PROCESS_NAME"].ToString(),
                                INUSE = _resultData.ResultOnDb.Rows[i]["INUSE"].ToString()
                            };
                            _result.Add(_process);
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

        public List<ProcessProperty> SearchProcessByProductTypeId(ProcessProperty dataItem)
        {
            List<ProcessProperty> _result = new List<ProcessProperty>();
            try
            {
                _resultData = _models.SearchProcessByProductTypeId(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            ProcessProperty _process = new ProcessProperty()
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["ID"].ToString(),
                                PROCESS_NAME = _resultData.ResultOnDb.Rows[i]["PROCESS_NAME"].ToString(),
                                INUSE = _resultData.ResultOnDb.Rows[i]["INUSE"].ToString()
                            };
                            _result.Add(_process);
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

        public List<ProcessProperty> SearchProcessInUse()
        {
            List<ProcessProperty> _result = new List<ProcessProperty>();
            try
            {
                _resultData = _models.SearchProcessInUse();
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            ProcessProperty _process = new ProcessProperty()
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["ID"].ToString(),
                                PROCESS_NAME = _resultData.ResultOnDb.Rows[i]["PROCESS_NAME"].ToString(),
                                INUSE = _resultData.ResultOnDb.Rows[i]["INUSE"].ToString()
                            };
                            _result.Add(_process);
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
        public List<ProcessProperty> SearchProcessNonUse()
        {
            List<ProcessProperty> _result = new List<ProcessProperty>();
            try
            {
                _resultData = _models.SearchProcessNonUse();
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            ProcessProperty _process = new ProcessProperty()
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["ID"].ToString(),
                                PROCESS_NAME = _resultData.ResultOnDb.Rows[i]["PROCESS_NAME"].ToString(),
                                INUSE = _resultData.ResultOnDb.Rows[i]["INUSE"].ToString()
                            };
                            _result.Add(_process);
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

        public List<ResultProperty> SearchResultAll()
        {
            List<ResultProperty> _result = new List<ResultProperty>();
            try
            {
                _resultData = _models.SearchResultAll();
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            ResultProperty _resultInDB = new ResultProperty()
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["ID"].ToString(),
                                RESULT = _resultData.ResultOnDb.Rows[i]["RESULT"].ToString()
                            };
                            _result.Add(_resultInDB);
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
