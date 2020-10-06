using BusinessData.Property;
using InputManagement.Property;
using InputManagement.Services;

namespace InputManagement.Models
{
    public class ProcessModels
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        ProcessService _services = new ProcessService();
        public OutputOnDbProperty InsertProcess(ProcessProperty dataItem)
        {
            _resultData = _services.InsertProcess(dataItem);
            return _resultData;
        }
        public OutputOnDbProperty UpdateProccessStatus(ProcessProperty dataItem)
        {
            _resultData = _services.UpdateProccessStatus(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty SearchProcessAll()
        {
            _resultData = _services.SearchProcessAll();
            return _resultData;
        }

        public OutputOnDbProperty SearchProcessByProductSubCode(ProcessProperty dataItem)
        {
            _resultData = _services.SearchProcessByProductSubCode(dataItem);
            return _resultData;
        }



        public OutputOnDbProperty SearchResultAll()
        {
            _resultData = _services.SearchResultAll();
            return _resultData;
        }

        public OutputOnDbProperty SearchProcessInUse()
        {
            _resultData = _services.SearchProcessInUse();
            return _resultData;
        }
        public OutputOnDbProperty SearchProcessNonUse()
        {
            _resultData = _services.SearchProcessNonUse();
            return _resultData;
        }
    }
}