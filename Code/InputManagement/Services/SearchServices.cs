using BusinessData.Interface;
using BusinessData.Property;

using InputManagement.Property;
using InputManagement.SQLFactory;

using System;

namespace InputManagement.Services
{
    public class SearchServices : DatabaseAction<ConditionProperty>
    {
        OutputOnDbProperty resultData = new OutputOnDbProperty();
        SearchSQLFactory _sqlFactory = new SearchSQLFactory();
        private string sql;

        public OutputOnDbProperty SearchSerialInput(SearchSerialInputProperty dataItem)
        {
            sql = _sqlFactory.SearchSerialInput(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchProgressAllProcess(SearchSerialProgressProperty dataItem)
        {
            sql = _sqlFactory.SearchProgressAllProcess(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchCurrentProgress(SearchSerialProgressProperty dataItem)
        {
            sql = _sqlFactory.SearchCurrentProgress(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }
        public OutputOnDbProperty SearchOrderDetail(SearchOrderDetailProperty dataItem)
        {
            sql = _sqlFactory.SearchOrderDetail(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }
        public OutputOnDbProperty SearchPurchase(SearchPurchaseProperty dataItem)
        {
            sql = _sqlFactory.SearchPurchase(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }
        public OutputOnDbProperty SearchFlow()
        {
            sql = _sqlFactory.SearchFlow();
            resultData = base.SearchBySql(sql);
            return resultData;
        }
        public override OutputOnDbProperty Delete(ConditionProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Insert(ConditionProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search(ConditionProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search()
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Update(ConditionProperty dataItem)
        {
            throw new NotImplementedException();
        }
    }
}