using BusinessData.Property;

using InputManagement.Services;
using InputManagement.Property;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InputManagement.Models
{
    public class ShipmentModels
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        ShipmentService _services = new ShipmentService();

        public OutputOnDbProperty SearchSerailShipping(ShipmentProperty dataItem)
        {
            _resultData = _services.SearchSerailShipping(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty SearchSerailShippingReturn(ShipmentProperty dataItem)
        {
            _resultData = _services.SearchSerailShippingReturn(dataItem);
            return _resultData;
        }
    }
}