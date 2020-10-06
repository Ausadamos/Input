using System.Collections.Generic;

namespace InputManagement.Property
{
    public class SearchSerialInputProperty
    {
        public List<string> SERIAL { get; set; }
        public string PURCHASE { get; set; }
        public string FFT_ORDER_ID { get; set; }
        public string GROUP { get; set; }
        public string PRODUCT_SUB_NAME { get; set; }
        public string INUSE { get; set; }
        public string INPUT_DATE { get; set; }
        public string INPUT_DATE_TO { get; set; }
    }
    public class SearchSerialProgressProperty
    {
        public List<string> SERIAL { get; set; }
        public ProcessProperty PROCESS { get; set; }
        public bool SELECT_SHOW_CURRENT_PROCESS { get; set; }
        public string FFT_ORDER_ID { get; set; }
        public string GROUP { get; set; }
        public string PRODUCT_SUB_NAME { get; set; }
        public string INPUT_DATE { get; set; }
        public string INPUT_DATE_TO { get; set; }
        public ResultProperty STATUS { get; set; }
    }
    public class SearchOrderDetailProperty
    {
        public List<string> FFT_ORDER_ID { get; set; }
        public string PRODUCT_SUB_NAME { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string INPUT_DATE { get; set; }
        public string INPUT_DATE_TO { get; set; }
        public bool THIS_YEAR { get; set; }

    }
    public class SearchPurchaseProperty
    {
        public List<string> Document { get; set; }
        public string FFT_CODE { get; set; }
        public string PART_NO { get; set; }
        public string INPUT_DATE { get; set; }
        public string INPUT_DATE_TO { get; set; }
        public bool THIS_YEAR { get; set; }
    }


}