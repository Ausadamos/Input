﻿using BusinessData.Property;

using InputManagement.Services;
using InputManagement.Property;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InputManagement.Models
{
    public class PurchaseModels
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        PurchaseServices _services = new PurchaseServices();

        public OutputOnDbProperty LoadPurchaseAll()
        {
            _resultData = _services.LoadPurchaseAll();
            return _resultData;
        }
        public OutputOnDbProperty LastPurchase(ShipmentProperty dataItem)
        {
            _resultData = _services.LastPurchase(dataItem);
            return _resultData;
        }
        public OutputOnDbProperty UsedPurchase(ShipmentProperty dataItem)
        {
            _resultData = _services.UsedPurchase(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty SearchPurchasesOrder(OrderProperty dataItem)
        {
            _resultData = _services.SearchPurchasesOrder(dataItem);
            return _resultData;
        }
       
        public OutputOnDbProperty InsertNewPurchase(PurchaseProperty dataItem)
        {
            _resultData = _services.InsertNewPurchase(dataItem);
            return _resultData;
        }
        
        public OutputOnDbProperty UpdateProcessCardPurchase(PurchaseProperty dataItem)
        {
            _resultData = _services.UpdateProcessCardPurchase(dataItem);
            return _resultData;
        }
        public OutputOnDbProperty SearchAllProductType()
        {
            _resultData = _services.SearchAllProductType();
            return _resultData;
        }
        public OutputOnDbProperty InsertProductType(SerialProductTypeProperty dataItem)
        {
            _resultData = _services.InsertProductType(dataItem);
            return _resultData;
        }
        public OutputOnDbProperty UpdateSerialFormat(SerialProductTypeProperty dataItem)
        {
            _resultData = _services.UpdateSerialFormat(dataItem);
            return _resultData;
        }
    }
}