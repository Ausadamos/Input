using BusinessData.Interface;
using BusinessData.Property;

using InputManagement.Property;
using InputManagement.SQLFactory;

using System;
using System.Collections.Generic;

namespace InputManagement.Services
{
    public class FlowServices : DatabaseAction<FlowProcessProperty>
    {
        private string sql;

        OutputOnDbProperty resultData = new OutputOnDbProperty();
        FlowSQLFactory _sqlFactory = new FlowSQLFactory();

        public OutputOnDbProperty LoadFlowAll()
        {
            sql = _sqlFactory.LoadFlowAll();
            resultData = base.SearchBySql(sql);
            return resultData;
        }
        public OutputOnDbProperty LoadFlow()
        {
            sql = _sqlFactory.LoadFlow();
            resultData = base.SearchBySql(sql);
            return resultData;
        }


        public OutputOnDbProperty GetMaxFlowName()
        {
            sql = _sqlFactory.GetMaxFlowName();
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty InsertFlow(FlowProcessProperty dataItem)
        {
            List<string> _listSQL = _sqlFactory.InsertFlow(dataItem);
            resultData = base.InsertBySqlList(_listSQL);
            return resultData;
        }

        public OutputOnDbProperty UpdateStatus(FlowProperty dataItem)
        {
            sql = _sqlFactory.UpdateStatus(dataItem);
            resultData = base.UpdateBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchFlowNameByPurchase(PurchaseProperty dataItem)
        {
            sql = _sqlFactory.SearchFlowNameByPurchase(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }
        public OutputOnDbProperty SearchProcessByFlowName(FlowProperty dataItem)
        {
            sql = _sqlFactory.SearchProcessByFlowName(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchFlowByFlowName(FlowProperty dataItem)
        {
            sql = _sqlFactory.SearchFlowByFlowName(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }


        public OutputOnDbProperty SearchFlowByProduct(FlowProperty dataItem)
        {
            sql = _sqlFactory.SearchFlowByProduct(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchProcessSubByFlowName(FlowProperty dataItem)
        {
            sql = _sqlFactory.SearchProcessSubByFlowName(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }


        public OutputOnDbProperty CheckDuplicateFlowProcess(string dataItem)
        {
            sql = _sqlFactory.CheckDuplicateFlowProcess(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }
        public OutputOnDbProperty CallFlowRMA()
        {
            sql = _sqlFactory.CallFlowRMA();
            resultData = base.SearchBySql(sql);
            return resultData;
        }


        public override OutputOnDbProperty Delete(FlowProcessProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Insert(FlowProcessProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search(FlowProcessProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search()
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Update(FlowProcessProperty dataItem)
        {
            throw new NotImplementedException();
        }
    }
}