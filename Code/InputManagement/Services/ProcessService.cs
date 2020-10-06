using BusinessData.Interface;
using BusinessData.Property;

using InputManagement.Property;
using InputManagement.SQLFactory;

using System;

namespace InputManagement.Services
{
    public class ProcessService : DatabaseAction<FlowProcessProperty>
    {
        private string sql;

        OutputOnDbProperty resultData = new OutputOnDbProperty();
        ProcessSQLFactory _sqlFactory = new ProcessSQLFactory();


        public OutputOnDbProperty InsertProcess(ProcessProperty dataItem)
        {
            sql = _sqlFactory.InsertProcess(dataItem);
            resultData = base.InsertBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty UpdateProccessStatus(ProcessProperty dataItem)
        {
            sql = _sqlFactory.UpdateProccessStatus(dataItem);
            resultData = base.UpdateBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchProcessByProductSubCode(ProcessProperty dataItem)
        {
            sql = _sqlFactory.SearchProcessByProductSubCode(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchProcessAll()
        {
            sql = _sqlFactory.SearchProcessAll();
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchResultAll()
        {
            sql = _sqlFactory.SearchResultAll();
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchProcessInUse()
        {
            sql = _sqlFactory.SearchProcessInUse();
            resultData = base.SearchBySql(sql);
            return resultData;
        }
        public OutputOnDbProperty SearchProcessNonUse()
        {
            sql = _sqlFactory.SearchProcessNonUse();
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