using InputManagement.Property;

namespace InputManagement.SQLFactory
{
    public class ConditionSQLFactory
    {
        private string sql;
        public string SearchPartNO(ConditionProperty dataItem)
        {
            sql = @"SELECT ID
				           ,PART_NO

                    FROM `part_no`
                    WHERE REPLACE(PART_NO, ' ', '') = REPLACE('" + dataItem.PART_NO + "', ' ', '');";

            return sql;
        }

        public string InsertPartNO(ConditionProperty dataItem)
        {
            sql = @"INSERT INTO `part_no` (
                        `ID`
                        ,`PART_NO`
                    )
                    (
                        SELECT CASE WHEN COUNT(`ID`) = 0 THEN 1 ELSE MAX(`ID`)+1 END AS `ID`
                            ,'" + dataItem.PART_NO + @"' AS `PART_NO`
                        
                        FROM `part_no`
                    );";

            return sql;
        }

        public string SearchWorkOrder(ConditionProperty dataItem)
        {
            sql = @"SELECT ID
		                  ,WORK_ORDER

                    FROM `work_order`
                    WHERE REPLACE(WORK_ORDER, ' ', '') = REPLACE('" + dataItem.WORK_ORDER + "', ' ', '');";

            return sql;
        }

        public string InsertWorkOrder(ConditionProperty dataItem)
        {
            sql = @"INSERT INTO `work_order` (
                        ID
                        ,WORK_ORDER
                    )
                    (
                       SELECT CASE WHEN COUNT(`ID`) = 0 THEN 1 ELSE MAX(`ID`)+1 END AS `ID`
                            ,'" + dataItem.WORK_ORDER + @"' AS `WORK_ORDER`
                    
                       FROM `work_order`
                    );";

            return sql;
        }

        public string SearchCustomer(ConditionProperty dataItem)
        {
            sql = @"SELECT ID
                           ,CUSTOMER_NAME 

                    FROM `customer`
                    WHERE REPLACE(CUSTOMER_NAME, ' ', '') = REPLACE('" + dataItem.CUSTOMER_NAME + "', ' ', '');";

            return sql;
        }

        public string InsertCustomer(ConditionProperty dataItem)
        {
            sql = @"INSERT INTO `customer` (
                        ID
                        ,CUSTOMER_NAME
                    )
                    (
                        SELECT CASE WHEN COUNT(`ID`) = 0 THEN 1 ELSE MAX(`ID`)+1 END AS `ID`
                            ,'" + dataItem.CUSTOMER_NAME + @"' AS `CUSTOMER_NAME`

                        FROM `customer`
                    );";

            return sql;
        }


        public string SearchProduct(ConditionProperty dataItem)
        {
            sql = @"SELECT ID
                          ,PRODUCT_NAME

                    FROM `product_sub`
                    WHERE REPLACE(PRODUCT_SUB_CODE, ' ', '') = REPLACE('" + dataItem.PRODUCT_SUB_CODE + "', ' ', '');";

            return sql;
        }

        //public string InsertProduct(ConditionProperty dataItem)
        //{
        //    sql = @"INSERT INTO `product` (
        //                ID
        //                ,PRODUCT_NAME
        //            )
        //            (
        //                SELECT CASE WHEN COUNT(`ID`) = 0 THEN 1 ELSE MAX(`ID`)+1 END AS `ID`
        //                    ,'" + dataItem.PRODUCT_NAME + @"' AS `PRODUCT_NAME`

        //                FROM `product`
        //            );";

        //    return sql;
        //}

        public string SearchCondition(ConditionProperty dataItem)
        {
            sql = @"SELECT tb_1.`ID` AS `ID`
                            ,tb_1.`PRODUCT_SUB_CODE` AS `PRODUCT_SUB_CODE`
                            ,tb_1.`CUSTOMER_ID` AS `CUSTOMER_ID`
                            ,tb_1.`WORK_ORDER_ID` AS `WORK_ORDER_ID`
                            ,tb_1.`PART_NO_ID` AS `PART_NO_ID` 		   

                    FROM `condition` AS tb_1

                    INNER JOIN `product_sub` AS tb_2 
                    ON (tb_2.`PRODUCT_SUB_CODE` = tb_1.`PRODUCT_SUB_CODE`)

                    INNER JOIN `customer` AS tb_3	
                    ON (tb_3.`ID` = tb_1.`CUSTOMER_ID`)

                    INNER JOIN `work_order` AS tb_4 
                    ON (tb_4.`ID` = tb_1.`WORK_ORDER_ID`)

                    INNER JOIN `part_no` AS tb_5 
                    ON (tb_5.`ID` = tb_1.`PART_NO_ID`)

                    WHERE REPLACE(tb_2.PRODUCT_SUB_CODE, ' ', '') = REPLACE('" + dataItem.PRODUCT_SUB_CODE + @"', ' ', '')
                    AND REPLACE(tb_3.CUSTOMER_NAME, ' ', '') = REPLACE('" + dataItem.CUSTOMER_NAME + @"', ' ', '')
                    AND REPLACE(tb_4.WORK_ORDER, ' ', '') = REPLACE('" + dataItem.WORK_ORDER + @"', ' ', '')
                    AND REPLACE(tb_5.PART_NO, ' ', '') = REPLACE('" + dataItem.PART_NO + @"', ' ', '');";


            return sql;
        }

        public string InsertCondition(ConditionProperty dataItem)
        {
            sql = @"INSERT INTO `condition` (
                        ID
                        ,PART_NO_ID
                        ,WORK_ORDER_ID
                        ,CUSTOMER_ID
                        ,PRODUCT_SUB_CODE
                    )
                    (
                        SELECT CASE WHEN COUNT(`ID`) = 0 THEN 1 ELSE MAX(`ID`)+1 END AS `ID`
                            ,(SELECT `ID` FROM `part_no` WHERE REPLACE(PART_NO, ' ', '') = REPLACE('" + dataItem.PART_NO + @"', ' ', '')) AS `PART_NO_ID`
                            ,(SELECT ID FROM `work_order` WHERE REPLACE(WORK_ORDER, ' ', '') = REPLACE('" + dataItem.WORK_ORDER + @"', ' ', '')) AS `WORK_ORDER_ID`
                            ,(SELECT ID FROM `customer` WHERE REPLACE(CUSTOMER_NAME, ' ', '') = REPLACE('" + dataItem.CUSTOMER_NAME + @"', ' ', '')) `AS CUSTOMER_ID`
                            ,(SELECT PRODUCT_SUB_CODE FROM `product_sub` WHERE REPLACE(PRODUCT_SUB_CODE, ' ', '') = REPLACE('" + dataItem.PRODUCT_SUB_CODE + @"', ' ', '')) AS `PRODUCT_SUB_CODE`

                        FROM `condition` 

                   ); ";

            return sql;
        }

    }
}