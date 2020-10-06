using InputManagement.Property;

namespace InputManagement.SQLFactory
{
    public class SubProductSQLFactory
    {
        private string sql;
        public string Search()
        {
            sql = @"SELECT * FROM `product_sub`
                    WHERE PRODUCT_MAIN_CODE = 'PDM-0001'";
            return sql;
        }
        public string SearchAllSubProduct(SubProductProperty dataItem)
        {
            sql = @"SELECT tb1.PRODUCT_SUB_CODE
			               ,tb1.PRODUCT_SUB_NAME 

                    FROM product_sub AS tb1

                    WHERE tb1.PRODUCT_MAIN_CODE = 'dataItem.PRODUCT_MAIN_CODE'";

            sql = sql.Replace("dataItem.PRODUCT_MAIN_CODE", dataItem.PRODUCT_MAIN_CODE);

            return sql;
        }
        public string SearchSubProduct(SubProductProperty dataItem)
        {
            sql = @"SELECT tb1.PRODUCT_SUB_CODE
			               ,tb1.PRODUCT_SUB_NAME 

                    FROM product_sub AS tb1

                    WHERE tb1.PRODUCT_SUB_NAME = 'dataItem.PRODUCT_SUB_NAME'";

            sql = sql.Replace("dataItem.PRODUCT_SUB_NAME", dataItem.PRODUCT_SUB_NAME);

            return sql;
        }
        public string InsertSubProduct(SubProductProperty dataItem)
        {
            sql = @"INSERT INTO `product_sub`
                    (
                        PRODUCT_MAIN_CODE,
                        PRODUCT_SUB_CODE,
                        PRODUCT_SUB_NAME,
                        CREATE_USER
                    )

                    VALUES
                    
                    (
                        dataItem.PRODUCT_MAIN_CODE,
                        dataItem.PRODUCT_SUB_CODE,
                        dataItem.PRODUCT_SUB_NAME,
                        dataItem.CREATE_USER

                    )";

            sql = sql.Replace("dataItem.PRODUCT_MAIN_CODE", dataItem.PRODUCT_MAIN_CODE);
            sql = sql.Replace("dataItem.PRODUCT_SUB_CODE", dataItem.PRODUCT_SUB_CODE);
            sql = sql.Replace("dataItem.PRODUCT_SUB_NAME", dataItem.PRODUCT_SUB_NAME);
            sql = sql.Replace("dataItem.CREATE_USER", dataItem.CREATE_USER);

            return sql;
        }
    }
}