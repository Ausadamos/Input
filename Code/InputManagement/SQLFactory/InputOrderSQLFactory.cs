using InputManagement.Property;

namespace InputManagement.SQLFactory
{
    public class InputOrderSQLFactory
    {
        private string sql;
        public string GetDatetimeNow_InDB()
        {
            sql = @"SELECT NOW() AS DATETIME_NOW;";
            return sql;
        }

        public string GetOrderActualInput()
        {
            sql = @"
                
                SELECT `FFT_ORDER_ID`
                    ,SUM(`QUANTITY`) AS `ACTUAL_INPUT` 

                FROM `input` 

                GROUP BY `FFT_ORDER_ID`
                
                ";

            return sql;
        }

        public string SearchOrderInThisYear()
        {
            //##  !!! Have different  database name join in Qry. !!!!!!!!!!!!!!!  ###################################
            // Product ID 11 is Cavity

            sql = @"
                        SELECT	`tb_1`.`FFT_ORDER_ID` AS `FFT_ORDER_ID`
                            ,DATE_FORMAT(`tb_1`.`ORDER_DATE`, '%Y-%m-%d') AS `ORDER_DATE`
                            ,`tb_1`.`QUANTITY` AS `ORDER_QUANTITY`
                            ,`tb_5`.`ORDER_TYPE_NAME` AS `ORDER_TYPE_NAME`
                            ,`tb_2`.`PRODUCT_NAME` AS `PRODUCT_NAME`
                            ,`tb_3`.`CUSTOMER_NAME` AS `CUSTOMER_NAME`
                            ,`tb_1`.`WORK_ORDER` AS `WORK_ORDER`
                            ,`tb_1`.`PART_NO` AS `PART_NO`
                            ,`tb_1`.`SPEC_NO` AS `SPEC_NO`
                            ,`tb_4`.`SHIPPING_DESTINATION` AS `SHIPPING_DESTINATION`
                            ,DATE_FORMAT(`tb_1`.`CUSTOMER_REQUEST`, '%Y-%m-%d') AS `CUSTOMER_REQUEST`
                        

                        FROM `fft_order` AS `tb_1`

                        INNER JOIN `item_product` AS `tb_2` 
                        ON(`tb_2`.`PRODUCT_ID` = `tb_1`.`PRODUCT_ID`)

                        INNER JOIN `item_customer` AS `tb_3` 
                        ON(`tb_3`.`CUSTOMER_ID` = `tb_1`.`CUSTOMER_ID`)

                        INNER JOIN `item_ship_destination` AS `tb_4` 
                        ON(`tb_4`.`SHIP_DEST_ID` = `tb_1`.`SHIP_DEST_ID`)

                        INNER JOIN `item_order_type` AS `tb_5` 
                        ON(`tb_5`.`ORDER_TYPE_ID` = `tb_1`.`ORDER_TYPE_ID`)

                        WHERE `tb_1`.`PRODUCT_ID` = '11'
                        AND YEAR(`tb_1`.`ORDER_DATE`) = YEAR(NOW())

                        ORDER BY `tb_1`.`ORDER_DATE` DESC,`tb_1`.`FFT_ORDER_ID` DESC;
";

            return sql;
        }

        public string SearchOrderInThisYear(OrderProperty dataItem)
        {
            //##  !!! Have different  database name join in Qry. !!!!!!!!!!!!!!!  ###################################
            // Product ID 11 is Cavity

            sql = @"

                        SELECT	`tb_1`.`FFT_ORDER_ID` AS `FFT_ORDER_ID`
	                        ,DATE_FORMAT(`tb_1`.`ORDER_DATE`, '%Y-%m-%d') AS `ORDER_DATE`
	                        ,`tb_1`.`QUANTITY` AS `ORDER_QUANTITY`
	                        ,`tb_5`.`ORDER_TYPE_NAME` AS `ORDER_TYPE_NAME`
	                        ,`tb_2`.`PRODUCT_NAME` AS `PRODUCT_NAME`
	                        ,`tb_3`.`CUSTOMER_NAME` AS `CUSTOMER_NAME`
	                        ,`tb_1`.`WORK_ORDER` AS `WORK_ORDER`
	                        ,`tb_1`.`PART_NO` AS `PART_NO`
	                        ,`tb_1`.`SPEC_NO` AS `SPEC_NO`
	                        ,`tb_4`.`SHIPPING_DESTINATION` AS `SHIPPING_DESTINATION`
	                        ,DATE_FORMAT(`tb_1`.`CUSTOMER_REQUEST`, '%Y-%m-%d') AS `CUSTOMER_REQUEST`
                        

                        FROM `fft_order` AS `tb_1`

                        INNER JOIN `item_product` AS `tb_2` 
                        ON(`tb_2`.`PRODUCT_ID` = `tb_1`.`PRODUCT_ID`)

                        INNER JOIN `item_customer` AS `tb_3` 
                        ON(`tb_3`.`CUSTOMER_ID` = `tb_1`.`CUSTOMER_ID`)

                        INNER JOIN `item_ship_destination` AS `tb_4` 
                        ON(`tb_4`.`SHIP_DEST_ID` = `tb_1`.`SHIP_DEST_ID`)

                        INNER JOIN `item_order_type` AS `tb_5` 
                        ON(`tb_5`.`ORDER_TYPE_ID` = `tb_1`.`ORDER_TYPE_ID`)
                        
                        INNER JOIN `item_product` AS `tb6`
                        ON (tb6.PRODUCT_ID = tb_1.PRODUCT_ID)
                        
                        WHERE `tb6`.`PRODUCT_NAME` = 'dataItem.SUB_PRODUCT.PRODUCT_SUB_NAME'
                        AND `tb_5`.`ORDER_TYPE_NAME` LIKE '" + dataItem.ORDER_TYPE_NAME + @"%'
                        AND YEAR(`tb_1`.`ORDER_DATE`) = YEAR(NOW())

                        ORDER BY `tb_1`.`ORDER_DATE` DESC,`tb_1`.`FFT_ORDER_ID` DESC;";

            sql = sql.Replace("dataItem.SUB_PRODUCT.PRODUCT_SUB_NAME", dataItem.Sub_Product.PRODUCT_SUB_NAME);

            return sql;
        }

        public string SearchOrderAll()
        {
            //##  !!! Have different  database name join in Qry. !!!!!!!!!!!!!!!  ###################################
            // Product ID 11 is Cavity

            sql = @"

                        SELECT	`tb_1`.`FFT_ORDER_ID` AS `FFT_ORDER_ID`
	                        ,DATE_FORMAT(`tb_1`.`ORDER_DATE`, '%Y-%m-%d') AS `ORDER_DATE`
	                        ,`tb_1`.`QUANTITY` AS `ORDER_QUANTITY`
	                        ,`tb_5`.`ORDER_TYPE_NAME` AS `ORDER_TYPE_NAME`
	                        ,`tb_2`.`PRODUCT_NAME` AS `PRODUCT_NAME`
	                        ,`tb_3`.`CUSTOMER_NAME` AS `CUSTOMER_NAME`
	                        ,`tb_1`.`WORK_ORDER` AS `WORK_ORDER`
	                        ,`tb_1`.`PART_NO` AS `PART_NO`
	                        ,`tb_1`.`SPEC_NO` AS `SPEC_NO`
	                        ,`tb_4`.`SHIPPING_DESTINATION` AS `SHIPPING_DESTINATION`
	                        ,DATE_FORMAT(`tb_1`.`CUSTOMER_REQUEST`, '%Y-%m-%d') AS `CUSTOMER_REQUEST`
                        

                        FROM `fft_order` AS `tb_1`

                        INNER JOIN `item_product` AS `tb_2` 
                        ON(`tb_2`.`PRODUCT_ID` = `tb_1`.`PRODUCT_ID`)

                        INNER JOIN `item_customer` AS `tb_3` 
                        ON(`tb_3`.`CUSTOMER_ID` = `tb_1`.`CUSTOMER_ID`)

                        INNER JOIN `item_ship_destination` AS `tb_4` 
                        ON(`tb_4`.`SHIP_DEST_ID` = `tb_1`.`SHIP_DEST_ID`)

                        INNER JOIN `item_order_type` AS `tb_5` 
                        ON(`tb_5`.`ORDER_TYPE_ID` = `tb_1`.`ORDER_TYPE_ID`)

                        WHERE `tb_1`.`PRODUCT_ID` = '11'

                        ORDER BY `tb_1`.`ORDER_DATE` DESC,`tb_1`.`FFT_ORDER_ID` DESC;

";

            return sql;
        }

        public string SearchOrderAll(OrderProperty dataItem)
        {
            //##  !!! Have different  database name join in Qry. !!!!!!!!!!!!!!!  ###################################
            // Product ID 11 is Cavity

            sql = @"

                        SELECT	`tb_1`.`FFT_ORDER_ID` AS `FFT_ORDER_ID`
			                        ,DATE_FORMAT(`tb_1`.`ORDER_DATE`, '%Y-%m-%d') AS `ORDER_DATE`	
			                        ,`tb_1`.`QUANTITY` AS `ORDER_QUANTITY`
			                        ,`tb_5`.`ORDER_TYPE_NAME` AS `ORDER_TYPE_NAME`
			                        ,`tb_2`.`PRODUCT_NAME` AS `PRODUCT_NAME`
			                        ,`tb_3`.`CUSTOMER_NAME` AS `CUSTOMER_NAME`
			                        ,`tb_1`.`WORK_ORDER` AS `WORK_ORDER`
			                        ,`tb_1`.`PART_NO` AS `PART_NO`
			                        ,`tb_1`.`SPEC_NO` AS `SPEC_NO`
			                        ,`tb_4`.`SHIPPING_DESTINATION` AS `SHIPPING_DESTINATION`
			                        ,DATE_FORMAT(`tb_1`.`CUSTOMER_REQUEST`, '%Y-%m-%d') AS `CUSTOMER_REQUEST`
		

                        FROM `fft_order` AS `tb_1`

                        INNER JOIN `item_product` AS `tb_2` 
                        ON(`tb_2`.`PRODUCT_ID` = `tb_1`.`PRODUCT_ID`)

                        INNER JOIN `item_customer` AS `tb_3` 
                        ON(`tb_3`.`CUSTOMER_ID` = `tb_1`.`CUSTOMER_ID`)

                        INNER JOIN `item_ship_destination` AS `tb_4` 
                        ON(`tb_4`.`SHIP_DEST_ID` = `tb_1`.`SHIP_DEST_ID`)

                        INNER JOIN `item_order_type` AS `tb_5` 
                        ON(`tb_5`.`ORDER_TYPE_ID` = `tb_1`.`ORDER_TYPE_ID`)

                        INNER JOIN `item_product` AS `tb6`
                        ON (tb6.PRODUCT_ID = tb_1.PRODUCT_ID)

                        WHERE `tb6`.`PRODUCT_NAME` = 'dataItem.SUB_PRODUCT.PRODUCT_SUB_NAME'

                        AND `tb_5`.`ORDER_TYPE_NAME` LIKE '" + dataItem.ORDER_TYPE_NAME + @"%'

                        ORDER BY `tb_1`.`ORDER_DATE` DESC,`tb_1`.`FFT_ORDER_ID` DESC;";

            sql = sql.Replace("dataItem.SUB_PRODUCT.PRODUCT_SUB_NAME", dataItem.Sub_Product.PRODUCT_SUB_NAME);
            return sql;
        }


        public string SearchOrderHistory(OrderProperty dataItem)
        {
            sql = @"SELECT
                         tb_2.INPUT_TYPE
                        ,tb_1.FFT_ORDER_ID
                        ,tb_1.`GROUP`
                        ,tb_1.QUANTITY
                        ,tb_7.PRODUCT_SUB_NAME
                        ,tb_6.CUSTOMER_NAME
                        ,tb_5.WORK_ORDER
                        ,tb_4.PART_NO
                        ,tb_1.EMP_ID
                        ,tb_1.INPUT_DATE

                    FROM `input`  AS tb_1

                    INNER JOIN `input_type` As tb_2
                    ON(tb_2.ID = tb_1.INPUT_TYPE_ID)

                    INNER JOIN `condition` As tb_3 
                    ON(tb_3.ID = tb_1.CONDITION_ID)

                    INNER JOIN `part_no` As tb_4 
                    ON(tb_4.ID = tb_3.PART_NO_ID)

                    INNER JOIN `work_order` As tb_5 
                    ON(tb_5.ID = tb_3.WORK_ORDER_ID)

                    INNER JOIN `customer` As tb_6 
                    ON(tb_6.ID = tb_3.CUSTOMER_ID)

                    INNER JOIN `product_sub` As tb_7
                    ON(tb_7.PRODUCT_SUB_CODE = tb_3.PRODUCT_SUB_CODE)

                    WHERE tb_1.FFT_ORDER_ID = '" + dataItem.FFT_ORDER_ID + @"'
                    ORDER BY `GROUP`;";

            return sql;
        }



        public string SeachOrderQty(OrderProperty dataItem)
        {
            sql = @"SELECT QUANTITY AS ORDER_QUANTITY 
                    FROM `fft_order`
                    WHERE FFT_ORDER_ID = '" + dataItem.FFT_ORDER_ID + @"';";

            return sql;
        }

        public string SeachSumQtyInputOrder(OrderProperty dataItem)
        {
            sql = @"SELECT IF(SUM(QUANTITY) IS NULL OR SUM(QUANTITY) = '',0,SUM(QUANTITY)) AS QTY_HISTOTY
                    FROM `input`
                    WHERE FFT_ORDER_ID = '" + dataItem.FFT_ORDER_ID + @"';";

            return sql;
        }

        public string SearchInputType(OrderProperty dataItem)
        {
            sql = @"SELECT ID
                          ,INPUT_TYPE

                    FROM `input_type`
                    WHERE REPLACE(INPUT_TYPE, ' ', '') = REPLACE('" + dataItem.ORDER_TYPE_NAME + "', ' ', '');";

            return sql;
        }

        public string InsertInputType(OrderProperty dataItem)
        {
            sql = @"INSERT INTO `input_type` (
                        ID
                        ,INPUT_TYPE
                    )
                    (
                        SELECT CASE WHEN COUNT(`ID`) = 0 THEN 1 ELSE MAX(`ID`)+1 END AS `ID`
                        ,'" + dataItem.ORDER_TYPE_NAME + @"' AS `INPUT_TYPE`
                        
                        FROM `input_type`
                    );";

            return sql;
        }

        public string InsertInputProduction(OrderProperty dataItem)
        {
            sql = @"INSERT INTO `input` (
                            `FFT_ORDER_ID`
                            ,`GROUP`
                            ,`INPUT_TYPE_ID`
                            ,`CONDITION_ID`
                            ,`QUANTITY`
                            ,`INPUT_DATE`
                            ,`EMP_ID`
                            ,`PRODUCT_SUB_CODE`
                    )
                    (
                                 SELECT '" + dataItem.FFT_ORDER_ID + @"' AS `FFT_ORDER_ID` 
                                ,(SELECT CASE WHEN COUNT(`GROUP`) = 0 THEN 1 ELSE MAX(`GROUP`)+1 END FROM `input` WHERE FFT_ORDER_ID = '" + dataItem.FFT_ORDER_ID + @"') AS `MAX_GROUP` 
                                ,(SELECT ID FROM `input_type` WHERE INPUT_TYPE = '" + dataItem.ORDER_TYPE_NAME + @"') AS `INPUT_TYPE_ID`
                                ,(SELECT tb_1.`ID` AS `ID`
                           
	                                FROM `condition` AS tb_1

	                                INNER JOIN `product_sub` AS tb_2 
	                                ON (tb_2.`PRODUCT_SUB_CODE` = tb_1.`PRODUCT_SUB_CODE`)

	                                INNER JOIN `customer` AS tb_3	
	                                ON (tb_3.`ID` = tb_1.`CUSTOMER_ID`)

	                                INNER JOIN `work_order` AS tb_4 
	                                ON (tb_4.`ID` = tb_1.`WORK_ORDER_ID`)

	                                INNER JOIN `part_no` AS tb_5 
	                                ON (tb_5.`ID` = tb_1.`PART_NO_ID`)

	                                WHERE REPLACE(tb_2.PRODUCT_SUB_CODE, ' ', '') = REPLACE('" + dataItem.CONDITION.PRODUCT_SUB_CODE + @"', ' ', '')
	                                AND REPLACE(tb_3.CUSTOMER_NAME, ' ', '') = REPLACE('" + dataItem.CONDITION.CUSTOMER_NAME + @"', ' ', '')
	                                AND REPLACE(tb_4.WORK_ORDER, ' ', '') = REPLACE('" + dataItem.CONDITION.WORK_ORDER + @"', ' ', '')
	                                AND REPLACE(tb_5.PART_NO, ' ', '') = REPLACE('" + dataItem.CONDITION.PART_NO + @"', ' ', '')
	                                ) AS `CONDITION_ID`

                                , '" + dataItem.ORDER_QUANTITY + @"' AS `QUANTITY`
                                , '" + dataItem.ORDER_DATE + @"' AS `INPUT_DATE`
                                ,'" + dataItem.EMP.code + @"' AS `EMP_ID`
                                ,'" + dataItem.Sub_Product.PRODUCT_SUB_CODE + @"' AS `PRODUCT_SUB_CODE`
                    );";

            return sql;
        }
        public string InsertInputPurchase(OrderProperty dataItem)
        {
            sql = @"INSERT INTO `input_purchase`(
                        `FFT_ORDER_ID`
                        ,`GROUP`
                        ,`PURCHASE_ID`
                    )
                    (
                        SELECT '" + dataItem.FFT_ORDER_ID + @"' AS `FFT_ORDER_ID`
                            ,(SELECT MAX(`GROUP`) FROM `input` WHERE `FFT_ORDER_ID` = '" + dataItem.FFT_ORDER_ID + @"') AS `GROUP`
	                        ,(SELECT ID FROM `purchase` WHERE PURCHASE_NO = '" + dataItem.PURCHASR.PURCHASE_NO + @"') AS `PURCHASE_ID`
                    )";
            return sql;
        }

        public string SearchInputAll()
        {
            sql = @"SELECT IF(((`tb_8`.`FFT_ORDER_ID` IS NULL OR `tb_8`.`FFT_ORDER_ID` = '') AND (`tb_8`.`GROUP` IS NULL OR `tb_8`.`GROUP` = '')),'Waiting','Already') AS `STATUS`
		                    ,tb_1.FFT_ORDER_ID
		                    ,tb_1.`GROUP`
		                    ,tb_2.INPUT_TYPE
		                    ,tb_1.QUANTITY
		                    ,tb_7.PRODUCT_SUB_NAME AS SUB_PRODUCT
		                    ,tb_6.CUSTOMER_NAME
		                    ,tb_5.WORK_ORDER
		                    ,tb_4.PART_NO
		                    ,tb_1.INPUT_DATE


                    FROM `input` AS tb_1

                    INNER JOIN `input_type` As tb_2 
                    ON (tb_2.ID = tb_1.INPUT_TYPE_ID)

                    INNER JOIN `condition` As tb_3 
                    ON (tb_3.ID = tb_1.CONDITION_ID)

                    INNER JOIN `part_no` As tb_4 
                    ON (tb_4.ID = tb_3.PART_NO_ID)

                    INNER JOIN `work_order` As tb_5 
                    ON (tb_5.ID = tb_3.WORK_ORDER_ID)

                    INNER JOIN `customer` As tb_6 
                    ON (tb_6.ID = tb_3.CUSTOMER_ID)

                    INNER JOIN `product_sub` As tb_7 
                    ON (tb_7.PRODUCT_SUB_CODE = tb_3.PRODUCT_SUB_CODE)

                    LEFT JOIN (SELECT DISTINCT FFT_ORDER_ID,`GROUP` FROM`input_serial`) AS `tb_8` 
                    ON (`tb_8`.FFT_ORDER_ID = `tb_1`.FFT_ORDER_ID AND `tb_8`.`GROUP` = `tb_1`.`GROUP`)";

            return sql;
        }

        public string SearchOrderInput(OrderProperty dataItem)
        {
            sql = @"SELECT `INUSE`
                        ,`SERIAL_ID`
                        ,`FFT_ORDER_ID`
                        ,`GROUP`
                        ,`FLOW_ID`
                        ,`DATE`

                    FROM `input_serial` 
                    WHERE `FFT_ORDER_ID` = '" + dataItem.FFT_ORDER_ID + @"'
                    AND `GROUP` = '" + dataItem.GROUP + "'";

            return sql;
        }


        public string UpdateInput(OrderProperty dataItem)
        {
            sql = @"/*Update data in main table.*/
                    UPDATE `input` 
                    SET QUANTITY = '" + dataItem.ORDER_QUANTITY + @"'
	                    ,EMP_ID = '" + dataItem.EMP.code + @"'

                    WHERE `FFT_ORDER_ID` = '" + dataItem.FFT_ORDER_ID + @"'
                    AND `GROUP` = '" + dataItem.GROUP + @"';

                    /*Insert to History*/
                    INSERT INTO `input_history`(
                            `FFT_ORDER_ID`
                            ,`GROUP`
                            ,`INPUT_TYPE_ID`
                            ,`CONDITION_ID`
                            ,`QUANTITY`
                            ,`INPUT_DATE`
                            ,`EMP_ID`
                            ,`LAST_UPDATE`
                            ,`BACKUP_DATE`
                    )
                    (
                    SELECT `FFT_ORDER_ID`
		                    ,`GROUP`
		                    ,`INPUT_TYPE_ID`
		                    ,`CONDITION_ID`
		                    ,`QUANTITY`
		                    ,`INPUT_DATE`
		                    ,`EMP_ID`
		                    ,`LAST_UPDATE`
		                    ,NOW() AS `BACKUP_DATE`
                    FROM `input` 
                    WHERE `FFT_ORDER_ID` = '" + dataItem.FFT_ORDER_ID + @"'
                    AND `GROUP` = '" + dataItem.GROUP + @"'
                    );";

            return sql;
        }

        public string InsertOrderUseDatabasePC(OrderProperty dataItem)
        {
            sql = @"INSERT INTO `order_used` (
                        `FFT_ORDER_ID`
                        ,`USED_DATE`
                    )
                    VALUES(
                        '" + dataItem.FFT_ORDER_ID + @"'
                        ,NOW()
                    )
                    ";

            return sql;
        }

        public string SearchOrderUseDatabasePC(OrderProperty dataItem)
        {
            sql = @"SELECT `FFT_ORDER_ID`,`USED_DATE`
                    FROM  `order_used`
                    WHERE `FFT_ORDER_ID` =  '" + dataItem.FFT_ORDER_ID + @"';";

            return sql;
        }

    }
}