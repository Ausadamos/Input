using BusinessData.Property;

using InputManagement.Services;
using InputManagement.Property;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InputManagement.Models
{
    public class FlowModels
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        FlowServices _services = new FlowServices();

        public OutputOnDbProperty LoadFlowAll()
        {
            _resultData = _services.LoadFlowAll();
            return _resultData;
        }
        public OutputOnDbProperty LoadFlow()
        {
            _resultData = _services.LoadFlow();
            return _resultData;
        }
        
        public OutputOnDbProperty GetMaxFlowName()
        {
            _resultData = _services.GetMaxFlowName();
            return _resultData;
        }

        public OutputOnDbProperty SearchFlowNameByPurchase(PurchaseProperty dataItem)
        {
            _resultData = _services.SearchFlowNameByPurchase(dataItem);
            return _resultData;
        }
        public OutputOnDbProperty SearchProcessByFlowName(FlowProperty dataItem)
        {
            _resultData = _services.SearchProcessByFlowName(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty InsertFlow(FlowProcessProperty dataItem)
        {
            _resultData = _services.InsertFlow(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty UpdateStatus(FlowProperty dataItem)
        {
            _resultData = _services.UpdateStatus(dataItem);
            return _resultData;
        }
        public OutputOnDbProperty CheckDuplicateFlowProcess(string dataItem)
        {
            _resultData = _services.CheckDuplicateFlowProcess(dataItem);
            return _resultData;
        }
        public OutputOnDbProperty CallFlowRMA()
        {
            _resultData = _services.CallFlowRMA();
            return _resultData;
        }
    }
}