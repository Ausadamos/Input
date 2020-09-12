namespace InputManagement.Models
{
    public class ProcessSubModels
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

        public OutputOnDbProperty SearchProcessByProductTypeId(ProcessProperty dataItem)
        {
            _resultData = _services.SearchProcessByProductTypeId(dataItem);
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