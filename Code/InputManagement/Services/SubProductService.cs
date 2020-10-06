using BusinessData.Interface;
using BusinessData.Property;
using InputManagement.Property;
using InputManagement.SQLFactory;
using System;

namespace InputManagement.Services
{
    public class SubProductService : DatabaseAction<SubProductProperty>
    {
        OutputOnDbProperty resultData = new OutputOnDbProperty();
        SubProductSQLFactory _sqlFactory = new SubProductSQLFactory();
        private string sql;

        public override OutputOnDbProperty Delete(SubProductProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Insert(SubProductProperty dataItem)
        {
            sql = _sqlFactory.InsertSubProduct(dataItem);
            resultData = base.InsertBySql(sql);
            return resultData;
        }

        public override OutputOnDbProperty Search(SubProductProperty dataItem)
        {
            sql = _sqlFactory.SearchAllSubProduct(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }
        public OutputOnDbProperty SearchSubProduct(SubProductProperty dataItem)
        {
            sql = _sqlFactory.SearchSubProduct(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public override OutputOnDbProperty Update(SubProductProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search()
        {
            sql = _sqlFactory.Search();
            resultData = base.SearchBySql(sql);
            return resultData;
        }


    }
}