using BusinessData.Property;
using InputManagement.Property;
using InputManagement.Services;
using System.Collections.Generic;

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

        public OutputOnDbProperty SearchOrderInThisYear(OrderProperty dataItem)
        {
            _resultData = _services.SearchOrderInThisYear(dataItem);
            return _resultData;
        }
        public OutputOnDbProperty SearchOrderAll(OrderProperty dataItem)
        {
            _resultData = _services.SearchOrderAll(dataItem);
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