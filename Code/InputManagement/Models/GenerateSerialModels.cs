using BusinessData.Property;

using InputManagement.Services;
using InputManagement.Property;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InputManagement.Models
{
    public class GenerateSerialModels
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        GenerateSerialServices _services = new GenerateSerialServices();

        public OutputOnDbProperty SearchProductType()
        {
            _resultData = _services.SearchProductType();
            return _resultData;
        }
    }
}