using BusinessData.Property;

using InputManagement.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InputManagement.Property;

namespace InputManagement.Models
{
    public class InputOrderModels
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        InputOrderServicecs _services = new InputOrderServicecs();

        
        public OutputOnDbProperty GetOrderActualInput()
        {
            _resultData = _services.GetOrderActualInput();
            return _resultData;
        }

        public OutputOnDbProperty SearchOrderInThisYear()
        {
            _resultData = _services.SearchOrderInThisYear();
            return _resultData;
        }
        public OutputOnDbProperty SearchOrderAll()
        {
            _resultData = _services.SearchOrderAll();
            return _resultData;
        }
        public OutputOnDbProperty SearchOrderInput(OrderProperty dataItem)
        {
            _resultData = _services.SearchOrderInput(dataItem);
            return _resultData;
        }
        public OutputOnDbProperty SearchSerialUpdatePO(InputProperty dataItem)
        {
            _resultData = _services.SearchSerialUpdatePO(dataItem);
            return _resultData;
        }



        
        public OutputOnDbProperty SearchOrderHistory(OrderProperty dataItem)
        {
            _resultData = _services.SearchOrderHistory(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty SearchInputAll()
        {
            _resultData = _services.SearchInputAll();
            return _resultData;
        }

        public OutputOnDbProperty SeachOrderQty(OrderProperty dataItem)
        {
            _resultData = _services.SeachOrderQty(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty GetDatetimeNow_InDB()
        {
            _resultData = _services.GetDatetimeNow_InDB();
            return _resultData;
        }


        public OutputOnDbProperty InsertOrder(List<OrderProperty> dataItem)
        {
            _resultData = _services.InsertOrder(dataItem);
            return _resultData;
        }
        public OutputOnDbProperty SearchPO(PurchaseOrderProperty dataItem)
        {
            _resultData = _services.SearchPO(dataItem);
            return _resultData;
        }


        public OutputOnDbProperty UpdateInput(OrderProperty dataItem)
        {
            _resultData = _services.UpdateInput(dataItem);
            return _resultData;
        }

    }
}