using AppBudgetManager.Access;
using AppBudGetManager.Domain;
using AppBudGetManager.Domain.System;
using System;
using System.Data;
using System.Diagnostics;


namespace appBudgetManager.Domain
{
    public class ClsSystemServices
    {
        private static ClsSystemServices objSystemServices;
        private ClsSystem objSystem;
        public ClsTransactionService objTransactionService;

        private ClsSystemServices()
        {
            objSystem = ClsSystem.GetInstance();
            objTransactionService = new ClsTransactionService();
            RepoTransaction();
        }

        public static ClsSystemServices GetInstance() 
        { 
            if(objSystemServices == null)
            {
                objSystemServices = new ClsSystemServices() ;
                return objSystemServices;
            }
            else
            {
                return objSystemServices;
            }        
        }

        public ClsSystem GetSystem()
        {
            return objSystem;
        }

        #region Category
        public bool CreateCategory(int prmIdCategory, string prmName, string prmDescription)
        {
            try
            {     
                if (objTransactionService.InsertCategory(prmName, prmDescription))
                {
                    return objSystem.CreateCategory(prmIdCategory, prmName, prmDescription);
                }
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool UpdateCategory(int prmIdCategory, string prmName, string prmDescription)
        {
            try
            {
                if (objTransactionService.UpdateCategory(prmIdCategory, prmName, prmDescription))
                {
                    return objSystem.UpdateCategory(prmIdCategory, prmName, prmDescription);
                }       
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool DeleteCategory(int prmIdCategory)
        {
            try
            {
                if (objTransactionService.DeleteCategory(prmIdCategory))
                {
                    return objSystem.DeleteCategory(prmIdCategory);
                }
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        #endregion Category

        #region Transaction

        public bool CreateTransaction(int prmIdTransaction, double prmQuantity, string prmDate, string prmDescription, ClsCategory prmMyCategory, string prmType)
        {
            if (objTransactionService.InsertTransaction(prmQuantity, prmDescription, prmDate, prmMyCategory.GetIdCategory(), prmType))
            {
                return objSystem.CreateTransaction(prmIdTransaction, prmQuantity, prmDate, prmDescription, prmMyCategory, prmType);
            }
            return false;
        }
        public bool UpdateTransaction(int prmIdTransaction, double prmQuantity, string prmDate, string prmDescription, ClsCategory prmMyCategory, string prmType)
        {
            if (objTransactionService.UpdateTransaction(prmIdTransaction, prmQuantity, prmDescription, prmDate, prmMyCategory.GetIdCategory(), prmType))
            {
                return objSystem.UpdateTransaction(prmIdTransaction, prmQuantity, prmDate, prmDescription, prmMyCategory, prmType);
            }
            return false;
        }
        public bool DeleteTransaction(int prmIdTransaction, string prmType)
        {
            if (objTransactionService.DeleteTransaction(prmIdTransaction))
            {
                return objSystem.DeleteTransaction(prmIdTransaction,prmType);
            }
            return false;
        }

        #endregion Transaction

        #region Load data
        private void RepoTransaction()
        {
            DataSet dtTransaction = new DataSet();
            DataSet dtCategory = new DataSet();
            dtTransaction = objTransactionService.ConsultTransaction();
            dtCategory = objTransactionService.ConsultCategory();


            foreach (DataTable table in dtCategory.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    objSystem.CreateCategory(Convert.ToInt32(row["idCategory"]), row["name"].ToString(), row["description"].ToString());
                }
            }

            foreach (DataTable table in dtTransaction.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    objSystem.fldMyBudGet.CreateTransaction(Convert.ToInt32(row["idTransaction"]), Convert.ToDouble(row["quantity"]), row["transactionDate"].ToString(), row["description"].ToString(), objSystem.CategoryExists(Convert.ToInt32(row["idCategory"])), row["type"].ToString());
                }
            }
        }
        #endregion Load data
    }
}
