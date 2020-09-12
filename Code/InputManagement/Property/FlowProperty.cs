using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InputManagement.Property
{
    public class FlowProcessProperty
    {
        public FlowProperty FLOW { get; set; }
        public List<ProcessProperty> PROCESS { get; set; }
    }
   
    public class FlowProperty
    {
        public string ID { get; set; }
        public string FLOW_NAME { get; set; }
        public string INUSE { get; set; }
        public string STATUS { get; set; }
    }

}