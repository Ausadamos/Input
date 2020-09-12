using BusinessData.Property;
using InputManagement.Property;
using InputManagement.Services;

namespace InputManagement.Models
{
    public class SerialProductTypeModels
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        SerialProductTypeService _services = new SerialProductTypeService();

        public OutputOnDbProperty SearchByProductTypeId(SerialProductTypeProperty dataItem)
        {
            _resultData = _services.SearchByProductTypeId(dataItem);
            return _resultData;
        }
    }
}