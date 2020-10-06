namespace InputManagement.Property
{
    public class ProcessFlowProperty
    {
        public FlowProperty FLOW { get; set; }
        public ProcessProperty PROCESS { get; set; }
        public string NO { get; set; }

        public string DESCRIPTION { get; set; }
        public string CREATE_USER { get; set; }
        public string LAST_USER { get; set; }
        public string CREATE_DATE { get; set; }
        public string LAST_DATE { get; set; }
    }
}