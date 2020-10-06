using BusinessData.Property;
using InputManagement.Property;
using InputManagement.Services;

namespace InputManagement.Models
{
    public class ProcessSubModels
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        ProcessSubServices _services = new ProcessSubServices();
        public OutputOnDbProperty InsertProcessSub(ProcessSubProperty dataItem)
        {
            _resultData = _services.InsertProcessSub(dataItem);
            return _resultData;
        }
        public OutputOnDbProperty UpdateProccessStatus(ProcessSubProperty dataItem)
        {
            _resultData = _services.UpdateProccessStatus(dataItem);
            return _resultData;
        }
        public OutputOnDbProperty SearchProcessSubByProcessMainId(ProcessSubProperty dataItem)
        {
            _resultData = _services.SearchProcessSubByProcessMainId(dataItem);
            return _resultData;
        }
    }
}