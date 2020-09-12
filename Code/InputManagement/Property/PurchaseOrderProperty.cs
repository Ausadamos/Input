using Login.Property;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InputManagement.Property
{
    public class PurchaseOrderProperty
    {
        public  OrderProperty Order { get; set; }
        public FlowProperty Flow { get; set; }
        public SerialProperty Serial { get; set; }
        public  InputtypeProperty Input { get; set; }
        public string PO { get; set; }


    }
}