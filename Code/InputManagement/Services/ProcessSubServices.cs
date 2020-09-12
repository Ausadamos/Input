using BusinessData.Interface;
using BusinessData.Property;
using InputManagement.Property;
using InputManagement.SQLFactory;
using System;

namespace InputManagement.Services
{
    public class ProcessSubServices : DatabaseAction<ProcessSubProperty>
    {
        OutputOnDbProperty resultData = new OutputOnDbProperty();
        ProcessSubSQLFactory _sqlFactory = new ProcessSubSQLFactory();
        private string sql;

        public OutputOnDbProperty InsertProcessSub(ProcessSubProperty dataItem)
        {
            sql = _sqlFactory.InsertProcessSub(dataItem);
            resultData = base.InsertBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty UpdateProccessStatus(ProcessSubProperty dataItem)
        {
            sql = _sqlFactory.UpdateProccessStatus(dataItem);
            resultData = base.UpdateBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchProcessSubByProcessMainId(ProcessSubProperty dataItem)
        {
            sql = _sqlFactory.SearchProcessSubByProcessMainId(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public override OutputOnDbProperty Delete(ProcessSubProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Insert(ProcessSubProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search(ProcessSubProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search()
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Update(ProcessSubProperty dataItem)
        {
            throw new NotImplementedException();
        }


    }
}