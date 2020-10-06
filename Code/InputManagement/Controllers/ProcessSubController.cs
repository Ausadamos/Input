using BusinessData.Property;
using InputManagement.Models;
using InputManagement.Property;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InputManagement.Controllers
{
    public class ProcessSubController
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

        //public List<ProcessSubProperty> SearchProcessSubAll()
        //{
        //    List<ProcessSubProperty> _result = new List<ProcessSubProperty>();
        //    try
        //    {
        //        _resultData = _models.SearchProcessSubAll();
        //        if (_resultData.StatusOnDb == true)
        //        {
        //            if (_resultData.ResultOnDb.Rows.Count > 0)
        //            {
        //                for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
        //                {
        //                    ProcessSubProperty _ProcessSub = new ProcessSubProperty()
        //                    {
        //                        ID = _resultData.ResultOnDb.Rows[i]["ID"].ToString(),
        //                        ProcessSub_NAME = _resultData.ResultOnDb.Rows[i]["ProcessSub_NAME"].ToString(),
        //                        INUSE = _resultData.ResultOnDb.Rows[i]["INUSE"].ToString()
        //                    };
        //                    _result.Add(_ProcessSub);
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

        public List<ProcessSubProperty> SearchProcessSubByProcessMainId(ProcessSubProperty dataItem)
        {
            List<ProcessSubProperty> _result = new List<ProcessSubProperty>();
            try
            {
                _resultData = _models.SearchProcessSubByProcessMainId(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        for (int i = 0; i < _resultData.ResultOnDb.Rows.Count; i++)
                        {
                            ProcessSubProperty _ProcessSub = new ProcessSubProperty()
                            {

                                PROCESS_SUB_ID = _resultData.ResultOnDb.Rows[i]["PROCESS_SUB_ID"].ToString(),
                                PROCESS_ID = _resultData.ResultOnDb.Rows[i]["PROCESS_ID"].ToString(),
                                SUB_PROCESS_NAME = _resultData.ResultOnDb.Rows[i]["SUB_PROCESS_NAME"].ToString(),
                                INUSE = _resultData.ResultOnDb.Rows[i]["INUSE"].ToString(),
                                DESCRIPTION = _resultData.ResultOnDb.Rows[i]["DESCRIPTION"].ToString(),
                                CREATE_USER = _resultData.ResultOnDb.Rows[i]["CREATE_USER"].ToString(),
                                LAST_USER = _resultData.ResultOnDb.Rows[i]["LAST_USER"].ToString(),
                                CREATE_DATE = _resultData.ResultOnDb.Rows[i]["CREATE_DATE"].ToString(),
                                LAST_DATE = _resultData.ResultOnDb.Rows[i]["LAST_DATE"].ToString(),


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
    }
}
