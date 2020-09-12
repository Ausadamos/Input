using BusinessData.Property;
using InputManagement.Services;

namespace InputManagement.Models
{
    public class ProductSubModels
    {

        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        ProductSubService _services = new ProductSubService();
        public OutputOnDbProperty Search()
        {
            _resultData = _services.Search();
            return _resultData;
        }

    }
}