using BusinessData.Property;
using InputManagement.Property;
using InputManagement.Services;

namespace InputManagement.Models
{
    public class SubProductModels
    {

        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        SubProductService _services = new SubProductService();
        public OutputOnDbProperty Search()
        {
            _resultData = _services.Search();
            return _resultData;
        }
        public OutputOnDbProperty SearchSubProduct(SubProductProperty dataItem)
        {
            _resultData = _services.Search(dataItem);
            return _resultData;
        }
    }
}