using InputManagement.Property;

namespace InputManagement.SQLFactory
{
    public class SearchSQLFactory_bck
    {
        private string sql;
        public string SearchSerialInput(SearchSerialInputProperty dataItem)
        {
            string select = @"SELECT  `tb_2`.`SERIAL` AS `SERIAL`
                        ,IF(`tb_1`.INUSE = '1','Use','Cancel') AS `STATUS`
                        ,`tb_1`.`DATE` AS `INPUT_DATE`
                        ,`tb_1`.`FFT_ORDER_ID` AS `FFT_ORDER_ID`
                        ,`tb_1`.`GROUP` AS `GROUP`
                        ,`tb_10`.`INPUT_TYPE` AS `INPUT_TYPE`
                        ,`tb_3`.`PURCHASE_NO` AS `PURCHASE_NO`
                        ,`tb_4`.`FLOW_NAME` AS `FLOW_NAME`
                        ,`tb_1`.`EMP_ID` AS `EMP_ID`
                        ,`tb_7`.`PROCESS_NAME` AS `CURRENT_PROCESS`
                        ,`tb_8`.`RESULT` AS `STATUS_IN_PROCESS`

                        FROM `input_serial` AS `tb_1`

                        INNER JOIN  `serial` AS `tb_2` 
                        ON (`tb_2`.ID = `tb_1`.SERIAL_ID) 

                        INNER JOIN `purchase` AS `tb_3` 
                        ON (`tb_3`.ID = `tb_1`.PURCHASE_ID)

                        INNER JOIN `flow` AS `tb_4` 
                        ON (`tb_4`.`ID` = `tb_1`.`FLOW_ID`)

                        LEFT JOIN (SELECT `SERIAL_ID`
								                    ,`FFT_ORDER_ID`
								                    ,`GROUP`
								                    ,`FLOW_ID`
								                    ,MAX(`NO`) AS `MAX_NO`
								                    ,`PROCESS_ID`

					                            FROM `progress` 
					                            GROUP BY `SERIAL_ID`,`FFT_ORDER_ID`,`GROUP`)  AS `tb_5` 

                        ON (`tb_5`.`SERIAL_ID` = `tb_1`.`SERIAL_ID`
                        AND `tb_5`.`FFT_ORDER_ID` = `tb_1`.`FFT_ORDER_ID`
                        AND `tb_5`.`GROUP` = `tb_1`.`GROUP`
                        AND `tb_5`.`FLOW_ID` = `tb_1`.`FLOW_ID`)

                        LEFT JOIN `progress` AS `tb_6` 
                        ON (`tb_6`.`SERIAL_ID` = `tb_5`.`SERIAL_ID`
                        AND `tb_6`.`NO` = `tb_5`.`MAX_NO`)

                        LEFT JOIN `process` AS `tb_7`
                        ON (`tb_7`.`ID` = `tb_6`.`PROCESS_ID`)

                        LEFT JOIN `result` AS `tb_8`
                        ON(`tb_8`.`ID` = `tb_6`.`RESULT_ID`)
                
                        INNER JOIN  `input` AS `tb_9`
                        ON(`tb_9`.`FFT_ORDER_ID` = `tb_1`.`FFT_ORDER_ID` AND `tb_9`.`GROUP` = `tb_1`.`GROUP`) 

                        INNER JOIN `input_type` AS `tb_10`
                        ON(`tb_10`.`ID` = `tb_9`.`INPUT_TYPE_ID`) ";


            string where = "";
            //## WHERE Serial.
            string whereSerial = "";
            foreach (string _serial in dataItem.SERIAL)
            {
                if (_serial.Trim() != "")
                {
                    if (whereSerial == "") { whereSerial = "'" + _serial + "'"; }
                    else { whereSerial += ",'" + _serial + "'"; }
                }
            }

            if (whereSerial != "")
            {
                whereSerial = @"`tb_2`.`SERIAL` IN (" + whereSerial + @") ";
                where = whereSerial;
            }

            //## WHERE Purchase.
            if (dataItem.PURCHASE != "")
            {
                string wherePurchase = "";
                if (where != "")
                {
                    wherePurchase = @"
                        AND `tb_3`.`PURCHASE_NO` = '" + dataItem.PURCHASE + @"' ";

                    where += wherePurchase;
                }
                else
                {
                    wherePurchase = @"`tb_3`.`PURCHASE_NO` = '" + dataItem.PURCHASE + @"' ";
                    where = wherePurchase;
                }
            }

            //## WHERE FFT_ORDER_ID/GROUP.
            if (dataItem.FFT_ORDER_ID != "")
            {
                string whereFFT_Oder = "";
                if (where != "")
                {
                    whereFFT_Oder = @"
                        AND `tb_1`.`FFT_ORDER_ID` = '" + dataItem.FFT_ORDER_ID + @"' ";

                    where += whereFFT_Oder;
                }
                else
                {
                    whereFFT_Oder = @"`tb_1`.`FFT_ORDER_ID` = '" + dataItem.FFT_ORDER_ID + @"' ";
                    where = whereFFT_Oder;
                }

                if (dataItem.GROUP != "")
                {
                    where += @" 
                        AND `tb_1`.`GROUP` = '" + dataItem.GROUP + "' ";
                }
            }

            //## WHERE INUSE.
            if (dataItem.INUSE != "")
            {
                string whereINUSE = "";
                if (where != "")
                {
                    whereINUSE = @"
                        AND `tb_1`.`INUSE` = '" + dataItem.INUSE + @"' ";

                    where += whereINUSE;
                }
                else
                {
                    whereINUSE = @"`tb_1`.`INUSE` = '" + dataItem.INUSE + @"' ";
                    where = whereINUSE;
                }
            }

            //## WHERE DATE/TO
            if (dataItem.INPUT_DATE != "" && dataItem.INPUT_DATE_TO != "")
            {
                string whereInputDate = "";
                if (where != "")
                {
                    whereInputDate = @" 
                        AND `tb_1`.`DATE` >= '" + dataItem.INPUT_DATE + @"' 
                        AND `tb_1`.`DATE` <= '" + dataItem.INPUT_DATE_TO + "' ";

                    where += whereInputDate;
                }
                else
                {
                    whereInputDate = @"`tb_1`.`DATE` >= '" + dataItem.INPUT_DATE + @"' 
                        AND `tb_1`.`DATE` <= '" + dataItem.INPUT_DATE_TO + "' ";

                    where = whereInputDate;
                }
            }
            //## WHERE DATE
            else if (dataItem.INPUT_DATE != "" && dataItem.INPUT_DATE_TO == "")
            {
                string whereInputDate = "";
                if (where != "")
                {
                    whereInputDate = @" 
                        AND `tb_1`.`DATE` = '" + dataItem.INPUT_DATE + @"' ";

                    where += whereInputDate;
                }
                else
                {
                    whereInputDate = @"`tb_1`.`DATE` = '" + dataItem.INPUT_DATE + @"' ";

                    where = whereInputDate;
                }
            }

            if (where == "")
            {
                sql = select + @" 

                        WHERE SUBSTR(`tb_1`.`DATE`,1,7) = SUBSTR(NOW(),1,7)

                        ORDER BY 
                        `tb_2`.`SERIAL`
                        ,`tb_1`.`DATE`
                        ,`tb_1`.`GROUP`;";
            }
            else
            {
                sql = select + @"
                        
                        WHERE " + where + @"
                        
                        ORDER BY 
                        `tb_2`.`SERIAL`
                        ,`tb_1`.`DATE`
                        ,`tb_1`.`GROUP`;";
            }

            return sql;
        }

        public string SearchProgressAllProcess(SearchSerialProgressProperty dataItem)
        {
            string select = @"SELECT `tb_2`.`SERIAL` AS `SERIAL`
                        ,`tb_1`.`NO` AS `NO`
                        ,`tb_1`.`FFT_ORDER_ID` AS `FFT_ORDER_ID`
                        ,`tb_1`.`GROUP` AS `GROUP`
                        ,`tb_8`.INPUT_TYPE AS `INPUT_TYPE`
                        ,`tb_3`.`FLOW_NAME` AS `FLOW_NAME`
                        ,IF(`tb_6`.`NO` IS NULL OR `tb_6`.`NO` = '','N/A',`tb_6`.`NO`)  AS `PROCESS_NO`
                        ,`tb_4`.`PROCESS_NAME` AS `PROCESS_NAME`
                        ,`tb_5`.`RESULT` AS `RESULT`
                        ,`tb_1`.`ID` AS `PROGRESS_ID`
                        ,`tb_1`.`LAST_UPDATE` AS `LAST_UPDATE`

                        FROM `progress` AS `tb_1`

                        INNER JOIN `serial` AS `tb_2` 
                        ON (`tb_2`.`ID` = `tb_1`.`SERIAL_ID`)

                        INNER JOIN `flow` AS `tb_3`     
                        ON (`tb_3`.`ID` = `tb_1`.`FLOW_ID`)

                        INNER JOIN `process` AS `tb_4` 
                        ON (`tb_4`.`ID`  = `tb_1`.PROCESS_ID)

                        INNER JOIN `result` AS `tb_5`
                        ON (`tb_5`.`ID` = `tb_1`.`RESULT_ID`)

                        LEFT JOIN `process_flow` AS `tb_6` 
                        ON (`tb_6`.`FLOW_ID` = `tb_1`.`FLOW_ID` AND `tb_6`.`PROCESS_ID` = `tb_1`.`PROCESS_ID`) 

                        INNER JOIN `input` AS `tb_7` 
                        ON (`tb_7`.`FFT_ORDER_ID` = `tb_1`.FFT_ORDER_ID AND `tb_7`.`GROUP` = `tb_1`.`GROUP`)

                        INNER JOIN `input_type` AS `tb_8`
                        ON (`tb_8`.`ID` = `tb_7`.`INPUT_TYPE_ID`) ";


            string where = "";

            //## WHERE Serial.
            string whereSerial = "";
            foreach (string _serial in dataItem.SERIAL)
            {
                if (_serial.Trim() != "")
                {
                    if (whereSerial == "") { whereSerial = "'" + _serial + "'"; }
                    else { whereSerial += ",'" + _serial + "'"; }
                }
            }

            if (whereSerial != "")
            {
                whereSerial = @"`tb_2`.`SERIAL` IN (" + whereSerial + @") ";
                where = whereSerial;
            }

            //## WHERE Process.
            if (dataItem.PROCESS.PROCESS_NAME != "")
            {
                string whereProcess = "";
                if (where != "")
                {
                    whereProcess = @"
                        AND `tb_4`.`PROCESS_NAME` = '" + dataItem.PROCESS.PROCESS_NAME + @"' ";

                    where += whereProcess;
                }
                else
                {
                    whereProcess = @"`tb_4`.`PROCESS_NAME` = '" + dataItem.PROCESS.PROCESS_NAME + @"' ";
                    where = whereProcess;
                }
            }

            //## WHERE Status(Result).
            if (dataItem.STATUS.RESULT != "")
            {
                string whereStatus = "";
                if (where != "")
                {
                    whereStatus = @"
                        AND `tb_5`.`RESULT` = '" + dataItem.STATUS.RESULT + @"' ";

                    where += whereStatus;
                }
                else
                {
                    whereStatus = @"`tb_5`.`RESULT` = '" + dataItem.STATUS.RESULT + @"' ";
                    where = whereStatus;
                }
            }

            //## WHERE FFT_ORDER_ID/GROUP.
            if (dataItem.FFT_ORDER_ID != "")
            {
                string whereFFT_Oder = "";
                if (where != "")
                {
                    whereFFT_Oder = @"
                        AND `tb_1`.`FFT_ORDER_ID` = '" + dataItem.FFT_ORDER_ID + @"' ";

                    where += whereFFT_Oder;
                }
                else
                {
                    whereFFT_Oder = @"`tb_1`.`FFT_ORDER_ID` = '" + dataItem.FFT_ORDER_ID + @"' ";
                    where = whereFFT_Oder;
                }

                if (dataItem.GROUP != "")
                {
                    where += @" 
                        AND `tb_1`.`GROUP` = '" + dataItem.GROUP + "' ";
                }
            }

            //## WHERE DATE/TO
            if (dataItem.INPUT_DATE != "" && dataItem.INPUT_DATE_TO != "")
            {
                string whereInputDate = "";
                if (where != "")
                {
                    whereInputDate = @" 
                        AND SUBSTR(`tb_1`.`ID`,1,6) >= DATE_FORMAT('" + dataItem.INPUT_DATE + @"','%y%m%d') 
                        AND SUBSTR(`tb_1`.`ID`,1,6) <= DATE_FORMAT('" + dataItem.INPUT_DATE_TO + "','%y%m%d') ";

                    where += whereInputDate;
                }
                else
                {
                    whereInputDate = @"SUBSTR(`tb_1`.`ID`,1,6) >= DATE_FORMAT('" + dataItem.INPUT_DATE + @"','%y%m%d') 
                        AND SUBSTR(`tb_1`.`ID`,1,6) <= DATE_FORMAT('" + dataItem.INPUT_DATE_TO + "','%y%m%d') ";

                    where = whereInputDate;
                }
            }
            //## WHERE DATE
            else if (dataItem.INPUT_DATE != "" && dataItem.INPUT_DATE_TO == "")
            {
                string whereInputDate = "";
                if (where != "")
                {
                    whereInputDate = @" 
                        AND SUBSTR(`tb_1`.`ID`,1,6) = DATE_FORMAT('" + dataItem.INPUT_DATE + @"','%y%m%d') ";

                    where += whereInputDate;
                }
                else
                {
                    whereInputDate = @"SUBSTR(`tb_1`.`ID`,1,6) = DATE_FORMAT('" + dataItem.INPUT_DATE + @"','%y%m%d') ";

                    where = whereInputDate;
                }
            }


            sql = where == "" ?
                    select + @" 

                        WHERE SUBSTR(`tb_1`.`ID`,1,4) = DATE_FORMAT(NOW(), '%y%m')

                       ORDER BY 
                       `tb_1`.`SERIAL_ID` DESC
                       ,`tb_1`.`NO`;" :

                    select + @"
                         
                        WHERE " + where + @"

                        ORDER BY 
                        `tb_1`.`SERIAL_ID` DESC
                       ,`tb_1`.`NO`;";

            return sql;
        }

        public string SearchCurrentProgress(SearchSerialProgressProperty dataItem)
        {
            string select = @"SELECT `tb_3`.`SERIAL` AS `SERIAL`
                        ,`tb_1`.`NO` AS `NO`
                        ,`tb_1`.`FFT_ORDER_ID` AS `FFT_ORDER_ID`
                        ,`tb_1`.`GROUP` AS `GROUP`
												,`tb_9`.`INPUT_TYPE` AS `INPUT_TYPE`
                        ,`tb_4`.`FLOW_NAME` AS `FLOW_NAME`
                        ,IF(`tb_7`.`NO` IS NULL OR `tb_7`.`NO` = '','N/A',`tb_7`.`NO`)  AS `PROCESS_NO`
                        ,`tb_5`.`PROCESS_NAME` AS `PROCESS_NAME`
                        ,`tb_6`.`RESULT` AS `RESULT`
                        ,`tb_1`.`ID` AS `PROGRESS_ID`
                        ,`tb_1`.`LAST_UPDATE` AS `LAST_UPDATE`

                        FROM `progress` AS `tb_1`

                        INNER JOIN (SELECT `SERIAL_ID`,MAX(`NO`) AS `MAX_NO`FROM `progress` GROUP BY `SERIAL_ID`) AS `tb_2` 
                        ON (`tb_2`.`SERIAL_ID` = `tb_1`.`SERIAL_ID` AND `tb_2`.`MAX_NO` = `tb_1`.`NO`)

                        INNER JOIN `serial` AS `tb_3`
                        ON (`tb_3`.`ID` = `tb_1`.`SERIAL_ID`)

                        INNER JOIN `flow` AS `tb_4`     
                        ON (`tb_4`.`ID` = `tb_1`.`FLOW_ID`)

                        INNER JOIN `process` AS `tb_5`  
                        ON (`tb_5`.`ID`  = `tb_1`.PROCESS_ID)
                        
                        INNER JOIN `result` AS `tb_6` 
                        ON (`tb_6`.`ID` = `tb_1`.`RESULT_ID`)

                        LEFT JOIN `process_flow` AS `tb_7` 
                        ON (`tb_7`.`FLOW_ID` = `tb_1`.`FLOW_ID` AND `tb_7`.`PROCESS_ID` = `tb_1`.`PROCESS_ID`) 

						INNER JOIN `input` AS `tb_8` 
                        ON (`tb_8`.`FFT_ORDER_ID` = `tb_1`.FFT_ORDER_ID AND `tb_8`.`GROUP` = `tb_1`.`GROUP`)

                        INNER JOIN `input_type` AS `tb_9`
                        ON (`tb_9`.`ID` = `tb_8`.`INPUT_TYPE_ID`) ";


            string where = "";

            //## WHERE Serial.
            string whereSerial = "";
            foreach (string _serial in dataItem.SERIAL)
            {
                if (_serial.Trim() != "")
                {
                    if (whereSerial == "") { whereSerial = "'" + _serial + "'"; }
                    else { whereSerial += ",'" + _serial + "'"; }
                }
            }

            if (whereSerial != "")
            {
                whereSerial = @"`tb_3`.`SERIAL` IN (" + whereSerial + @") ";
                where = whereSerial;
            }

            //## WHERE Process.
            if (dataItem.PROCESS.PROCESS_NAME != "")
            {
                string whereProcess = "";
                if (where != "")
                {
                    whereProcess = @"
                        AND `tb_5`.`PROCESS_NAME` = '" + dataItem.PROCESS.PROCESS_NAME + @"' ";

                    where += whereProcess;
                }
                else
                {
                    whereProcess = @"`tb_5`.`PROCESS_NAME` = '" + dataItem.PROCESS.PROCESS_NAME + @"' ";
                    where = whereProcess;
                }
            }

            //## WHERE Status(Result).
            if (dataItem.STATUS.RESULT != "")
            {
                string whereStatus = "";
                if (where != "")
                {
                    whereStatus = @"
                        AND `tb_6`.`RESULT` = '" + dataItem.STATUS.RESULT + @"' ";

                    where += whereStatus;
                }
                else
                {
                    whereStatus = @"`tb_6`.`RESULT` = '" + dataItem.STATUS.RESULT + @"' ";
                    where = whereStatus;
                }
            }

            //## WHERE FFT_ORDER_ID/GROUP.
            if (dataItem.FFT_ORDER_ID != "")
            {
                string whereFFT_Oder = "";
                if (where != "")
                {
                    whereFFT_Oder = @"
                        AND `tb_1`.`FFT_ORDER_ID` = '" + dataItem.FFT_ORDER_ID + @"' ";

                    where += whereFFT_Oder;
                }
                else
                {
                    whereFFT_Oder = @"`tb_1`.`FFT_ORDER_ID` = '" + dataItem.FFT_ORDER_ID + @"' ";
                    where = whereFFT_Oder;
                }

                if (dataItem.GROUP != "")
                {
                    where += @" 
                        AND `tb_1`.`GROUP` = '" + dataItem.GROUP + "' ";
                }
            }

            //## WHERE DATE/TO
            if (dataItem.INPUT_DATE != "" && dataItem.INPUT_DATE_TO != "")
            {
                string whereInputDate = "";
                if (where != "")
                {
                    whereInputDate = @" 
                        AND SUBSTR(`tb_1`.`ID`,1,6) >= DATE_FORMAT('" + dataItem.INPUT_DATE + @"','%y%m%d') 
                        AND SUBSTR(`tb_1`.`ID`,1,6) <= DATE_FORMAT('" + dataItem.INPUT_DATE_TO + "','%y%m%d') ";

                    where += whereInputDate;
                }
                else
                {
                    whereInputDate = @"SUBSTR(`tb_1`.`ID`,1,6) >= DATE_FORMAT('" + dataItem.INPUT_DATE + @"','%y%m%d') 
                        AND SUBSTR(`tb_1`.`ID`,1,6) <= DATE_FORMAT('" + dataItem.INPUT_DATE_TO + "','%y%m%d') ";

                    where = whereInputDate;
                }
            }
            //## WHERE DATE
            else if (dataItem.INPUT_DATE != "" && dataItem.INPUT_DATE_TO == "")
            {
                string whereInputDate = "";
                if (where != "")
                {
                    whereInputDate = @" 
                        AND SUBSTR(`tb_1`.`ID`,1,6) = DATE_FORMAT('" + dataItem.INPUT_DATE + @"','%y%m%d') ";

                    where += whereInputDate;
                }
                else
                {
                    whereInputDate = @"SUBSTR(`tb_1`.`ID`,1,6) = DATE_FORMAT('" + dataItem.INPUT_DATE + @"','%y%m%d') ";

                    where = whereInputDate;
                }
            }


            sql = where == "" ?
                    select + @" 

                        WHERE SUBSTR(`tb_1`.`ID`,1,4) = DATE_FORMAT(NOW(), '%y%m')

                       GROUP BY 
                       `tb_1`.`SERIAL_ID`

                       ORDER BY 
                       `tb_1`.`SERIAL_ID` DESC
                       ,`tb_1`.`NO`;" :

                    select + @"
                         
                        WHERE " + where + @"
                        
                       GROUP BY 
                       `tb_1`.`SERIAL_ID`

                        ORDER BY 
                        `tb_1`.`SERIAL_ID` DESC
                       ,`tb_1`.`NO`;";

            return sql;
        }

    }
}