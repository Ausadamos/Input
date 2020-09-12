using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InputManagement.SQLFactory
{
    public class GenerateSerialSQLFactory
    {

        private string sql;

        public string SearchProductType()
        {
            sql = @"SELECT tb3.ID AS PRODUCT_TYPE_ID
                        ,tb3.PRODUCT_TITLE
                        ,tb2.ID AS SERIAL_TYPE_ID
                        ,tb2.SERIAL_FORMAT
                        ,tb2.DETAIL
 
                    FROM `serial_product_type` As tb1

                    INNER JOIN serial_type As tb2 
                    ON (tb2.ID = tb1.SERIAL_TYPE_ID)

                    INNER JOIN product_type AS tb3 
                    ON (tb3.ID = tb1.PRODUCT_TYPE_ID);";

            return sql;

        }
    }
}