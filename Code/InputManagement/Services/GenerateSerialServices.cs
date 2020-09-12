using BusinessData.Interface;
using BusinessData.Property;
using BusinessData.Models;

using InputManagement.Property;
using InputManagement.SQLFactory;
using System.Configuration;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InputManagement.Services
{
    public class GenerateSerialServices : DatabaseAction<GenerateSerialProperty>
    {
        OutputOnDbProperty resultData = new OutputOnDbProperty();
        GenerateSerialSQLFactory _sqlFactory = new GenerateSerialSQLFactory();
        private string sql;

        public OutputOnDbProperty SearchProductType()
        {
            sql = _sqlFactory.SearchProductType();
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public override OutputOnDbProperty Delete(GenerateSerialProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Insert(GenerateSerialProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search(GenerateSerialProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search()
        {
            throw new NotImplementedException();
        }
        public override OutputOnDbProperty Update(GenerateSerialProperty dataItem)
        {
            throw new NotImplementedException();
        }
    }
}