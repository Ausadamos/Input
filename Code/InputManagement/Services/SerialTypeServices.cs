using BusinessData.Interface;
using BusinessData.Property;
using InputManagement.Property;
using InputManagement.SQLFactory;
using System;

namespace InputManagement.Services
{
    public class SerialTypeServices : DatabaseAction<SerialTypeProperty>
    {
        OutputOnDbProperty resultData = new OutputOnDbProperty();
        SerialTypeSQLFactory _sqlFactory = new SerialTypeSQLFactory();
        private string sql;

        public override OutputOnDbProperty Delete(SerialTypeProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Insert(SerialTypeProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search(SerialTypeProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search()
        {
            sql = _sqlFactory.Search();
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public override OutputOnDbProperty Update(SerialTypeProperty dataItem)
        {
            throw new NotImplementedException();
        }
    }
}