using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InputManagement.Property
{
    public class SearchSerialInputProperty
    {
        public List<string> SERIAL { get; set; }
        public string PURCHASE { get; set; }
        public string FFT_ORDER_ID { get; set; }
        public string GROUP { get; set; }
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
        public string INPUT_DATE { get; set; }
        public string INPUT_DATE_TO { get; set; }
        public ResultProperty STATUS { get; set; }

    }
}