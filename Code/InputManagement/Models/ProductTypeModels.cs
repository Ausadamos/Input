using BusinessData.Property;
using InputManagement.Property;
using InputManagement.Services;

namespace InputManagement.Models
{
    public class ProductTypeModels
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        ProductTypeService _services = new ProductTypeService();
        public OutputOnDbProperty SearchByProductSubCode(ProductTypeProperty dataItem)
        {
            _resultData = _services.SearchByProductSubCode(dataItem);
            return _resultData;
        }
    }
}