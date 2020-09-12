using BusinessData.Property;
using InputManagement.Services;

namespace InputManagement.Models
{
    public class SerialTypeModels
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        SerialTypeServices _services = new SerialTypeServices();
        public OutputOnDbProperty Search()
        {
            _resultData = _services.Search();
            return _resultData;
        }


    }
}