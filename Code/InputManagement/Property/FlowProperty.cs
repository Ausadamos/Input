namespace InputManagement.Property
{


    public class FlowProperty
    {
        public string ID { get; set; }
        public string FLOW_NAME { get; set; }
        public string INUSE { get; set; }
        public string PRODUCT_SUB_CODE { get; set; }
        public FlowTypeProperty FLOW_TYPE { get; set; }
        public string STATUS { get; set; }
    }

}