namespace InputManagement.Property
{
    public class SerialProductTypeProperty
    {
        public string ID { get; set; }

        public ProductTypeProperty PRODUCT_TYPE { get; set; }
        public SerialTypeProperty SERIAL_TYPE { get; set; }

        public string INUSE { get; set; }
        public string DESCRIPTION { get; set; }
        public string CREATE_USER { get; set; }
        public string LAST_USER { get; set; }
        public string CREATE_DATE { get; set; }
        public string LAST_DATE { get; set; }

    }

}