namespace InputManagement.SQLFactory
{
    public class ProductSubSQLFactory
    {
        private string sql;
        public string Search()
        {
            sql = @"SELECT * FROM `product_sub`
                    WHERE PRODUCT_MAIN_CODE = 'PDM-0001'";
            return sql;
        }

    }
}