using System.Collections.Generic;

namespace InputManagement.Property
{
    public class FlowProcessProperty
    {
        public PurchaseProperty PURCHASE { get; set; }
        public FlowProperty FLOW { get; set; }
        public string NO { get; set; }
        public string INUSE { get; set; }
        public string EMP_ID { get; set; }
        public string LAST_UPDATE { get; set; }

        //------------- other -----------
        public List<ProcessProperty> PROCESS { get; set; }
    }
}
