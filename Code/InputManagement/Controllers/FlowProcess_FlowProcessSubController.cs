using BusinessData.Property;
using InputManagement.Models;
using InputManagement.Property;
using System;
using System.Windows.Forms;

namespace InputManagement.Controllers
{
    public class FlowProcess_FlowProcessSubController
    {

        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        FlowProcess_FlowProcessSubModels _models = new FlowProcess_FlowProcessSubModels();


        public bool Insert(FlowProcess_FlowProcessSubProperty dataItem)
        {
            bool _result = false;
            try
            {
                _resultData = _models.Insert(dataItem);
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


    }
}
