using InputManagement.Property;

namespace InputManagement.SQLFactory
{
    public class ProcessSQLFactory
    {
        private string sql;
        public string InsertProcess(ProcessProperty dataItem)
        {

            sql = @"INSERT INTO `process` (
						  ID
                        , PRODUCT_TYPE_ID
                        , PROCESS_NAME
                        , INUSE
                        , DESCRIPTION
                        , CREATE_USER
                        )
                        (
                          SELECT 1 + coalesce((SELECT max(Id) FROM process), 0) 
                        , 'dataItem.PRODUCT_TYPE_ID'
                        , 'dataItem.PROCESS_NAME'
                        , 1
                        , 'dataItem.DESCRIPTION'
                        , 'dataItem.CREATE_USER'
                    );";


            sql = sql.Replace("dataItem.PRODUCT_TYPE_ID", dataItem.PRODUCT_TYPE_ID);
            sql = sql.Replace("dataItem.PROCESS_NAME", dataItem.PROCESS_NAME);
            sql = sql.Replace("dataItem.INUSE", dataItem.INUSE);
            sql = sql.Replace("dataItem.DESCRIPTION", dataItem.DESCRIPTION);
            sql = sql.Replace("dataItem.CREATE_USER", dataItem.CREATE_USER);
            sql = sql.Replace("dataItem.LAST_USER", dataItem.LAST_USER);
            sql = sql.Replace("dataItem.CREATE_DATE", dataItem.CREATE_DATE);
            sql = sql.Replace("dataItem.LAST_DATE", dataItem.LAST_DATE);


            return sql;
        }
        public string UpdateProccessStatus(ProcessProperty dataItem)
        {
            sql = @"UPDATE `process` 
                    SET INUSE = '" + dataItem.INUSE + @"'
                    WHERE PROCESS_NAME = '" + dataItem.PROCESS_NAME + @"' 
                    AND PRODUCT_TYPE_ID  = '" + dataItem.PRODUCT_TYPE_ID + @"' 
                    AND INUSE = 1 ";

            return sql;
        }

        public string SearchProcessByProductTypeId(ProcessProperty dataItem)
        {
            sql = @"SELECT * FROM  `process` 
                    WHERE PRODUCT_TYPE_ID = '" + dataItem.PRODUCT_TYPE_ID + "'";

            return sql;
        }

        public string SearchProcessAll()
        {
            sql = @"SELECT tb_1.`ID`
                          ,tb_1.`PROCESS_NAME`
                          ,tb_1.`INUSE`

                    FROM `process` AS tb_1
                    WHERE INUSE = '1'
                    ORDER BY ID ASC;";

            return sql;
        }

        public string SearchProcessInUse()
        {
            sql = @"SELECT tb_1.`ID`
                          ,tb_1.`PROCESS_NAME`
                          ,tb_1.`INUSE`

                    FROM `process` AS tb_1
                    WHERE tb_1.`INUSE` = '1'
                    ORDER BY ID ASC;";

            return sql;
        }
        public string SearchProcessNonUse()
        {
            sql = @"SELECT tb_1.`ID`
                          ,tb_1.`PROCESS_NAME`
                          ,tb_1.`INUSE`

                    FROM `process` AS tb_1
                    WHERE tb_1.`INUSE` = '0'
                    ORDER BY ID ASC;";
            return sql;
        }

        public string SearchResultAll()
        {
            sql = @"SELECT `ID`
                          ,`RESULT`

                    FROM `result`
                    ORDER BY ID ASC;";

            return sql;
        }
    }
}