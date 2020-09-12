using BusinessData.Interface;
using BusinessData.Property;
using InputManagement.Property;
using InputManagement.SQLFactory;

namespace InputManagement.Services
{
    public class SerialProductTypeService : DatabaseAction<SerialProductTypeProperty>
    {
        OutputOnDbProperty resultData = new OutputOnDbProperty();
        SerialProductTypeSQLFactory _sqlFactory = new SerialProductTypeSQLFactory();
        private string sql;

        public override OutputOnDbProperty Delete(SerialProductTypeProperty dataItem)
        {
            throw new System.NotImplementedException();
        }

        public override OutputOnDbProperty Insert(SerialProductTypeProperty dataItem)
        {
            throw new System.NotImplementedException();
        }

        public override OutputOnDbProperty Search(SerialProductTypeProperty dataItem)
        {
            throw new System.NotImplementedException();
        }

        public OutputOnDbProperty SearchByProductTypeId(SerialProductTypeProperty dataItem)
        {
            sql = _sqlFactory.SearchByProductTypeId(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public override OutputOnDbProperty Search()
        {
            throw new System.NotImplementedException();
        }

        public override OutputOnDbProperty Update(SerialProductTypeProperty dataItem)
        {
            throw new System.NotImplementedException();
        }
    }
}