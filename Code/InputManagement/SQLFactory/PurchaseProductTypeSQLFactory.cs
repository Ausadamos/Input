using InputManagement.Property;

namespace InputManagement.SQLFactory
{
    public class PurchaseProductTypeSQLFactory
    {
        private string sql;
        public string Search(PurchaseProductTypeProperty dataItem)
        {
            sql = @"SELECT tb_2.ID as PURCHASE_ID ,
                            tb_2.PURCHASE_NO ,
                            tb_3.PRODUCT_SUB_CODE ,
                            tb_3.PRODUCT_TITLE ,
                            tb_4.PART_NO ,
                            tb_5.MODEL_NO ,
                            tb_7.FFT_CODE 
                            from purchase_product_type tb_1 inner join purchase tb_2 on tb_1.PURCHASE_ID = tb_2.ID inner join product_type tb_3 on tb_1.PRODUCT_TYPE_ID = tb_3.ID  
                            inner join part_no tb_4 on tb_4.ID = tb_2.PART_NO_ID 
                            inner join model tb_5 on tb_5.ID = tb_2.MODEL_ID  
                            inner join purchase_fft_code tb_6 on tb_2.ID = tb_6.PURCHASE_ID 
                            inner join fft_code tb_7 on tb_6.FFT_CODE_ID = tb_7.ID 
                            where tb_3.PRODUCT_SUB_CODE ='dataItem.PRODUCT_TYPE.PRODUCT_SUB_CODE'";

            sql = sql.Replace("dataItem.PRODUCT_TYPE.PRODUCT_SUB_CODE", dataItem.PRODUCT_TYPE.PRODUCT_SUB_CODE);

            return sql;
        }

    }
}