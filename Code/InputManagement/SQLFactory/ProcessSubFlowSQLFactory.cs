using InputManagement.Property;

namespace InputManagement.SQLFactory
{
    public class ProcessSubFlowSQLFactory
    {
        private string sql;
        public string Insert(ProcessSubFlowProperty dataItem)
        {
            sql = @"INSERT INTO process_sub_flow
                    (
                     FLOW_ID
                    ,NO
                    ,PROCESS_SUB_ID
                    ,DESCRIPTION
                    ,CREATE_USER
                    )
                    VALUES
                    (
                        (SELECT ID FROM flow WHERE FLOW_NAME = 'dataItem.FLOW.FLOW_NAME' AND INUSE = 1)
                    , 'dataItem.NO'
                    , 'dataItem.PROCESS_SUB_ID'
                    , 'dataItem.DESCRIPTION'
                    , 'dataItem.CREATE_USER'
                    )";

            sql = sql.Replace("dataItem.FLOW.FLOW_NAME", dataItem.FLOW.FLOW_NAME);

            sql = sql.Replace("dataItem.FLOW_ID", dataItem.FLOW.ID);
            sql = sql.Replace("dataItem.NO", dataItem.NO);
            sql = sql.Replace("dataItem.PROCESS_SUB_ID", dataItem.PROCESS_SUB.PROCESS_SUB_ID);
            sql = sql.Replace("dataItem.DESCRIPTION", dataItem.DESCRIPTION);
            sql = sql.Replace("dataItem.CREATE_USER", dataItem.CREATE_USER);
            sql = sql.Replace("dataItem.LAST_USER", dataItem.LAST_USER);
            sql = sql.Replace("dataItem.CREATE_DATE", dataItem.CREATE_DATE);
            sql = sql.Replace("dataItem.LAST_DATE", dataItem.LAST_DATE);


            return sql;
        }

    }
}