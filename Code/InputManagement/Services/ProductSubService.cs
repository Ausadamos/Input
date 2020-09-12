using BusinessData.Interface;
using BusinessData.Property;
using InputManagement.Property;
using InputManagement.SQLFactory;
using System;

namespace InputManagement.Services
{
    public class ProductSubService : DatabaseAction<ProductSubProperty>
    {
        OutputOnDbProperty resultData = new OutputOnDbProperty();
        ProductSubSQLFactory _sqlFactory = new ProductSubSQLFactory();
        private string sql;

        public override OutputOnDbProperty Delete(ProductSubProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Insert(ProductSubProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search(ProductSubProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search()
        {
            sql = _sqlFactory.Search();
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public override OutputOnDbProperty Update(ProductSubProperty dataItem)
        {
            throw new NotImplementedException();
        }
    }
}