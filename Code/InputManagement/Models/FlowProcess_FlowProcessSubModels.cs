using BusinessData.Property;
using InputManagement.Property;
using InputManagement.Services;

namespace InputManagement.Models
{
    public class FlowProcess_FlowProcessSubModels
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        FlowProcess_FlowProcessSubServices _services = new FlowProcess_FlowProcessSubServices();

        public OutputOnDbProperty Insert(FlowProcess_FlowProcessSubProperty dataItem)
        {
            _resultData = _services.Insert(dataItem);
            return _resultData;
        }

    }
}