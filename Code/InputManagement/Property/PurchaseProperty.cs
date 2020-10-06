using Login.Property;

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

        //public PurchaseProperty DeepCopy()
        //{
        //    PurchaseProperty other = (PurchaseProperty)this.MemberwiseClone();
        //    other.ID = ID != null ? string.Copy(ID) : null;
        //    other.PURCHASE_NO = string.Copy(PURCHASE_NO);
        //    other.FLOW = new FlowProperty();
        //    other.FFT_CODE = string.Copy(FFT_CODE);
        //    other.PART_NO = string.Copy(PART_NO);
        //    other.PRODUCT_PURCHASE = string.Copy(PRODUCT_PURCHASE);
        //    other.MODEL = string.Copy(MODEL);
        //    other.DATE = string.Copy(DATE);
        //    other.EMP = new EmpProperty();
        //    other.PATH_PROCESS_CARD = string.Copy(DATE);
        //    other.PRODUCT_TYPE = new ProductTypeProperty();
        //    return other;
        //}

    }
}