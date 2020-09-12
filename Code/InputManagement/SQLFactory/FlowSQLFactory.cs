using InputManagement.Property;
using System.Collections.Generic;

namespace InputManagement.SQLFactory
{
    public class FlowSQLFactory
    {
        private string sql;

        public string LoadFlowAll()
        {
            sql = "CALL FLOW_ALL;";

            return sql;
        }
        public string LoadFlow()
        {
            sql = @"SELECT tb1.ID AS FLOW_ID
                           ,tb1.FLOW_NAME
                           ,tb2.TYPE_NAME

                    FROM flow as tb1

                    INNER JOIN flow_type AS tb2
                    ON (tb2.ID = tb1.FLOW_TYPE_ID)

                    WHERE tb1.INUSE = '1'
                    AND tb1.ID > 0
                    AND tb2.TYPE_NAME = 'FLOW NORMAL'

                    ORDER BY tb1.ID";

            return sql;
        }

        public string GetMaxFlowName()
        {
            sql = @"SELECT MAX(tb1.`FLOW_NAME`) AS `MAX_FLOW` 

                    FROM `flow` AS tb1

                    INNER JOIN flow_type AS tb2
                    ON (tb2.ID = tb1.FLOW_TYPE_ID)
                    WHERE tb2.TYPE_NAME = 'FLOW NORMAL'
                    ;";
            return sql;
        }

        public List<string> InsertFlow(FlowProcessProperty dataItem)
        {
            List<string> listSql = new List<string>();

            //Insert Flow
            sql = @"INSERT INTO `flow` (
                        ID
                        ,FLOW_NAME
                        ,FLOW_TYPE_ID
                        ,INUSE
                    )
                    (
                        SELECT CASE WHEN COUNT(`ID`) = 0 THEN 1 ELSE MAX(`ID`)+1 END AS `ID`
                        ,'" + dataItem.FLOW.FLOW_NAME + @"' AS  `FLOW_NAME`
                        ,(SELECT ID FROM flow_type WHERE REPLACE(TYPE_NAME ,' ' , '' ) = REPLACE('FLOW NORMAL', ' ' , ''))
                        ,'1' AS `INUSE`

                        FROM `flow`
                    );";

            listSql.Add(sql);

            //Loop Insert Process
            foreach (ProcessProperty _process in dataItem.PROCESS)
            {
                //sql = @"INSERT INTO `process_flow` (
                //      `FLOW_ID`
                //      ,`NO`
                //      ,`PROCESS_ID`
                //        )
                //        (
                //            SELECT `ID` AS `FLOW_ID`
                //                , '" + _process.NO + @"' AS `NO`
                //                , '" + _process.ID + @"' AS `PROCESS_ID`

                //            FROM `flow` 
                //            WHERE  REPLACE(FLOW_NAME, ' ', '') = REPLACE('" + dataItem.FLOW.FLOW_NAME + @"', ' ', '')

                //        );";

                listSql.Add(sql);
            }

            return listSql;
        }

        public string UpdateStatus(FlowProperty dataItem)
        {
            sql = @"UPDATE `flow` 
                    SET INUSE = '" + dataItem.INUSE + @"'
                    WHERE REPLACE(FLOW_NAME, ' ', '') = REPLACE('" + dataItem.FLOW_NAME + @"', ' ', '');";
            return sql;
        }

        public string SearchFlowNameByPurchase(PurchaseProperty dataItem)
        {
            sql = @"SELECT tb_1.`PURCHASE_NO`
                        ,tb_3.FLOW_NAME
                        ,tb_4.PROCESS_ID
                        ,tb_5.PROCESS_NAME

                    FROM `purchase` AS tb_1

                    INNER JOIN `flow_process` AS tb_2
                    ON (tb_2.PURCHASE_ID = tb_1.ID )

                    INNER JOIN `flow` AS tb_3
                    ON (tb_3.ID = tb_2.FLOW_ID)

                    INNER JOIN `process_flow` AS tb_4 
                    ON(tb_4.FLOW_ID = tb_3.ID)

                    INNER JOIN `process` AS tb_5 
                    ON( tb_5.ID = tb_4.PROCESS_ID)


                    WHERE REPLACE(tb_1.`PURCHASE_NO`, ' ', '') = REPLACE('" + dataItem.PURCHASE_NO + @"', ' ', '')
                    AND tb_2.INUSE = 1 
                    AND tb_3.INUSE = 1

                    ORDER BY tb_4.`NO`";

            return sql;
        }
        public string SearchProcessByFlowName(FlowProperty dataItem)
        {
            sql = @"SELECT tb_1.FLOW_NAME
	                    ,tb_2.PROCESS_ID
	                    ,tb_2.`NO`
	                    ,tb_3.PROCESS_NAME
			
                    FROM `flow` AS tb_1
                    INNER JOIN `process_flow` AS tb_2 ON(tb_2.FLOW_ID = tb_1.ID)
                    INNER JOIN `process` AS tb_3 ON( tb_3.ID = tb_2.PROCESS_ID)
			
                    WHERE REPLACE(tb_1.`FLOW_NAME`, ' ', '') = REPLACE('" + dataItem.FLOW_NAME + @"', ' ', '')
                    AND tb_1.`INUSE` = '1'

                    ORDER BY tb_2.`NO`";

            return sql;
        }

        public string CheckDuplicateFlowProcess(string dataItem)
        {
            sql = @" SELECT tb_4.ID
                ,tb_4.FLOW_NAME
                ,tb_4.`STATUS`
                ,tb_4.`NO`
                ,tb_4.PROCESS_ID
                ,tb_4.PROCESS_NAME

                FROM  `flow` As tb_5

                INNER JOIN
                            (SELECT tb_1.ID
                            , tb_1.`FLOW_NAME` AS `FLOW_NAME`
					        , IF(tb_1.`INUSE` = '1','Use','Cancel') AS `STATUS`
					        ,(SELECT MAX(`NO`) FROM `process_flow` WHERE `FLOW_ID` = tb_1.ID GROUP BY `FLOW_ID`) AS `MAX_FLOW_NO`
					        ,tb_2.`NO` AS `NO`
					        ,tb_2.`PROCESS_ID` AS  `PROCESS_ID` 
					        ,tb_3.`PROCESS_NAME` AS `PROCESS_NAME`

					        FROM `flow` AS tb_1

                            INNER JOIN `process_flow` AS tb_2 ON(tb_2.FLOW_ID = tb_1.ID)
                            INNER JOIN `process` AS tb_3 ON(tb_3.ID = tb_2.PROCESS_ID)
                            ORDER BY tb_2.`FLOW_ID`,tb_2.`NO`) As tb_4

                ON(tb_4.ID = tb_5.ID)


                WHERE tb_4.MAX_FLOW_NO = '" + dataItem + @"'
                ORDER BY tb_4.`NO` , tb_4.FLOW_NAME";

            return sql;
        }
        public string CallFlowRMA()
        {
            sql = @" SELECT tb1.ID
			,tb1.FLOW_NAME
			,tb1.INUSE

            FROM flow as tb1
  
            WHERE tb1.id = '0'";

            return sql;


        }

    }
}