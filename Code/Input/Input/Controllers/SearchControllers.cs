using BusinessData.Property;

using InputManagement.Property;
using InputManagement.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Input.Controllers
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
    }

}
