
using BusinessData.Interface;
using BusinessData.Property;
using InputManagement.Property;
using InputManagement.SQLFactory;
using System.Collections.Generic;

namespace InputManagement.Services
{
    public class FlowProcess_FlowProcessSubServices : DatabaseAction<FlowProcess_FlowProcessSubProperty>
    {
        private string sql;

        OutputOnDbProperty resultData = new OutputOnDbProperty();
        ProcessFlowSQLFactory _flowProcessSQLFactory = new ProcessFlowSQLFactory();
        ProcessSubFlowSQLFactory _flowProcessSubSQLFactory = new ProcessSubFlowSQLFactory();
        FlowSQLFactory _flowSQLFactory = new FlowSQLFactory();

        public override OutputOnDbProperty Delete(FlowProcess_FlowProcessSubProperty dataItem)
        {
            throw new System.NotImplementedException();
        }

        public override OutputOnDbProperty Insert(FlowProcess_FlowProcessSubProperty dataItem)
        {
            List<string> listSQL = new List<string>();
            sql = _flowSQLFactory.Insert(dataItem.listProcessFlowProperty[0].FLOW);
            listSQL.Add(sql);

            foreach (ProcessFlowProperty data in dataItem.listProcessFlowProperty)
            {
                sql = _flowProcessSQLFactory.Insert(data);
                listSQL.Add(sql);
            }

            foreach (ProcessSubFlowProperty data in dataItem.listProcessSubFlowProperty)
            {
                sql = _flowProcessSubSQLFactory.Insert(data);
                listSQL.Add(sql);
            }

            resultData = base.InsertBySqlList(listSQL);
            return resultData;
        }

        public override OutputOnDbProperty Search(FlowProcess_FlowProcessSubProperty dataItem)
        {
            throw new System.NotImplementedException();
        }

        public override OutputOnDbProperty Search()
        {
            throw new System.NotImplementedException();
        }

        public override OutputOnDbProperty Update(FlowProcess_FlowProcessSubProperty dataItem)
        {
            throw new System.NotImplementedException();
        }
    }
}