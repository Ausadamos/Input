using BusinessData.Interface;
using BusinessData.Property;

using InputManagement.Property;
using InputManagement.SQLFactory;

using System;
using System.Collections.Generic;

namespace InputManagement.Services
{
    public class PurchaseServices : DatabaseAction<PurchaseProperty>
    {
        OutputOnDbProperty resultData = new OutputOnDbProperty();
        PurchaseSQLFactory _sqlFactoryPurchase = new PurchaseSQLFactory();

        SerialTypeSQLFactory _sqlFactorySerialType = new SerialTypeSQLFactory();
        ProductTypeSQLFactory _sqlFactoryProductType = new ProductTypeSQLFactory();
        SerialProductTypeSQLFactory _sqlFactorySerialProductType = new SerialProductTypeSQLFactory();

        ConditionServices _conditionServices = new ConditionServices();
        ConditionSQLFactory _conditionSQLFactory = new ConditionSQLFactory();

        private string sql;

        public OutputOnDbProperty LoadPurchaseAll()
        {
            sql = _sqlFactoryPurchase.LoadPurchaseAll();
            resultData = base.SearchBySql(sql);
            return resultData;
        }
        public OutputOnDbProperty LastPurchase(ShipmentProperty dataItem)
        {
            sql = _sqlFactoryPurchase.LastPurchase(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }
        public OutputOnDbProperty UsedPurchase(ShipmentProperty dataItem)
        {
            sql = _sqlFactoryPurchase.UsedPurchase(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }
        public OutputOnDbProperty SearchPurchasesOrder(OrderProperty dataItem)
        {
            sql = _sqlFactoryPurchase.SearchPurchasesOrder(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchModelNO(PurchaseProperty dataItem)
        {
            sql = _sqlFactoryPurchase.SearchModelNO(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchProductPurchase(PurchaseProperty dataItem)
        {
            sql = _sqlFactoryPurchase.SearchProductPurchase(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchFFTCode(PurchaseProperty dataItem)
        {
            sql = _sqlFactoryPurchase.SearchFFTCode(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchPurchase(PurchaseProperty dataItem)
        {
            sql = _sqlFactoryPurchase.SearchPurchase(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchFlowProcess(PurchaseProperty dataItem)
        {
            sql = _sqlFactoryPurchase.SearchFlowProcess(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchPathProcessCard(PurchaseProperty dataItem)
        {
            sql = _sqlFactoryPurchase.SearchPathProcessCard(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty SearchAllProductType()
        {
            sql = _sqlFactoryPurchase.SearchAllProductType();
            resultData = base.SearchBySql(sql);
            return resultData;
        }
        public OutputOnDbProperty CheckFlowProcess(PurchaseProperty dataItem)
        {
            sql = _sqlFactoryPurchase.CheckFlowProcess(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }


        public OutputOnDbProperty UpdateProcessCardPurchase(PurchaseProperty dataItem)
        {
            OutputOnDbProperty resultData_InSide = new OutputOnDbProperty();
            List<string> _listSQL = new List<string>();
            resultData_InSide = this.SearchPathProcessCard(dataItem);
            if (resultData_InSide.StatusOnDb == true)
            {

                if (resultData_InSide.ResultOnDb.Rows.Count <= 0)
                {
                    _listSQL.Add(_sqlFactoryPurchase.InsertPathProcessCard(dataItem));
                }
                else
                {
                    _listSQL.Add(_sqlFactoryPurchase.UpdateProcessCardPurchase(dataItem));
                }

                //Update Inuse = 0 
                _listSQL.Add(_sqlFactoryPurchase.UpdateFlowProcessALL(dataItem));

                //Check Flow Process 
                resultData_InSide = this.CheckFlowProcess(dataItem);
                if (resultData_InSide.StatusOnDb == true)
                {
                    if (resultData_InSide.ResultOnDb.Rows.Count <= 0)
                    {
                        //Insert Flow Process
                        _listSQL.Add(_sqlFactoryPurchase.InsertNewFlowProcess(dataItem));
                    }
                    else
                    {
                        //Updata INUSE 0 => 1
                        _listSQL.Add(_sqlFactoryPurchase.UpdateFlowProcess(dataItem));

                    }
                }
                resultData = base.InsertBySqlList(_listSQL);
            }
            else
            {
                resultData = resultData_InSide;
            }
            return resultData;
        }

        public OutputOnDbProperty InsertNewPurchase(PurchaseProperty dataItem)
        {
            ConditionProperty _condition = new ConditionProperty { PART_NO = dataItem.PART_NO };
            OutputOnDbProperty resultData_InSide = new OutputOnDbProperty();
            List<string> _listSQL = new List<string>();


            //## Check Part_No. ######################################################################
            resultData_InSide = _conditionServices.SearchPartNO(_condition);
            if (resultData_InSide.StatusOnDb == true)
            {
                //No PartNo in DB.
                if (resultData_InSide.ResultOnDb.Rows.Count <= 0)
                {
                    //Get Qry InsertPartNo to sqlList.
                    _listSQL.Add(_conditionSQLFactory.InsertPartNO(_condition));
                }
            }
            else
            {
                return resultData_InSide;
            }

            //## Check Model_No. ######################################################################
            resultData_InSide = this.SearchModelNO(dataItem);
            if (resultData_InSide.StatusOnDb == true)
            {
                //No Model_No in DB.
                if (resultData_InSide.ResultOnDb.Rows.Count <= 0)
                {
                    //Get Qry InsertModelNO to sqlList.
                    _listSQL.Add(_sqlFactoryPurchase.InsertModelNO(dataItem));
                }
            }
            else
            {
                return resultData_InSide;
            }


            //## Check Product Purchase. ######################################################################
            resultData_InSide = this.SearchProductPurchase(dataItem);
            if (resultData_InSide.StatusOnDb == true)
            {
                //No Product Purchase in DB.
                if (resultData_InSide.ResultOnDb.Rows.Count <= 0)
                {
                    //Get Qry InsertProductPurchase to sqlList.
                    _listSQL.Add(_sqlFactoryPurchase.InsertProductPurchase(dataItem));
                }
            }
            else
            {
                return resultData_InSide;
            }

            //## Check Purchase. ######################################################################
            resultData_InSide = this.SearchPurchase(dataItem);
            if (resultData_InSide.StatusOnDb == true)
            {
                //No Purchase in DB.
                if (resultData_InSide.ResultOnDb.Rows.Count <= 0)
                {
                    //Get Qry InsertPurchase to sqlList.
                    _listSQL.Add(_sqlFactoryPurchase.InsertPurchase(dataItem));
                }
                else
                {
                    resultData_InSide.StatusOnDb = false;
                    resultData_InSide.MessageOnDb = "Duplicate Purchase No.";
                    return resultData_InSide;
                }
            }
            else
            {
                return resultData_InSide;
            }

            // by Boat 03/11/2019
            //## Check Product Type. ######################################################################
            // _listSQL.Add(_sqlFactoryPurchase.InsertProductType(dataItem));


            //## Get Qry Insert Path Process Card to sqlList.. ######################################################################
            _listSQL.Add(_sqlFactoryPurchase.InsertPathProcessCard(dataItem));


            //## Check FFT_Code. ######################################################################
            resultData_InSide = this.SearchFFTCode(dataItem);
            if (resultData_InSide.StatusOnDb == true)
            {
                //No FFT_Code in DB.
                if (resultData_InSide.ResultOnDb.Rows.Count <= 0)
                {
                    //Get Qry InsertFFTCode to sqlList.
                    _listSQL.Add(_sqlFactoryPurchase.InsertFFTCode(dataItem));
                }
                else
                {
                    resultData_InSide.StatusOnDb = false;
                    resultData_InSide.MessageOnDb = "Duplicate FFT_Code.";
                    return resultData_InSide;
                }
            }
            else
            {
                return resultData_InSide;
            }

            //Get Qry InsertPurchase_fft_code to sqlList.
            _listSQL.Add(_sqlFactoryPurchase.InsertPurchase_FFT_Code(dataItem));

            //## Check flow_process. ######################################################################
            resultData_InSide = this.SearchFlowProcess(dataItem);
            if (resultData_InSide.StatusOnDb == true)
            {
                //No Purchase in DB.
                if (resultData_InSide.ResultOnDb.Rows.Count <= 0)
                {
                    //Get Qry InsertPurchase to sqlList.
                    _listSQL.Add(_sqlFactoryPurchase.InsertFlowProcess(dataItem));
                }
                else
                {
                    //Get Qry UpdateUSEFlowProcess to sqlList.
                    _listSQL.Add(_sqlFactoryPurchase.UpdateUSEFlowProcess(dataItem));
                }
            }
            else
            {
                return resultData_InSide;
            }
            _listSQL.Add(_sqlFactoryPurchase.InsertPurchaseProductType(dataItem));

            resultData = base.InsertBySqlList(_listSQL);
            return resultData;
        }

        //by BOAT 01/11/2019
        public OutputOnDbProperty InsertProductType(SerialProductTypeProperty dataItem)
        {
            //SerialProductTypeProperty _serialType = new SerialProductTypeProperty { PART_NO = dataItem.PART_NO };

            OutputOnDbProperty resultData_InSide = new OutputOnDbProperty();
            List<string> _listSQL = new List<string>();

            //## Check Serial Format. ######################################################################
            resultData_InSide = SearchSerialFormat(dataItem);
            if (resultData_InSide.StatusOnDb == true)
            {
                //No Serial Format in DB.
                if (resultData_InSide.ResultOnDb.Rows.Count <= 0)
                {
                    //Get Qry Insert Serial Format to sqlList.
                    _listSQL.Add(_sqlFactorySerialType.InsertSerialFormat(dataItem.serialTypeProperty));
                }
            }
            else
            {
                return resultData_InSide;
            }

            //## Check ProductTitle . ######################################################################
            resultData_InSide = this.SearchProductTitle(dataItem);
            if (resultData_InSide.StatusOnDb == true)
            {
                //No ProductTitle  in DB.
                if (resultData_InSide.ResultOnDb.Rows.Count <= 0)
                {
                    //Get Qry Insert ProductTitle to sqlList.
                    _listSQL.Add(_sqlFactoryProductType.InsertProductTitle(dataItem.productTypeProperty));
                }
            }
            else
            {
                return resultData_InSide;
            }

            //Check Serial Type In database
            resultData_InSide = this.SearchExistProductType(dataItem);
            if (resultData_InSide.StatusOnDb == true)
            {
                //No Serial product type  in DB.
                if (resultData_InSide.ResultOnDb.Rows.Count <= 0)
                {
                    //Get Qry Insert Serial product type to sqlList.
                    _listSQL.Add(_sqlFactorySerialProductType.InsertSerialProductType(dataItem));
                }
                else
                {
                    resultData_InSide.StatusOnDb = false;
                    resultData_InSide.MessageOnDb = "Duplicate Product Type.";
                    return resultData_InSide;
                }
            }
            else
            {
                return resultData_InSide;
            }



            resultData = base.InsertBySqlList(_listSQL);
            return resultData;
        }
        // by BOAT 01/11/2019
        public OutputOnDbProperty SearchSerialFormat(SerialProductTypeProperty dataItem)
        {
            sql = _sqlFactorySerialType.SearchSerialFormat(dataItem.serialTypeProperty);
            resultData = base.SearchBySql(sql);
            return resultData;
        }


        public OutputOnDbProperty SearchProductTitle(SerialProductTypeProperty dataItem)
        {

            sql = _sqlFactoryProductType.SearchProductTitle(dataItem.productTypeProperty);
            resultData = base.SearchBySql(sql);
            return resultData;
        }
        public OutputOnDbProperty SearchExistProductType(SerialProductTypeProperty dataItem)
        {
            sql = _sqlFactoryProductType.SearchExistProductType(dataItem.productTypeProperty);
            resultData = base.SearchBySql(sql);
            return resultData;
        }
        public OutputOnDbProperty SearchExistSerialProductType(SerialProductTypeProperty dataItem)
        {
            sql = _sqlFactorySerialProductType.SearchExistSerialProductType(dataItem);
            resultData = base.SearchBySql(sql);
            return resultData;
        }

        public OutputOnDbProperty UpdateSerialFormat(SerialProductTypeProperty dataItem)
        {
            OutputOnDbProperty resultData_InSide = new OutputOnDbProperty();
            List<string> _listSQL = new List<string>();


            //## Check product Title. ######################################################################
            resultData_InSide = this.SearchExistProductType(dataItem);
            if (resultData_InSide.StatusOnDb == true)
            {
                //Check Serial Title in DB.
                if (resultData_InSide.ResultOnDb.Rows.Count <= 0)
                {
                    resultData_InSide.StatusOnDb = false;
                    resultData_InSide.MessageOnDb = "Not found Serial Title.";
                    return resultData_InSide;
                }
            }
            else
            {
                return resultData_InSide;
            }

            //## Check Serial Format. ######################################################################
            resultData_InSide = this.SearchSerialFormat(dataItem);
            if (resultData_InSide.StatusOnDb == true)
            {
                //Check Serial Format in DB.
                if (resultData_InSide.ResultOnDb.Rows.Count <= 0)
                {
                    //insert serial format 
                    _listSQL.Add(_sqlFactorySerialType.InsertSerialFormat(dataItem.serialTypeProperty));

                }
            }
            else
            {
                return resultData_InSide;
            }

            // Update inuse = 0 table SerialproductType
            _listSQL.Add(_sqlFactorySerialProductType.UpdateInuseSerialProductType(dataItem));


            //## Check SerialproductType. ######################################################################
            //resultData_InSide = this.SearchExistSerialProductType(dataItem);
            //if (resultData_InSide.StatusOnDb == true)
            //{
            //    //Check SerialproductType.
            //    if (resultData_InSide.ResultOnDb.Rows.Count <= 0)
            //    {
            //        _sqlFactorySerialType.SearchSerialFormat(new SerialTypeProperty
            //        {
            //            SERIAL_FORMAT = dataItem.serialTypeProperty.SERIAL_FORMAT
            //        });

            //        // insert SerialproductType 
            //        _listSQL.Add(_sqlFactorySerialProductType.InsertSerialProductType(dataItem));

            //    }
            //}
            //else
            //{
            //    return resultData_InSide;
            //}

            _sqlFactorySerialType.SearchSerialFormat(new SerialTypeProperty
            {
                SERIAL_FORMAT = dataItem.serialTypeProperty.SERIAL_FORMAT
            });

            // insert SerialproductType 
            _listSQL.Add(_sqlFactorySerialProductType.InsertSerialProductType(dataItem));

            resultData = base.InsertBySqlList(_listSQL);
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