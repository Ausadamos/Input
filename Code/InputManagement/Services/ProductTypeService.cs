using BusinessData.Interface;
using BusinessData.Property;
using InputManagement.Property;
using InputManagement.SQLFactory;
using System;

namespace InputManagement.Services
{
    public class ProductTypeService : DatabaseAction<ProductTypeProperty>
    {
        OutputOnDbProperty resultData = new OutputOnDbProperty();
        ProductTypeSQLFactory _sqlFactory = new ProductTypeSQLFactory();
        private string sql;

        public override OutputOnDbProperty Search(ProductTypeProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search()
        {
            sql = _sqlFactory.Search();
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchByProductSubCode(ProductTypeProperty dataItem)
        {
            sql = _sqlFactory.SearchByProductSubCode(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public override OutputOnDbProperty Insert(ProductTypeProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Update(ProductTypeProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Delete(ProductTypeProperty dataItem)
        {
            throw new NotImplementedException();
        }
    }
}