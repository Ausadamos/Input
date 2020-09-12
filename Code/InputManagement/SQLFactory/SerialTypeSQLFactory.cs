using InputManagement.Property;

namespace InputManagement.SQLFactory
{
    public class SerialTypeSQLFactory
    {
        private string sql;
        public string Search()
        {
            sql = @"SELECT * FROM `serial_type` ";
            return sql;
        }

        public string InsertSerialFormat(SerialTypeProperty dataItem)
        {
            sql = @"INSERT INTO `serial_type` (
                        ID
                        ,SERIAL_FORMAT
                        ,DETAIL
                    )
                    (
                        SELECT CASE WHEN COUNT(`ID`) = 0 THEN 1 ELSE MAX(`ID`)+1 END AS `ID`
                            ,'" + dataItem.SERIAL_FORMAT + @"' AS `SERIAL_FORMAT`
                            ,'" + dataItem.DETAIL + @"' AS `DETAIL`

                        FROM `serial_type`
                    );";

            return sql;
        }

        public string SearchSerialFormat(SerialTypeProperty dataItem)
        {
            sql = @"SELECT
                    ID
                    ,SERIAL_FORMAT
                    ,DETAIL
	
                    FROM
	                    `serial_type`
                    WHERE REPLACE(serial_type.SERIAL_FORMAT , ' ' , '') = REPLACE('" + dataItem.SERIAL_FORMAT + "', ' ' , '');";

            return sql;
        }


    }
}