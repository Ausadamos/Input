using BusinessData.Property;
using InputManagement.Models;
using InputManagement.Property;
using System;
using System.Data;
using System.Windows.Forms;

namespace InputManagement.Controllers
{
    public class SearchControllers
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        SearchModels _models = new SearchModels();

        public DataTable SearchSerialInput(SearchSerialInputProperty dataItem)
        {
            DataTable _result = new DataTable();
            try
            {
                _resultData = _models.SearchSerialInput(dataItem);
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

        public DataTable SearchSerialProgress(SearchSerialProgressProperty dataItem)
        {
            DataTable _result = new DataTable();
            try
            {
                if (dataItem.SELECT_SHOW_CURRENT_PROCESS)
                {
                    _resultData = _models.SearchCurrentProgress(dataItem);
                }
                else
                {
                    _resultData = _models.SearchProgressAllProcess(dataItem);
                }

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
        public DataTable SearchOrderDetail(SearchOrderDetailProperty dataItem)
        {
            DataTable _result = new DataTable();
            try
            {
                _resultData = _models.SearchOrderDetail(dataItem);
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

        public DataTable SearchPurchase(SearchPurchaseProperty dataItem)
        {
            DataTable _result = new DataTable();
            try
            {
                _resultData = _models.SearchPurchase(dataItem);
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
        public DataTable SearchFlow()
        {
            DataTable _result = new DataTable();
            try
            {
                _resultData = _models.SearchFlow();
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
    }

}
