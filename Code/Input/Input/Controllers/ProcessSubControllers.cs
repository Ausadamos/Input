using BusinessData.Property;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Input.Controllers
{
    class ProcessSubSubControllers
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        ProcessSubModels _models = new ProcessSubModels();
        public bool InsertProcessSub(ProcessSubProperty dataItem)
        {
            bool _result = false;
            try
            {
                _resultData = _models.InsertProcessSub(dataItem);
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

        public bool UpdateProccessStatus(ProcessSubProperty dataItem)
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

        public List<ProcessSubProperty> SearchProcessSubAll()
        {
            List<ProcessSubProperty> _result = new List<ProcessSubProperty>();
            try
            {
                _resultData = _models.SearchProcessSubAll();
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            ProcessSubProperty _ProcessSub = new ProcessSubProperty()
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["ID"].ToString(),
                                ProcessSub_NAME = _resultData.ResultOnDb.Rows[i]["ProcessSub_NAME"].ToString(),
                                INUSE = _resultData.ResultOnDb.Rows[i]["INUSE"].ToString()
                            };
                            _result.Add(_ProcessSub);
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

        public List<ProcessSubProperty> SearchProcessSubByProductTypeId(ProcessSubProperty dataItem)
        {
            List<ProcessSubProperty> _result = new List<ProcessSubProperty>();
            try
            {
                _resultData = _models.SearchProcessSubByProductTypeId(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            ProcessSubProperty _ProcessSub = new ProcessSubProperty()
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["ID"].ToString(),
                                ProcessSub_NAME = _resultData.ResultOnDb.Rows[i]["ProcessSub_NAME"].ToString(),
                                INUSE = _resultData.ResultOnDb.Rows[i]["INUSE"].ToString()
                            };
                            _result.Add(_ProcessSub);
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

        public List<ProcessSubProperty> SearchProcessSubInUse()
        {
            List<ProcessSubProperty> _result = new List<ProcessSubProperty>();
            try
            {
                _resultData = _models.SearchProcessSubInUse();
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            ProcessSubProperty _ProcessSub = new ProcessSubProperty()
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["ID"].ToString(),
                                ProcessSub_NAME = _resultData.ResultOnDb.Rows[i]["ProcessSub_NAME"].ToString(),
                                INUSE = _resultData.ResultOnDb.Rows[i]["INUSE"].ToString()
                            };
                            _result.Add(_ProcessSub);
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
        public List<ProcessSubProperty> SearchProcessSubNonUse()
        {
            List<ProcessSubProperty> _result = new List<ProcessSubProperty>();
            try
            {
                _resultData = _models.SearchProcessSubNonUse();
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            ProcessSubProperty _ProcessSub = new ProcessSubProperty()
                            {
                                ID = _resultData.ResultOnDb.Rows[i]["ID"].ToString(),
                                ProcessSub_NAME = _resultData.ResultOnDb.Rows[i]["ProcessSub_NAME"].ToString(),
                                INUSE = _resultData.ResultOnDb.Rows[i]["INUSE"].ToString()
                            };
                            _result.Add(_ProcessSub);
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
