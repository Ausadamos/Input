using InputManagement.Property;

namespace InputManagement.SQLFactory
{
    public class ProcessSubSQLFactory
    {
        private string sql;
        public string InsertProcessSub(ProcessSubProperty dataItem)
        {

            sql = @"INSERT INTO `process_sub` (
						  PROCESS_SUB_ID
                        , PROCESS_ID
                        , SUB_PROCESS_NAME
                        , INUSE
                        , DESCRIPTION
                        , CREATE_USER
                        )
                        (
                          SELECT 1 + coalesce((SELECT max(PROCESS_SUB_ID) FROM process_sub), 0) 
                        , 'dataItem.PROCESS_ID'
                        , 'dataItem.SUB_PROCESS_NAME'
                        , 1
                        , 'dataItem.DESCRIPTION'
                        , 'dataItem.CREATE_USER'
                    );";


            sql = sql.Replace("dataItem.PROCESS_SUB_ID", dataItem.PROCESS_SUB_ID);
            sql = sql.Replace("dataItem.PROCESS_ID", dataItem.PROCESS_ID);
            sql = sql.Replace("dataItem.SUB_PROCESS_NAME", dataItem.SUB_PROCESS_NAME);
            sql = sql.Replace("dataItem.INUSE", dataItem.INUSE);
            sql = sql.Replace("dataItem.DESCRIPTION", dataItem.DESCRIPTION);
            sql = sql.Replace("dataItem.CREATE_USER", dataItem.CREATE_USER);
            sql = sql.Replace("dataItem.LAST_USER", dataItem.LAST_USER);
            sql = sql.Replace("dataItem.CREATE_DATE", dataItem.CREATE_DATE);
            sql = sql.Replace("dataItem.LAST_DATE", dataItem.LAST_DATE);



            return sql;
        }
        public string UpdateProccessStatus(ProcessSubProperty dataItem)
        {
            sql = @"UPDATE `process_sub` 
                    SET INUSE = '" + dataItem.INUSE + @"'  , LAST_USER = '" + dataItem.LAST_USER + @"' , LAST_DATE = NOW()
                    WHERE SUB_PROCESS_NAME = '" + dataItem.SUB_PROCESS_NAME + @"' 
                    AND PROCESS_ID  = '" + dataItem.PROCESS_ID + @"'";

            return sql;
        }

        public string SearchProcessSubByProcessMainId(ProcessSubProperty dataItem)
        {
            sql = @"SELECT * FROM  `process_sub` 
                    WHERE PROCESS_ID = '" + dataItem.PROCESS_ID + "'";

            return sql;
        }
    }
}