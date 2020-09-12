using InputManagement.Property;

namespace InputManagement.SQLFactory
{
    public class ProductTypeSQLFactory
    {
        private string sql;

        public string Search()
        {
            sql = @"SELECT * FROM `product_type`";
            return sql;
        }


        public string SearchByProductSubCode(ProductTypeProperty dataItem)
        {
            sql = @"SELECT * FROM `product_type`
                    WHERE PRODUCT_SUB_CODE = 'dataItem.PRODUCT_SUB_CODE'";

            sql = sql.Replace("dataItem.PRODUCT_SUB_CODE", dataItem.PRODUCT_SUB_CODE);
            return sql;


        }

        public string SearchProductTitle(ProductTypeProperty dataItem)
        {
            sql = @"SELECT * FROM `product_type`
                    WHERE PRODUCT_SUB_CODE = 'dataItem.PRODUCT_SUB_CODE'
                    AND PRODUCT_TITLE = 'dataItem.PRODUCT_TITLE'";

            sql = sql.Replace("dataItem.PRODUCT_SUB_CODE", dataItem.PRODUCT_SUB_CODE);
            sql = sql.Replace("dataItem.PRODUCT_TITLE", dataItem.PRODUCT_TITLE);
            return sql;


        }

        public string InsertProductTitle(ProductTypeProperty dataItem)
        {
            sql = @"INSERT INTO `product_type` (   
                              ID
                            , PRODUCT_TITLE
                            , PRODUCT_SUB_CODE
                            , DESCRIPTION
                            , CREATE_USER
                                )                              
                                (
                              SELECT 1 + coalesce((SELECT max(Id) FROM product_type), 0) 
                            , 'dataItem.PRODUCT_TITLE'
                            , 'dataItem.PRODUCT_SUB_CODE'
                            , 'dataItem.DESCRIPTION'
                            , 'dataItem.CREATE_USER'
                            )";

            sql = sql.Replace("dataItem.PRODUCT_TITLE", dataItem.PRODUCT_TITLE);
            sql = sql.Replace("dataItem.PRODUCT_SUB_CODE", dataItem.PRODUCT_SUB_CODE);
            sql = sql.Replace("dataItem.DESCRIPTION", dataItem.DESCRIPTION);
            sql = sql.Replace("dataItem.CREATE_USER", dataItem.CREATE_USER);
            sql = sql.Replace("dataItem.LAST_USER", dataItem.LAST_USER);
            sql = sql.Replace("dataItem.CREATE_DATE", dataItem.CREATE_DATE);
            sql = sql.Replace("dataItem.LAST_DATE", dataItem.LAST_DATE);


            return sql;
        }

        public string SearchExistProductType(ProductTypeProperty dataItem)
        {
            sql = @"SELECT  ID                   
                    FROM product_type 
                    WHERE  PRODUCT_TITLE = 'dataItem.PRODUCT_TITLE'
                    ";

            sql = sql.Replace("dataItem.PRODUCT_TITLE", dataItem.PRODUCT_TITLE);
            return sql;
        }

    }
}