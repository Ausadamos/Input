using InputManagement.Property;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InputManagement.SQLFactory
{
    public class POSQLFactory
    {
        private string sql;

        public string SearchSerialUpdatePO(InputProperty dataItem)
        {
            sql = @"SELECT tb2.SERIAL
			               ,tb2.ID AS ID_SERIAL
			               ,tb1.FFT_ORDER_ID
			               ,tb1.`GROUP`
			               ,tb1.FLOW_ID
			               ,tb4.INPUT_TYPE
			               ,tb6.PO 

                    FROM `input_serial` AS tb1

                    INNER JOIN `serial` AS tb2
                    ON(tb2.ID = tb1.SERIAL_ID)

                    INNER JOIN `input` AS tb3
                    ON(tb3.FFT_ORDER_ID = tb1.FFT_ORDER_ID AND tb3.`GROUP` = tb1.`GROUP`)

                    INNER JOIN `input_type` AS tb4
                    ON(tb4.ID = tb3.INPUT_TYPE_ID)

                    INNER JOIN `flow` AS tb5
                    ON(tb5.ID = tb1.FLOW_ID)

                    LEFT JOIN `po` AS tb6
                    ON(tb6.SERIAL_ID = tb1.SERIAL_ID AND tb6.FFT_ORDER_ID = tb1.FFT_ORDER_ID AND tb6.`GROUP` = tb1.`GROUP` AND tb6.FLOW_ID = tb1.FLOW_ID)

                    WHERE tb1.INUSE = '1'
                    AND tb2.SERIAL = '" + dataItem.SERIAL_NO + @"';";

            return sql;
        }
        public string SearchPO(PurchaseOrderProperty dataItem)
        {
            sql = @"SELECT SERIAL_ID, FFT_ORDER_ID,`GROUP`
                    FROM `po`
                    WHERE REPLACE(SERIAL_ID, ' ', '') = REPLACE('" + dataItem.Serial.ID + @"', ' ', '')
                    AND REPLACE(FFT_ORDER_ID, ' ', '') = REPLACE('" + dataItem.Order.FFT_ORDER_ID + @"', ' ', '')
                    AND REPLACE(`GROUP`, ' ', '') = REPLACE('" + dataItem.Order.GROUP + @"', ' ', '');";
            
            return sql;
        }
        public string InsertPO(PurchaseOrderProperty dataItem)
        {
            sql = @"INSERT INTO `po` (
						SERIAL_ID
                        ,FFT_ORDER_ID
                        ,`GROUP`
                        ,FLOW_ID
                        ,PO
                        ,EMP_ID
                    )
                    (
                         SELECT '" + dataItem.Serial.ID + @"' AS SERIAL_ID
                        ,'" + dataItem.Order.FFT_ORDER_ID + @"' AS FFT_ORDER_ID
                        ,'" + dataItem.Order.GROUP + @"' AS `GROUP`
                        ,'"+ dataItem.Flow.ID + @"' AS FLOW_ID
                        ,'" + dataItem.PO + @"' AS `PO`
                        ,'" + dataItem.Order.EMP.code + @"' AS `EMP`
                    );";
            return sql;
        }
        public string UpdataPO(PurchaseOrderProperty dataItem)
        {

                sql = @"UPDATE  `po`

                        SET po = 'TEST'

                        WHERE REPLACE(SERIAL_ID, ' ', '') = REPLACE('" + dataItem.Serial.ID + @"', ' ', '')
                        AND REPLACE(FFT_ORDER_ID, ' ', '') = REPLACE('" + dataItem.Order.FFT_ORDER_ID + @"', ' ', '')
                        AND REPLACE(`GROUP`, ' ', '') = REPLACE('" + dataItem.Order.GROUP + @"', ' ', '')
                        AND REPLACE(`FLOW_ID`, ' ', '') = REPLACE('" + dataItem.Flow.ID + @"', ' ', '');

                        ";

                return sql;

        }










    }
}