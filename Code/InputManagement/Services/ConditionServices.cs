using BusinessData.Interface;
using BusinessData.Property;
using BusinessData.Models;

using InputManagement.Property;
using InputManagement.SQLFactory;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace InputManagement.Services
{
    public class ConditionServices : DatabaseAction<ConditionProperty>
    {
        OutputOnDbProperty resultData = new OutputOnDbProperty();
        ConditionSQLFactory _sqlFactory = new ConditionSQLFactory();
        private string sql;

        public OutputOnDbProperty SearchPartNO(ConditionProperty dataItem)
        {
            sql = _sqlFactory.SearchPartNO(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchWorkOrder(ConditionProperty dataItem)
        {
            sql = _sqlFactory.SearchWorkOrder(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchCustomer(ConditionProperty dataItem)
        {
            sql = _sqlFactory.SearchCustomer(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchProduct(ConditionProperty dataItem)
        {
            sql = _sqlFactory.SearchProduct(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchCondition(ConditionProperty dataItem)
        {
            sql = _sqlFactory.SearchCondition(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }


        public override OutputOnDbProperty Delete(ConditionProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Insert(ConditionProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search(ConditionProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search()
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Update(ConditionProperty dataItem)
        {
            throw new NotImplementedException();
        }
    }
}