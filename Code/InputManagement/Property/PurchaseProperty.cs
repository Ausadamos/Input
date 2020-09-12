using Login.Property;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InputManagement.Property
{
    public class PurchaseProperty
    {
        public string ID { get; set; }
        public string PURCHASE_NO { get; set; }
        public FlowProperty FLOW { get; set; }
        public string FFT_CODE { get; set; }
        public string PART_NO { get; set; }
        public string PRODUCT_PURCHASE { get; set; }
        public string MODEL { get; set; }
        public string DATE { get; set; }
        public EmpProperty EMP { get; set; }
        public string PATH_PROCESS_CARD { get; set; }
        public ProductTypeProperty PRODUCT_TYPE { get; set; } //by BOAT 03/11/2019
    }



}