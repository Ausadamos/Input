using BusinessData.Property;
using InputManagement.Property;
using InputManagement.Services;

namespace InputManagement.Models
{
    public class PurchaseProductTypeModels
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        PurchaseProductTypeServices _services = new PurchaseProductTypeServices();

        public OutputOnDbProperty Search(PurchaseProductTypeProperty dataItem)
        {
            _resultData = _services.Search(dataItem);
            return _resultData;
        }

    }
}