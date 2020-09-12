using InputManagement.Property;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InputManagement.SQLFactory
{
    public class ShipmentSQLFactory
    {
        private string sql;

        public string SearchSerailShipping(ShipmentProperty dataItem)
        {
            sql = @"SELECT 'Shipment' AS ACTION,
		            T_SERIAL.SERIAL_NO,
		            T_SO.SO_NO,
		            T_SO.SO_LINE_NO,
		            max(T_SO.SHIPMENT_DATE) AS SHIPMENT_DATE,
		            DATE_FORMAT(T_SO.SHIPMENT_DATE,'%d/%m/%Y') AS SHIPMENT_DATE_TXT,
		            T_SO.PRODUCT_CODE,
		            T_SO.PRODUCT_DESC,
		            T_SO.PRODUCT_TYPE,
		            T_SO.PO_NO,
		            T_PICKUP.INVOICE_NO,
		            T_DETAIL.INNER_QTY,
		            T_DETAIL.MIDDLE_ID,
		            T_DETAIL.MIDDLE_BOX,
		            T_DETAIL.OUTER_NO,
		            T_DETAIL.OUTER_BOX,
		            T_PS.BOX_NO,
		            T_PS.PS_NO,
		            T_PACKING.BOX_NO AS MIDDLE_BOX_NO
		

                    FROM SHIPPING_T_SO T_SO

		                LEFT JOIN SHIPPING_T_MIDDLE_DETAIL T_DETAIL
		                ON T_DETAIL.SO_NO = T_SO.SO_NO

		                AND T_DETAIL.SO_LINE_NO = T_SO.SO_LINE_NO
		                LEFT JOIN SHIPPING_T_PICKUP T_PICKUP

		                ON T_SO.SO_NO = T_PICKUP.SO_NO
		                AND T_SO.SO_LINE_NO = T_PICKUP.SO_LINE_NO

		                LEFT JOIN SHIPPING_T_PS T_PS
		                ON T_DETAIL.OUTER_NO = T_PS.BOX_NO

		                LEFT JOIN SHIPPING_T_PACKING T_PACKING
		                ON T_PACKING.PS_NO = T_PS.PS_NO

		                LEFT JOIN SHIPPING_T_PACKING_DETAIL T_SERIAL
		                ON T_PACKING.BOX_NO = T_SERIAL.BOX_NO

                    WHERE T_SO.`STATUS` <> 'Delete'
                    AND T_SERIAL.SERIAL_NO =  '" + dataItem.SERIAL_NO + @"';";



            return sql;
        }
        public string SearchSerailShippingReturn(ShipmentProperty dataItem)
        {
            sql = @" SELECT 
                    'Return' AS ACTION,
                    '' AS SO_NO,
                    '' AS SO_LINE_NO,
                    RE.RECEIVED_DATE AS SHIPMENT_DATE,
                    DATE_FORMAT(RE.RECEIVED_DATE,'%d/%m/%Y') AS SHIPMENT_DATE_TXT,
                    RE.PRODUCT_CODE,
                    '' AS PRODUCT_DESC,
                    '' AS PRODUCT_TYPE,
                    '' AS PO_NO,
                    '' AS INVOICE_NO,
                    '' AS INNER_QTY,
                    '' AS MIDDLE_ID,
                    '' AS MIDDLE_BOX,
                    '' AS OUTER_NO,
                    '' AS OUTER_BOX,
                    '' AS BOX_NO,
                    '' AS PS_NO,
                    '' AS MIDDLE_BOX_NO,
                    RE.SERIAL_NO 

                    FROM SHIPPING_T_PACKING_DETAIL_RETURN RE
                    WHERE RE.SERIAL_NO = '" + dataItem.SERIAL_NO + @"';";

            return sql;

        }
    }
}