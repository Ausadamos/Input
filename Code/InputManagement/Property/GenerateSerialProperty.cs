using System.Collections.Generic;

namespace InputManagement.Property
{
    public class GenerateSerialProperty
    {
        public List<SerialProperty> SERIAL { get; set; }
        public InputProperty ORDER_INPUT { get; set; }
        public SerialProductTypeProperty PRODCT_TYPE { get; set; }
    }


    public class SerialProperty
    {
        public string ID { get; set; }
        public string SERIAL { get; set; }
    }

    //public class ProductTypeProperty
    //{
    //    public string ID { get; set; }
    //    public string PRODUCT_TITLE { get; set; }

    //}







}