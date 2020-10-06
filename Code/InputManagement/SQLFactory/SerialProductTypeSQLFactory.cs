using InputManagement.Property;

namespace InputManagement.SQLFactory
{
    public class SerialProductTypeSQLFactory
    {
        private string sql;
        public string SearchByProductTypeId(SerialProductTypeProperty dataItem)
        {
            sql = @"SELECT * FROM `serial_product_type`
                    WHERE PRODUCT_TYPE_ID = 'dataItem.PRODUCT_TYPE_ID.ID'";
            sql = sql.Replace("dataItem.PRODUCT_TYPE_ID.ID", dataItem.PRODUCT_TYPE.ID);
            return sql;
        }

        public string InsertSerialProductType(SerialProductTypeProperty dataItem)
        {
            sql = @"INSERT INTO `serial_product_type` (   
                                  ID
                                , PRODUCT_TYPE_ID
                                , SERIAL_TYPE_ID
                                , INUSE
                                , DESCRIPTION
                                , CREATE_USER
                                )                               
                                (
                                   SELECT 1 + coalesce((SELECT max(Id) FROM serial_product_type), 0) 
                                , (SELECT id FROM product_type WHERE PRODUCT_TITLE = 'dataItem.SERIAL_TYPE.PRODUCT_TITLE' AND PRODUCT_SUB_CODE = 'dataItem.SERIAL_TYPE.PRODUCT_SUB_CODE')
                                ,  (SELECT id FROM serial_type WHERE SERIAL_FORMAT = 'dataItem.SERIAL_TYPE.SERIAL_FORMAT')
                                ,  1
                                , 'dataItem.DESCRIPTION'
                                , 'dataItem.CREATE_USER'
                        )";

            sql = sql.Replace("dataItem.ID", dataItem.ID);

            sql = sql.Replace("dataItem.SERIAL_TYPE.PRODUCT_TITLE", dataItem.PRODUCT_TYPE.PRODUCT_TITLE);
            sql = sql.Replace("dataItem.SERIAL_TYPE.PRODUCT_SUB_CODE", dataItem.PRODUCT_TYPE.PRODUCT_SUB_CODE);

            sql = sql.Replace("dataItem.SERIAL_TYPE.SERIAL_FORMAT", dataItem.SERIAL_TYPE.SERIAL_FORMAT);

            sql = sql.Replace("dataItem.INUSE", dataItem.INUSE);
            sql = sql.Replace("dataItem.DESCRIPTION", dataItem.DESCRIPTION);
            sql = sql.Replace("dataItem.CREATE_USER", dataItem.CREATE_USER);
            sql = sql.Replace("dataItem.LAST_USER", dataItem.LAST_USER);
            sql = sql.Replace("dataItem.CREATE_DATE", dataItem.CREATE_DATE);
            sql = sql.Replace("dataItem.LAST_DATE", dataItem.LAST_DATE);

            return sql;
        }

        public string SearchExistSerialProductType(SerialProductTypeProperty dataItem)
        {
            sql = @"SELECT 
                                  ID
                                , PRODUCT_TYPE_ID
                                , SERIAL_TYPE_ID
                                , INUSE
                                , DESCRIPTION
                                , CREATE_USER
                                , LAST_USER
                                , CREATE_DATE
                                , LAST_DATE
                                FROM `serial_product_type`
                                WHERE  
                                PRODUCT_TYPE_ID = 'dataItem.PRODUCT_TYPE_ID'
                                AND SERIAL_TYPE_ID  = 'dataItem.SERIAL_TYPE_ID'
                                AND INUSE = 1;
                                ";

            sql = sql.Replace("dataItem.PRODUCT_TYPE_ID", dataItem.PRODUCT_TYPE.ID);
            sql = sql.Replace("dataItem.SERIAL_TYPE_ID", dataItem.SERIAL_TYPE.ID);

            return sql;
        }

        public string UpdateInuseSerialProductType(SerialProductTypeProperty dataItem)
        {
            sql = @"UPDATE `serial_product_type`
                    SET INUSE  = '0' 
                    WHERE INUSE = '1'
                    AND PRODUCT_TYPE_ID = 'dataItem.PRODUCT_TYPE_ID'
                    ";
            sql = sql.Replace("dataItem.PRODUCT_TYPE_ID", dataItem.PRODUCT_TYPE.ID);

            return sql;
        }



    }
}