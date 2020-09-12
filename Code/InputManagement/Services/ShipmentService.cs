using BusinessData.Interface;
using BusinessData.Property;

using InputManagement.Property;
using InputManagement.SQLFactory;

using System.Configuration;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InputManagement.Services
{
    public class ShipmentService : DatabaseAction<PurchaseProperty>
    {
        OutputOnDbProperty resultData = new OutputOnDbProperty();
        ShipmentSQLFactory _sqlFactory = new ShipmentSQLFactory();

        private string sql;
        public OutputOnDbProperty SearchSerailShipping(ShipmentProperty dataItem)
        {
            strConnection = ConfigurationManager.ConnectionStrings["ConnectionShipment"].ConnectionString;
            sql = _sqlFactory.SearchSerailShipping(dataItem);
            resultData = base.SearchBySql(sql);
            strConnection = ConfigurationManager.ConnectionStrings["ConnectionStrMysql"].ConnectionString;
            return resultData;
        }
        public OutputOnDbProperty SearchSerailShippingReturn(ShipmentProperty dataItem)
        {
            strConnection = ConfigurationManager.ConnectionStrings["ConnectionShipment"].ConnectionString;
            sql = _sqlFactory.SearchSerailShippingReturn(dataItem);
            resultData = base.SearchBySql(sql);
            strConnection = ConfigurationManager.ConnectionStrings["ConnectionStrMysql"].ConnectionString;
            return resultData;
        }

        public override OutputOnDbProperty Delete(PurchaseProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Insert(PurchaseProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search(PurchaseProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search()
        {
            throw new NotImplementedException();
        }

     
        public override OutputOnDbProperty Update(PurchaseProperty dataItem)
        {
            throw new NotImplementedException();
        }
    }
}