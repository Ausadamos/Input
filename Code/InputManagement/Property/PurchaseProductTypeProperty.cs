namespace InputManagement.Property
{
    public class PurchaseProductTypeProperty
    {
        public PurchaseProperty PURCHASE { get; set; }
        public ProductTypeProperty PRODUCT_TYPE { get; set; }
        public ModelProperty MODEL { get; set; }
        public PartNoProperty PART_NO { get; set; }
        public PurchaseFftCodeProperty PURCHASE_FFTCODE { get; set; }
    }
}