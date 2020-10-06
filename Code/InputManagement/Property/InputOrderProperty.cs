using Login.Property;

namespace InputManagement.Property
{
    public class OrderProperty
    {
        public string FFT_ORDER_ID { get; set; }
        public string GROUP { get; set; }
        public ConditionProperty CONDITION { get; set; }
        public string ORDER_QUANTITY { get; set; }
        public string ORDER_QUANTITY_HISTORY { get; set; }
        public string ORDER_TYPE_NAME { get; set; }
        public string ORDER_DATE { get; set; }
        public PurchaseProperty PURCHASR { get; set; }
        public EmpProperty EMP { get; set; }
        public SubProductProperty Sub_Product { get; set; }
    }

    public class InputProperty
    {
        public string SERIAL_NO { get; set; }
        public OrderProperty Order { get; set; }
        public ProcessProperty Process { get; set; }
        public string INPUT_DATE { get; set; }
    }

    public class InputtypeProperty
    {
        public string ORDER_TYPE_ID { get; set; }
        public string ORDER_TYPE_NAME { get; set; }
    }

}