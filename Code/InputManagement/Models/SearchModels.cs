using BusinessData.Property;
using InputManagement.Property;
using InputManagement.Services;

namespace InputManagement.Models
{
    public class SearchModels
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        SearchServices _services = new SearchServices();

        public OutputOnDbProperty SearchSerialInput(SearchSerialInputProperty dataItem)
        {
            _resultData = _services.SearchSerialInput(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty SearchProgressAllProcess(SearchSerialProgressProperty dataItem)
        {
            _resultData = _services.SearchProgressAllProcess(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty SearchCurrentProgress(SearchSerialProgressProperty dataItem)
        {
            _resultData = _services.SearchCurrentProgress(dataItem);
            return _resultData;
        }
        public OutputOnDbProperty SearchOrderDetail(SearchOrderDetailProperty dataItem)
        {
            _resultData = _services.SearchOrderDetail(dataItem);
            return _resultData;
        }
        public OutputOnDbProperty SearchPurchase(SearchPurchaseProperty dataItem)
        {
            _resultData = _services.SearchPurchase(dataItem);
            return _resultData;
        }
        public OutputOnDbProperty SearchFlow()
        {
            _resultData = _services.SearchFlow();
            return _resultData;
        }

    }
}