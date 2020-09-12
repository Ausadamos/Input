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
    public class InputOrderServicecs : DatabaseAction<OrderProperty>
    {
        OutputOnDbProperty resultData = new OutputOnDbProperty();
        InputOrderSQLFactory _sqlFactory = new InputOrderSQLFactory();
        POSQLFactory _sqlFactoryPO = new POSQLFactory();

        ConditionServices _conditionServices = new ConditionServices();
        ConditionSQLFactory _conditionSQLFactory = new ConditionSQLFactory();

        private string sql;
        private List<string> sqlList;

        public OutputOnDbProperty GetDatetimeNow_InDB()
        {
            sql = _sqlFactory.GetDatetimeNow_InDB();
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        
        public OutputOnDbProperty GetOrderActualInput()
        {
            sql = _sqlFactory.GetOrderActualInput();
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchOrderInThisYear()
        {
            strConnection = ConfigurationManager.ConnectionStrings["ConnectionPC"].ConnectionString;
            sql = _sqlFactory.SearchOrderInThisYear();
            resultData = base.SearchBySql(sql);
            strConnection = ConfigurationManager.ConnectionStrings["ConnectionStrMysql"].ConnectionString;
            return resultData;
        }
        public OutputOnDbProperty SearchOrderAll()
        {
            strConnection = ConfigurationManager.ConnectionStrings["ConnectionPC"].ConnectionString;
            sql = _sqlFactory.SearchOrderAll();
            resultData = base.SearchBySql(sql);
            strConnection = ConfigurationManager.ConnectionStrings["ConnectionStrMysql"].ConnectionString;
            return resultData;
        }
        

        public OutputOnDbProperty SearchOrderUseDatabasePC(OrderProperty dataItem)
        {
            strConnection = ConfigurationManager.ConnectionStrings["ConnectionPC"].ConnectionString;
            sql = _sqlFactory.SearchOrderUseDatabasePC(dataItem);
            resultData = base.SearchBySql(sql);
            strConnection = ConfigurationManager.ConnectionStrings["ConnectionStrMysql"].ConnectionString;
            return resultData;
        }

        public OutputOnDbProperty SearchOrderInput(OrderProperty dataItem)
        {
            sql = _sqlFactory.SearchOrderInput(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }
        public OutputOnDbProperty SearchSerialUpdatePO(InputProperty dataItem)
        {
            sql = _sqlFactoryPO.SearchSerialUpdatePO(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }
        
        public OutputOnDbProperty SearchOrderHistory(OrderProperty dataItem)
        {
            sql = _sqlFactory.SearchOrderHistory(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchInputType(OrderProperty dataItem)
        {
            sql = _sqlFactory.SearchInputType(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchInputAll()
        {
            sql = _sqlFactory.SearchInputAll();
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SeachOrderQty(OrderProperty dataItem)
        {
            strConnection = ConfigurationManager.ConnectionStrings["ConnectionPC"].ConnectionString;
            sql = _sqlFactory.SeachOrderQty(dataItem);
            resultData = base.SearchBySql(sql);
            strConnection = ConfigurationManager.ConnectionStrings["ConnectionStrMysql"].ConnectionString;
            return resultData;
        }

        public OutputOnDbProperty UpdateInput(OrderProperty dataItem)
        {
            sql = _sqlFactory.UpdateInput(dataItem);
            resultData = base.UpdateBySql(sql);
            return resultData;
        }
        public OutputOnDbProperty CheckPo(PurchaseOrderProperty dataItem)
        {
            sql = _sqlFactoryPO.SearchPO(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }
        public OutputOnDbProperty InsertPO(PurchaseOrderProperty dataItem)
        {
            sql = _sqlFactoryPO.InsertPO(dataItem);
            resultData = base.InsertBySql(sql);
            return resultData;
        }
        public OutputOnDbProperty UpdataPO(PurchaseOrderProperty dataItem)
        {
            sql = _sqlFactoryPO.UpdataPO(dataItem);
            resultData = base.UpdateBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty InsertOrderUseDatabasePC(OrderProperty dataItem)
        {
            strConnection = ConfigurationManager.ConnectionStrings["ConnectionPC"].ConnectionString;
            sql = _sqlFactory.InsertOrderUseDatabasePC(dataItem);
            resultData = base.SearchBySql(sql);
            strConnection = ConfigurationManager.ConnectionStrings["ConnectionStrMysql"].ConnectionString;
            return resultData;
        }


        public OutputOnDbProperty SearchPO(PurchaseOrderProperty dataItem)
        {
            OutputOnDbProperty IN_resultData = new OutputOnDbProperty();
            //## Check PO ######################################################################
            IN_resultData = this.CheckPo(dataItem);
            if (IN_resultData.StatusOnDb == true)
            {
                
                if (IN_resultData.ResultOnDb.Rows.Count <= 0)
                {
                    //Insert PO
                    resultData = this.InsertPO(dataItem);

                }
                else
                {
                    //Updata PO
                    resultData = this.UpdataPO(dataItem);
                }
            }
            else
            {
                return IN_resultData;
            }

            return resultData;

        }

        public OutputOnDbProperty InsertOrder(List<OrderProperty> dataItem)
        {
            OutputOnDbProperty IN_resultData = new OutputOnDbProperty();

            sqlList = new List<string>();
            OrderProperty _order = dataItem[0];

            //## Check Part_No. ######################################################################
            IN_resultData = _conditionServices.SearchPartNO(_order.CONDITION);
            if (IN_resultData.StatusOnDb == true)
            {
                //No PartNo in DB.
                if (IN_resultData.ResultOnDb.Rows.Count <= 0)
                {
                    //Get Qry InsertPartNo to sqlList.
                    sqlList.Add(_conditionSQLFactory.InsertPartNO(_order.CONDITION));
                }
            }
            else
            {
                return IN_resultData;
            }


            //## Check Work_Order. ###################################################################
            IN_resultData = _conditionServices.SearchWorkOrder(_order.CONDITION);
            if (IN_resultData.StatusOnDb == true)
            {
                //No WorkOrder in DB.
                if (IN_resultData.ResultOnDb.Rows.Count <= 0)
                {
                    //Get Qry InsertWorkOrder to sqlList.
                    sqlList.Add(_conditionSQLFactory.InsertWorkOrder(_order.CONDITION));
                }
            }
            else
            {
                return IN_resultData;
            }


            //## Check Customer. ####################################################################
            IN_resultData = _conditionServices.SearchCustomer(_order.CONDITION);
            if (IN_resultData.StatusOnDb == true)
            {
                //No Customer in DB.
                if (IN_resultData.ResultOnDb.Rows.Count <= 0)
                {
                    //Get Qry InsertCustomer to sqlList.
                    sqlList.Add(_conditionSQLFactory.InsertCustomer(_order.CONDITION));
                }
            }
            else
            {
                return IN_resultData;
            }


            //## Check Produc  . ####################################################################
            IN_resultData = _conditionServices.SearchProduct(_order.CONDITION);
            if (IN_resultData.StatusOnDb == true)
            {
                //No Product in DB.
                if (IN_resultData.ResultOnDb.Rows.Count <= 0)
                {
                    //Get Qry InsertProduct to sqlList.
                    sqlList.Add(_conditionSQLFactory.InsertProduct(_order.CONDITION));
                }
            }
            else
            {
                return IN_resultData;
            }


            //## Check Condition. ##################################################################
            IN_resultData = _conditionServices.SearchCondition(_order.CONDITION);
            if (IN_resultData.StatusOnDb == true)
            {
                //No Condition in DB.
                if (IN_resultData.ResultOnDb.Rows.Count <= 0)
                {
                    //Get Qry InsertCondition to sqlList.
                    sqlList.Add(_conditionSQLFactory.InsertCondition(_order.CONDITION));
                }
            }
            else
            {
                return IN_resultData;
            }


            //## Check InputType. ####################################################################
            IN_resultData = this.SearchInputType(_order);
            if (IN_resultData.StatusOnDb == true)
            {
                //No InputType in DB.
                if (IN_resultData.ResultOnDb.Rows.Count <= 0)
                {
                    //Get Qry InsertInputType to sqlList.
                    sqlList.Add(_sqlFactory.InsertInputType(_order));
                }
            }
            else
            {
                return IN_resultData;
            }


            //Get Qry Insert InsertInputProduction.
            foreach (OrderProperty _item in dataItem)
            {
                //Insert Input
                sqlList.Add(_sqlFactory.InsertInputProduction(_item));

                //Input Purchase
                sqlList.Add(_sqlFactory.InsertInputPurchase(_item));
            }

            resultData = base.InsertBySqlList(sqlList);

            if (resultData.StatusOnDb)
            {
                //## Check Order_Use. ####################################################################
                IN_resultData = this.SearchOrderUseDatabasePC(_order);
                if (IN_resultData.StatusOnDb == true)
                {
                    //No Order_Use in DB.
                    if (IN_resultData.ResultOnDb.Rows.Count <= 0)
                    {
                        //Get Qry Insert Order_Use to sqlList.
                        resultData = this.InsertOrderUseDatabasePC(_order);
                    }
                }
                else
                {
                    return IN_resultData;
                }
            }
            return resultData;
    
        }
        





        public override OutputOnDbProperty Delete(OrderProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Insert(OrderProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search(OrderProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search()
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Update(OrderProperty dataItem)
        {
            throw new NotImplementedException();
        }
    }
}