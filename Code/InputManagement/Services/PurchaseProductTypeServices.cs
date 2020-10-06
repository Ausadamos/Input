using BusinessData.Interface;
using BusinessData.Property;
using InputManagement.Property;
using InputManagement.SQLFactory;
using System;

namespace InputManagement.Services
{
    public class PurchaseProductTypeServices : DatabaseAction<PurchaseProductTypeProperty>
    {
        OutputOnDbProperty resultData = new OutputOnDbProperty();
        PurchaseProductTypeSQLFactory _sqlFactory = new PurchaseProductTypeSQLFactory();
        private string sql;

        public override OutputOnDbProperty Delete(PurchaseProductTypeProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Insert(PurchaseProductTypeProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search(PurchaseProductTypeProperty dataItem)
        {
            sql = _sqlFactory.Search(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public override OutputOnDbProperty Search()
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Update(PurchaseProductTypeProperty dataItem)
        {
            throw new NotImplementedException();
        }
    }
}