namespace InputManagement.Property
{
    public class ProcessProperty
    {
        public string ID { get; set; }
        public string PRODUCT_SUB_CODE { get; set; }
        public string PROCESS_NAME { get; set; }
        public string INUSE { get; set; }
        public string DESCRIPTION { get; set; }
        public string CREATE_USER { get; set; }
        public string LAST_USER { get; set; }
        public string CREATE_DATE { get; set; }
        public string LAST_DATE { get; set; }

    }

    public class ResultProperty
    {
        public string ID { get; set; }
        public string RESULT { get; set; }
    }
}