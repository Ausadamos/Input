using InputManagement.Property;

namespace InputManagement.SQLFactory
{
    public class PurchaseSQLFactory_bck
    {
        private string sql;
        public string LoadPurchaseAll()
        {
            sql = @"SELECT `tb_1`.`ID` AS `ID`
                ,`tb_1`.`PURCHASE_NO` AS `DOCUMENT_NO`
                ,IF(`tb_6`.`FFT_CODE` IS NULL OR `tb_6`.`FFT_CODE` = '', 'N/A',`tb_6`.`FFT_CODE`) AS `FFT_CODE`
                ,IF(`tb_8`.`FLOW_NAME` IS NULL OR `tb_8`.`FLOW_NAME` = '','N/A',`tb_8`.`FLOW_NAME`) AS `FLOW_NAME`
                ,`tb_2`.`PART_NO` AS `PART_NO`
                ,`tb_3`.`PRODUCT_NAME` AS `PRODUCT_NAME`
                ,`tb_4`.`MODEL_NO` AS `MODEL_NO`
                ,DATE_FORMAT(`tb_1`.`DATE`, '%Y-%m-%d') AS `CREATE_DATE`
                ,`tb_1`.`EMP_ID` AS `EMP_ID`
                ,DATE_FORMAT(`tb_1`.`LAST_UPDATE`, '%Y-%m-%d %H:%i:%s') AS `LAST_UPDATE`
                ,IF(`tb_9`.`PATH_PROCESS_CARD` IS NULL OR `tb_9`.`PATH_PROCESS_CARD` = '', 'N/A',`tb_9`.`PATH_PROCESS_CARD`) AS `PATH_PROCESS_CARD`


                FROM `purchase` AS `tb_1` 
                FROM `purchase` AS `tb_1` 

                INNER JOIN `part_no` AS `tb_2` 
                ON(`tb_2`.`ID` = `tb_1`.`PART_NO_ID`)

                INNER JOIN `product_purchase` AS `tb_3`
                ON(`tb_3`.`ID` = `tb_1`.`PURCHASE_PRODUCT_ID`)

                INNER JOIN `model` AS `tb_4` 
                ON(`tb_4`.`ID` = `tb_1`.`MODEL_ID`)

                LEFT JOIN `purchase_fft_code` AS `tb_5` 
                ON(`tb_5`.`PURCHASE_ID` = `tb_1`.`ID`)

                LEFT JOIN `fft_code` AS `tb_6` 
                ON(`tb_6`.`ID` = `tb_5`.`FFT_CODE_ID`)

                LEFT JOIN `flow_process` AS `tb_7` 
                ON (`tb_7`.PURCHASE_ID = `tb_1`.ID AND `tb_7`.INUSE = 1)

                LEFT JOIN `flow` AS `tb_8` 
                ON (`tb_8`.ID = `tb_7`.FLOW_ID)

                LEFT JOIN `path_processcard` AS `tb_9` 
                ON (`tb_9`.`PURCHASE_ID` = `tb_1`.`ID`)

                ORDER BY `tb_1`.`ID`";

            return sql;
        }

        public string SearchPurchasesOrder(OrderProperty dataItem)
        {
            sql = @"SELECT `tb_1`.`ID` AS `ID`
			                ,`tb_1`.`PURCHASE_NO` AS `DOCUMENT_NO`
			                ,IF(`tb_6`.`FFT_CODE` IS NULL OR `tb_6`.`FFT_CODE` = '', 'N/A',`tb_6`.`FFT_CODE`) AS `FFT_CODE`
			                ,IF(`tb_7`.`PURCHASE_ID` IS NULL OR `tb_7`.`PURCHASE_ID` = '','N/A',`tb_8`.`FLOW_NAME`) AS `FLOW_NAME`
			                ,`tb_2`.`PART_NO` AS `PART_NO`
			                ,`tb_3`.`PRODUCT_NAME` AS `PRODUCT_NAME`
			                ,`tb_4`.`MODEL_NO` AS `MODEL_NO`
			                ,DATE_FORMAT(`tb_1`.`DATE`, '%Y-%m-%d') AS `CREATE_DATE`
			                ,`tb_1`.`EMP_ID` AS `EMP_ID`
			                ,DATE_FORMAT(`tb_1`.`LAST_UPDATE`, '%Y-%m-%d %H:%i:%s') AS `LAST_UPDATE`


                    FROM `purchase` AS `tb_1` 

                    INNER JOIN `part_no` AS `tb_2` 
                    ON(`tb_2`.`ID` = `tb_1`.`PART_NO_ID`)

                    INNER JOIN `product_purchase` AS `tb_3` 
                    ON(`tb_3`.`ID` = `tb_1`.`PURCHASE_PRODUCT_ID`)

                    INNER JOIN `model` AS `tb_4` 
                    ON(`tb_4`.`ID` = `tb_1`.`MODEL_ID`)

                    LEFT JOIN `purchase_fft_code` AS `tb_5` 
                    ON(`tb_5`.`PURCHASE_ID` = `tb_1`.`ID`)

                    LEFT JOIN `fft_code` AS `tb_6` 
                    ON(`tb_6`.`ID` = `tb_5`.`FFT_CODE_ID`)

                    LEFT JOIN `flow_process` AS `tb_7` 
                    ON (`tb_7`.PURCHASE_ID = `tb_1`.ID AND `tb_7`.INUSE = 1)

                    LEFT JOIN `flow` AS `tb_8` 
                    ON (`tb_8`.ID = `tb_7`.FLOW_ID)

                    WHERE `tb_2`.`PART_NO` = '" + dataItem.CONDITION.PART_NO + @"'

                    ORDER BY `tb_1`.`ID`";


            return sql;
        }


        public string SearchPurchasesByProduct(PurchaseProperty dataItem)
        {
            sql = @"SELECT `tb_1`.`ID` AS `ID`
                ,`tb_1`.`PURCHASE_NO` AS `DOCUMENT_NO`
                ,IF(`tb_6`.`FFT_CODE` IS NULL OR `tb_6`.`FFT_CODE` = '', 'N/A',`tb_6`.`FFT_CODE`) AS `FFT_CODE`
                ,IF(`tb_8`.`FLOW_NAME` IS NULL OR `tb_8`.`FLOW_NAME` = '','N/A',`tb_8`.`FLOW_NAME`) AS `FLOW_NAME`
                ,`tb_2`.`PART_NO` AS `PART_NO`
                ,`tb_3`.`PRODUCT_NAME` AS `PRODUCT_NAME`
                ,`tb_4`.`MODEL_NO` AS `MODEL_NO`
                ,DATE_FORMAT(`tb_1`.`DATE`, '%Y-%m-%d') AS `CREATE_DATE`
                ,`tb_1`.`EMP_ID` AS `EMP_ID`
                ,DATE_FORMAT(`tb_1`.`LAST_UPDATE`, '%Y-%m-%d %H:%i:%s') AS `LAST_UPDATE`
                ,IF(`tb_9`.`PATH_PROCESS_CARD` IS NULL OR `tb_9`.`PATH_PROCESS_CARD` = '', 'N/A',`tb_9`.`PATH_PROCESS_CARD`) AS `PATH_PROCESS_CARD`
                FROM `purchase` AS `tb_1` 
                INNER JOIN `part_no` AS `tb_2` 
                ON(`tb_2`.`ID` = `tb_1`.`PART_NO_ID`)
                INNER JOIN `product_purchase` AS `tb_3`
                ON(`tb_3`.`ID` = `tb_1`.`PURCHASE_PRODUCT_ID`)
                INNER JOIN `model` AS `tb_4` 
                ON(`tb_4`.`ID` = `tb_1`.`MODEL_ID`)
                LEFT JOIN `purchase_fft_code` AS `tb_5` 
                ON(`tb_5`.`PURCHASE_ID` = `tb_1`.`ID`)
                LEFT JOIN `fft_code` AS `tb_6` 
                ON(`tb_6`.`ID` = `tb_5`.`FFT_CODE_ID`)
                LEFT JOIN `flow_process` AS `tb_7` 
                ON (`tb_7`.PURCHASE_ID = `tb_1`.ID AND `tb_7`.INUSE = 1)
                LEFT JOIN `flow` AS `tb_8` 
                ON (`tb_8`.ID = `tb_7`.FLOW_ID)
                LEFT JOIN `path_processcard` AS `tb_9` 
                ON (`tb_9`.`PURCHASE_ID` = `tb_1`.`ID`)
                INNER JOIN `purchase_product_type` AS `tb_10` 
                ON(`tb_1`.`ID` = `tb_10`.PURCHASE_ID)
                INNER JOIN `product_type` AS `tb_11` 
                ON(`tb_11`.`ID` = `tb_10`.PRODUCT_TYPE_ID)
                where tb_11.PRODUCT_SUB_CODE = 'dataItem.PRODUCT_TYPE.PRODUCT_SUB_CODE'
                ORDER BY `tb_1`.`ID`";

            sql = sql.Replace("dataItem.PRODUCT_TYPE.PRODUCT_SUB_CODE", dataItem.PRODUCT_TYPE.PRODUCT_SUB_CODE);

            return sql;
        }

        public string SearchModelNO(PurchaseProperty dataItem)
        {
            sql = @"SELECT ID
				           ,MODEL_NO

                    FROM `model`
                    WHERE REPLACE(MODEL_NO, ' ', '') = REPLACE('" + dataItem.MODEL + "', ' ', '');";

            return sql;
        }

        public string InsertModelNO(PurchaseProperty dataItem)
        {
            sql = @"INSERT INTO `model` (
                        `ID`
                        ,`MODEL_NO`
                    )
                    (
                        SELECT CASE WHEN COUNT(`ID`) = 0 THEN 1 ELSE MAX(`ID`)+1 END AS `ID`
                            ,'" + dataItem.MODEL + @"' AS `MODEL_NO`

                        FROM `model`
                    );";

            return sql;
        }

        public string SearchProductPurchase(PurchaseProperty dataItem)
        {
            sql = @"SELECT ID
				           ,PRODUCT_NAME

                    FROM `product_purchase`
                    WHERE REPLACE(PRODUCT_NAME, ' ', '') = REPLACE('" + dataItem.PRODUCT_PURCHASE + "', ' ', '');";

            return sql;
        }

        public string InsertProductPurchase(PurchaseProperty dataItem)
        {
            sql = @"INSERT INTO `product_purchase` (
                        `ID`
                        ,`PRODUCT_NAME`
                    )
                    (
                        SELECT CASE WHEN COUNT(`ID`) = 0 THEN 1 ELSE MAX(`ID`)+1 END AS `ID`
                            ,'" + dataItem.PRODUCT_PURCHASE + @"' AS `PRODUCT_NAME`

                        FROM `product_purchase`

                    );";

            return sql;
        }

        public string SearchFFTCode(PurchaseProperty dataItem)
        {
            sql = @"SELECT ID
				           ,FFT_CODE

                    FROM `fft_code`
                    WHERE REPLACE(FFT_CODE, ' ', '') = REPLACE('" + dataItem.FFT_CODE + "', ' ', '');";

            return sql;
        }

        public string InsertFFTCode(PurchaseProperty dataItem)
        {
            sql = @"INSERT INTO `fft_code` (
                        `ID`
                        ,`FFT_CODE`
                    )
                    (
                        SELECT CASE WHEN COUNT(`ID`) = 0 THEN 1 ELSE MAX(`ID`)+1 END AS `ID`
                            ,'" + dataItem.FFT_CODE + @"' AS `FFT_CODE`
            
                        FROM `fft_code`

                    );";

            return sql;
        }

        public string SearchPurchase(PurchaseProperty dataItem)
        {
            sql = @"SELECT
                        `ID`
                        ,`PURCHASE_NO`
                        ,`PART_NO_ID`
                        ,`PURCHASE_PRODUCT_ID`
                        ,`MODEL_ID`
                        ,`DATE`
                        ,`EMP_ID`

                    FROM `purchase`
                    WHERE REPLACE(PURCHASE_NO, ' ', '') = REPLACE('" + dataItem.PURCHASE_NO + @"', ' ', '');";

            return sql;
        }

        public string InsertPurchase(PurchaseProperty dataItem)
        {
            sql = @"INSERT INTO `purchase` (
                        `ID`
                        ,`PURCHASE_NO`
                        ,`PART_NO_ID`
                        ,`PURCHASE_PRODUCT_ID`
                        ,`MODEL_ID`
                        ,`DATE`
                        ,`EMP_ID`

                    )
                    (
                        SELECT CASE WHEN COUNT(`ID`) = 0 THEN 1 ELSE MAX(`ID`)+1 END AS `ID`
                            ,'" + dataItem.PURCHASE_NO + @"'
                            ,(SELECT `ID` FROM `part_no` WHERE REPLACE(PART_NO, ' ', '') = REPLACE('" + dataItem.PART_NO + @"', ' ', '')) AS `PART_NO_ID` 
                            ,(SELECT `ID` FROM `product_purchase` WHERE REPLACE(PRODUCT_NAME, ' ', '') = REPLACE('" + dataItem.PRODUCT_PURCHASE + @"', ' ', '')) AS `PURCHASE_PRODUCT_ID`
                            ,(SELECT `ID` FROM `model` WHERE REPLACE(MODEL_NO, ' ', '') = REPLACE('" + dataItem.MODEL + @"', ' ', '')) AS `MODEL_ID`
                            ,NOW() AS `DATE`
                            ,'" + dataItem.EMP.code + @"' AS `EMP_ID`

                        FROM `purchase` 

                    ); ";

            return sql;
        }

        public string InsertPurchase_FFT_Code(PurchaseProperty dataItem)
        {
            sql = @"INSERT INTO `purchase_fft_code` (
                        `PURCHASE_ID`
                        ,`FFT_CODE_ID`
                    )
                    (
                        SELECT (SELECT `ID` FROM `purchase` WHERE REPLACE(PURCHASE_NO, ' ', '') = REPLACE('" + dataItem.PURCHASE_NO + @"', ' ', '')) AS `PURCHASE_ID`
                        ,(SELECT `ID` FROM `fft_code` WHERE REPLACE(FFT_CODE, ' ', '') = REPLACE('" + dataItem.FFT_CODE + @"', ' ', '')) AS `FFT_CODE_ID`

                   ); ";

            return sql;
        }

        public string SearchPathProcessCard(PurchaseProperty dataItem)
        {
            sql = @"SELECT tb_1.PURCHASE_ID AS PURCHASE_ID
	                    ,tb_2.PURCHASE_NO AS PURCHASE_NO
	                    ,tb_1.PATH_PROCESS_CARD AS PATH_PROCESS_CARD

                    FROM `path_processcard` AS tb_1 

                    INNER JOIN `purchase` AS tb_2 
                    ON (tb_2.`ID` = tb_1.`PURCHASE_ID`)

                    WHERE tb_2.PURCHASE_NO = '" + dataItem.PURCHASE_NO + @"';";

            return sql;
        }

        public string InsertPathProcessCard(PurchaseProperty dataItem)
        {
            sql = @"INSERT INTO `path_processcard` (
                        `PURCHASE_ID`
                        ,`PATH_PROCESS_CARD`
                    )
                    (
                        SELECT (SELECT `ID` FROM `purchase` WHERE REPLACE(PURCHASE_NO, ' ', '') = REPLACE('" + dataItem.PURCHASE_NO + @"', ' ', '')) AS `PURCHASE_ID`
                        ,'" + dataItem.PATH_PROCESS_CARD + @"'

                   ); ";

            return sql;
        }
        public string InsertPurchaseProductType(PurchaseProperty dataItem)
        {
            sql = @"INSERT INTO `purchase_product_type` (
                        `PURCHASE_ID`
                        ,`PRODUCT_TYPE_ID`
                    )
                    (
                       SELECT tb1.ID AS PURCHASE_ID
                     , tb2.ID AS PRODUCT_TYPE_ID

                    FROM purchase AS tb1
                    , product_type as tb2

                     WHERE REPLACE(tb1.PURCHASE_NO, ' ','') = REPLACE('" + dataItem.PURCHASE_NO + @"', ' ' , '') 
                    AND REPLACE(tb2.PRODUCT_TITLE, ' ','') = REPLACE('" + dataItem.PRODUCT_TYPE.PRODUCT_TITLE + @"', ' ' , '') 

                   ); ";

            return sql;
        }
        public string SearchFlowProcess(PurchaseProperty dataItem)
        {
            sql = @"SELECT NO
				        ,INUSE
                        ,FLOW_ID
                        ,PURCHASE_ID

                    FROM `flow_process`
                    WHERE FLOW_ID = (SELECT `ID` FROM `flow` WHERE REPLACE(FLOW_NAME, ' ', '') = REPLACE('" + dataItem.FLOW.FLOW_NAME + @"', ' ', ''))
                    AND PURCHASE_ID = (SELECT `ID` FROM `purchase` WHERE REPLACE(PURCHASE_NO, ' ', '') = REPLACE('" + dataItem.PURCHASE_NO + @"', ' ', ''))";

            return sql;
        }

        public string UpdateUSEFlowProcess(PurchaseProperty dataItem)
        {
            sql = @"UPDATE `flow_process` 
                    SET (
                         INUSE = 1
                        )
                    WHERE FLOW_ID = (SELECT `ID` FROM `flow` WHERE REPLACE(FLOW_NAME, ' ', '') = REPLACE('" + dataItem.FLOW.FLOW_NAME + @"', ' ', ''))
                    AND PURCHASE_ID = (SELECT `ID` FROM `purchase` WHERE REPLACE(PURCHASE_NO, ' ', '') = REPLACE('" + dataItem.PURCHASE_NO + @"', ' ', ''))";

            return sql;
        }

        public string UpdateProcessCardPurchase(PurchaseProperty dataItem)
        {
            sql = @"UPDATE path_processcard As tb1

                INNER JOIN  purchase As tb2 ON (tb2.ID = tb1.PURCHASE_ID)

                SET tb1.PATH_PROCESS_CARD = '" + dataItem.PATH_PROCESS_CARD + @"'

                WHERE tb2.PURCHASE_NO  = '" + dataItem.PURCHASE_NO + @"' ";

            return sql;
        }

        public string InsertFlowProcess(PurchaseProperty dataItem)
        {
            sql = @"INSERT INTO `flow_process`( 
                        `PURCHASE_ID`
				        ,`FLOW_ID`
                        ,`NO`
                        ,`INUSE`
                        ,`EMP_ID`
                    )
                    (
                        SELECT (SELECT `ID` FROM `purchase` WHERE REPLACE(PURCHASE_NO, ' ', '') = REPLACE('" + dataItem.PURCHASE_NO + @"', ' ', '')) AS `PURCHASE_ID`
                        ,(SELECT `ID` FROM `flow` WHERE REPLACE(FLOW_NAME, ' ', '') = REPLACE('" + dataItem.FLOW.FLOW_NAME + @"', ' ', '')) AS `FLOW_ID`
                        ,(SELECT CASE WHEN COUNT(`PURCHASE_ID`) < 1 THEN 1 ELSE MAX(`NO`) + 1 END AS `NO` 
                          FROM `flow_process`
                          WHERE PURCHASE_ID = (SELECT `ID` FROM `purchase` WHERE REPLACE(PURCHASE_NO, ' ', '') = REPLACE('" + dataItem.PURCHASE_NO + @"', ' ', ''))) AS `MAX_NO`
                        ,'1' AS `INUSE`
                        ,'" + dataItem.EMP.code + @"'
                    );";


            return sql;
        }
        public string LastPurchase(ShipmentProperty dataItem)
        {
            sql = @"SELECT tb1.FFT_ORDER_ID
                ,tb4.Serial
                ,tb1.`GROUP`
                ,tb5.FLOW_NAME
                ,tb6.PURCHASE_NO
                ,tb2.INPUT_TYPE
                ,tb3.INUSE
                ,MAX(tb3.DATE) AS DATE
                ,tb7.NO



                FROM `input`As tb1

                INNER JOIN input_type As tb2 
                ON (tb2.ID = tb1.INPUT_TYPE_ID)

                INNER JOIN input_serial As tb3 
                ON (tb3.FFT_ORDER_ID = tb1.FFT_ORDER_ID AND tb3.`GROUP` = tb1.`GROUP`)

                INNER JOIN serial As tb4 
                ON (tb4.ID = tb3.SERIAL_ID)

                INNER JOIN flow As tb5 
                ON (tb5.ID = tb3.FLOW_ID)

                INNER JOIN purchase As tb6 
                ON (tb6.ID = tb3.PURCHASE_ID)

                INNER JOIN process_flow As tb7 
                ON (tb7.FLOW_ID = tb5.ID)


                WHERE tb2.ID <> ('4') 
                AND tb2.ID <> ('5')
                AND tb4.SERIAL = '" + dataItem.SERIAL_NO + @"'";


            return sql;
        }
        public string UsedPurchase(ShipmentProperty dataItem)
        {
            sql = @"SELECT tb1.FFT_ORDER_ID
                ,tb4.Serial
                ,tb1.`GROUP`
                ,tb5.FLOW_NAME
                ,tb6.PURCHASE_NO
                ,tb2.INPUT_TYPE
                ,tb3.INUSE
                ,(tb3.DATE) AS DATE

                FROM `input`As tb1

                INNER JOIN input_type As tb2 
                ON (tb2.ID = tb1.INPUT_TYPE_ID)

                INNER JOIN input_serial As tb3 
                ON (tb3.FFT_ORDER_ID = tb1.FFT_ORDER_ID AND tb3.`GROUP` = tb1.`GROUP`)

                INNER JOIN serial As tb4 
                ON (tb4.ID = tb3.SERIAL_ID)

                INNER JOIN flow As tb5 
                ON (tb5.ID = tb3.FLOW_ID)

                INNER JOIN purchase As tb6 
                ON (tb6.ID = tb3.PURCHASE_ID)

                INNER JOIN process_flow As tb7 
                ON (tb7.FLOW_ID = tb5.ID)

                WHERE tb2.ID <> ('4') 
                AND tb2.ID <> ('5')
                AND tb4.SERIAL = '" + dataItem.SERIAL_NO + @"'

                GROUP BY tb1.`FFT_ORDER_ID` ,tb1.`GROUP`

                ORDER BY tb3.DATE DESC ";


            return sql;
        }
        public string SearchAllProductType()
        {
            //sql = @"
            //    SELECT tb1.ID
            //    ,tb1.PRODUCT_TITLE
            //    ,tb3.SERIAL_FORMAT
            //    ,tb3.DETAIL

            //    FROM `product_type` tb1
            //    INNER JOIN serial_product_type tb2 
            //    ON(tb2.SERIAL_TYPE_ID = tb1.ID)
            //    INNER JOIN serial_type tb3
            //    ON(tb3.ID = tb2.PRODUCT_TYPE_ID)

            //    ORDER BY tb1.ID;";
            sql = @" SELECT tb2.ID AS ID
                    ,tb2.PRODUCT_TITLE AS PRODUCT_TITLE
                    ,tb3.SERIAL_FORMAT AS SERIAL_FORMAT
                    ,tb3.DETAIL AS DETAIL
                    ,tb1.INUSE AS INUSE

                    FROM `serial_product_type` AS tb1

                    INNER JOIN product_type AS tb2
                    ON(tb2.ID = tb1.PRODUCT_TYPE_ID)

                    INNER JOIN serial_type AS tb3
                    ON(tb3.ID = tb1.SERIAL_TYPE_ID)

                    ORDER BY tb2.ID
                    ;";

            return sql;
        }

        //public string SearchSerialFormat(SerialProductTypeProperty dataItem)
        //{
        //    sql = @"SELECT
        //            ID
        //            ,SERIAL_FORMAT
        //            ,DETAIL

        //            FROM
        //             `serial_type`
        //            WHERE REPLACE(serial_type.SERIAL_FORMAT , ' ' , '') = REPLACE('" + dataItem.SERIAL_TYPE.SERIAL_FORMAT + "', ' ' , '');";

        //    return sql;
        //}

        //public string InsertSerialFormat(SerialProductTypeProperty dataItem)
        //{
        //    sql = @"INSERT INTO `serial_type` (
        //                ID
        //                ,SERIAL_FORMAT
        //                ,DETAIL
        //            )
        //            (
        //                SELECT CASE WHEN COUNT(`ID`) = 0 THEN 1 ELSE MAX(`ID`)+1 END AS `ID`
        //                    ,'" + dataItem.SERIAL_TYPE.SERIAL_FORMAT + @"' AS `SERIAL_FORMAT`
        //                    ,'" + dataItem.SERIAL_TYPE.DETAIL + @"' AS `DETAIL`

        //                FROM `serial_type`
        //            );";

        //    return sql;
        //}

        //public string SearchProductTitle(SerialProductTypeProperty dataItem)
        //{
        //    sql = @"SELECT
        //         ID
        //         ,PRODUCT_TITLE
        //            FROM
        //             `product_type`
        //            WHERE REPLACE(PRODUCT_TITLE, ' ' , '') = REPLACE('" + dataItem.PRODUCT_TYPE.PRODUCT_TITLE + "', ' ' , '');";

        //    return sql;
        //}


        //public string InsertSerialProductType(SerialProductTypeProperty dataItem)
        //{
        //    sql = @"INSERT INTO `serial_product_type` (

        //                PRODUCT_TYPE_ID
        //                ,SERIAL_TYPE_ID
        //                ,INUSE
        //                )
        //                (SELECT  tb1.ID As PRODUCT_TYPE_ID 
        //                ,tb2.ID AS SERIAL_TYPE_ID
        //                ,'1'

        //                FROM product_type  AS tb1
        //                ,serial_type  AS tb2

        //                WHERE REPLACE (tb2.SERIAL_FORMAT , ' ' , '') = REPLACE('" + dataItem.SERIAL_TYPE.SERIAL_FORMAT + @"',' ' , '')  
        //                AND  REPLACE (tb1.PRODUCT_TITLE , ' ' , '') = REPLACE('" + dataItem.PRODUCT_TYPE.PRODUCT_TITLE + @"' ,' ' , '')
        //                )";

        //    return sql;
        //}

        //public string SearchExistProductType(SerialProductTypeProperty dataItem)
        //{
        //    sql = @"SELECT  tb1.ID As PRODUCT_TYPE_ID 

        //            FROM product_type  AS tb1

        //            WHERE  REPLACE (tb1.PRODUCT_TITLE , ' ' , '') = REPLACE('" + dataItem.PRODUCT_TYPE.PRODUCT_TITLE + @"' ,' ' , '')
        //            ";

        //    return sql;
        //}
        //        public string SearchExistSerialProductType(SerialProductTypeProperty dataItem)
        //        {
        //            sql = @"SELECT 
        //                    tb3.PRODUCT_TITLE
        //                    ,tb2.SERIAL_FORMAT
        //                    ,tb2.DETAIL 
        //                    ,tb1.INUSE

        //                    FROM `serial_product_type` AS tb1

        //                    INNER JOIN serial_type AS tb2
        //                    ON tb2.ID = tb1.SERIAL_TYPE_ID 

        //                    INNER JOIN product_type AS tb3
        //                    ON tb3.ID =tb1.PRODUCT_TYPE_ID

        //                    WHERE  REPLACE (tb3.PRODUCT_TITLE , ' ' , '') = REPLACE('" + dataItem.PRODUCT_TYPE.PRODUCT_TITLE + @"' ,' ' , '')
        //                    AND REPLACE (tb2.SERIAL_FORMAT , ' ' , '') = REPLACE('" + dataItem.SERIAL_TYPE.SERIAL_FORMAT + @"' ,' ' , '')
        //;
        //                    ";

        //            return sql;
        //        }
        //public string UpdateInuseSerialProductType(SerialProductTypeProperty dataItem)
        //{
        //    sql = @"UPDATE `serial_product_type` AS tb1

        //            INNER JOIN product_type AS tb2
        //            ON(tb2.ID = tb1.PRODUCT_TYPE_ID)

        //            SET tb1.INUSE = '0'

        //            WHERE tb2.PRODUCT_TITLE = '" + dataItem.PRODUCT_TYPE.PRODUCT_TITLE + @"'
        //            AND tb1.INUSE  = '1' 

        //            ;

        //            UPDATE serial_product_type AS tb1

        //            INNER JOIN product_type AS tb2
        //            ON (tb2.ID = tb1.PRODUCT_TYPE_ID)
        //            INNER JOIN serial_type AS tb3
        //            ON (tb3.ID = tb1.SERIAL_TYPE_ID)

        //            SET tb1.INUSE = '1'

        //            WHERE tb2.PRODUCT_TITLE = '" + dataItem.PRODUCT_TYPE.PRODUCT_TITLE + @"'
        //            AND tb3.SERIAL_FORMAT = '" + dataItem.SERIAL_TYPE.SERIAL_FORMAT + @"'
        //            AND tb1.INUSE  = '0' 
        //            ";

        //    return sql;
        //}
        public string CheckFlowProcess(PurchaseProperty dataItem)
        {
            sql = @"SELECT tb1.PURCHASE_NO,tb2.FLOW_ID
                    FROM `purchase` AS tb1

                    LEFT JOIN flow_process AS tb2
                    ON tb2.PURCHASE_ID = tb1.ID

                    WHERE tb1.PURCHASE_NO = '" + dataItem.PURCHASE_NO + @"'
                    AND tb2.FLOW_ID = '" + dataItem.FLOW.ID + @"'
                    ;
                    ";

            return sql;
        }
        public string UpdateFlowProcessALL(PurchaseProperty dataItem)
        {
            sql = @"UPDATE `purchase` AS tb1
                    INNER JOIN flow_process AS tb2
                    ON tb2.PURCHASE_ID = tb1.ID 

                    SET tb2.INUSE = '0'

                    WHERE tb1.PURCHASE_NO = '" + dataItem.PURCHASE_NO + @"'
                    ;
                    ";

            return sql;
        }
        public string InsertNewFlowProcess(PurchaseProperty dataItem)
        {
            sql = @"INSERT INTO `flow_process` 
                    (`PURCHASE_ID`
                    , `FLOW_ID`
                    , `NO`
                    , `INUSE`
                    , `EMP_ID`
                    )  
                    (
                    SELECT tb2.ID AS PURCEASE_ID
                    ,'" + dataItem.FLOW.ID + @"' AS FLOW_ID
                    ,MAX(tb1.`NO`)+1 AS `NO`
                    ,'1' AS INUSE
                    ,'" + dataItem.EMP.code + @"' AS EMP_ID

                    FROM `flow_process` AS tb1
                    INNER JOIN purchase AS tb2
                    ON (tb2.ID = tb1.PURCHASE_ID)
                    WHERE tb2.PURCHASE_NO = 'TEST_DOC'

                    );
                    ";

            return sql;
        }
        public string UpdateFlowProcess(PurchaseProperty dataItem)
        {
            sql = @"UPDATE `purchase` AS tb1

                    LEFT JOIN flow_process AS tb2
                    ON tb2.PURCHASE_ID = tb1.ID

                    SET tb2.FLOW_ID = '" + dataItem.FLOW.ID + @"' 
                    ,INUSE = '1'

                    WHERE tb1.PURCHASE_NO = '" + dataItem.PURCHASE_NO + @"'

                    ;
                    ";

            return sql;
        }



    }
}