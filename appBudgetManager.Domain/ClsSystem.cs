using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using AppBudgetManager.Access;


namespace AppBudGetManager.Domain.System
{
    public class ClsSystem
    {
        public ClsBudGet fldMyBudGet;
        public List<ClsCategory> fldMyCategory = new List<ClsCategory>();
        private ClsTransactionService objTransactionService;

        public bool CreateBudGet()
        {
            try
            {
                if (fldMyBudGet == null)
                {
                    fldMyBudGet = new ClsBudGet();                
                    objTransactionService = new ClsTransactionService();
                    RepoTransaction();
                    Debug.WriteLine("Correcto");
                    return true;
                }
                else
                {
                    throw new Exception("BudGet already exists");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }

        }

        /// Delete all system information reSet to default
        public bool DeleteBudGet()
        {
            try
            {
                if (fldMyBudGet != null)
                {
                    fldMyBudGet = null;
                    return true;
                }
                else
                {
                    throw new Exception("BudGet not exists");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }            
        }

        public bool CreateCategory(int prmIdCategory, string prmName, string prmDescription)
        {
            try {
                fldMyCategory.Add(new ClsCategory(prmIdCategory, prmName, prmDescription));
                return true;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }

        }

        /// <summary>
        /// add a new category to the list  of categories 
        /// </summary>
        /// <param name="prmIdCategory"></param>
        /// <param name="prmName"></param>
        /// <param name="prmDescription"></param>
        /// <returns></returns>

        public bool UpdateCategory(int prmIdCategory, string prmName, string prmDescription)
        {
            return CategoryExists(prmIdCategory).Modify(prmName, prmDescription);
        }


        public bool DeleteCategory(int prmIdCategory)
        {
            ClsCategory objCategory = CategoryExists(prmIdCategory);
            if (objCategory.Die())
            {
                fldMyCategory.Remove(objCategory);
                return true;
            }
            return false;
        }

        /// <param name="prmType">Transaction Type</param>
        public bool CreateTransaction(int prmIdTransaction, double prmQuantity, string prmDate, string prmDescription, ClsCategory prmMyCategory, string prmType)
        {          
            if (objTransactionService.InsertTransaction(prmQuantity, prmDescription, prmDate, prmMyCategory.GetIdCategory(), prmType))
            {
                return fldMyBudGet.CreateTransaction(prmIdTransaction, prmQuantity, prmDate, prmDescription, prmMyCategory, prmType);
            }                  
           return false;
        }

        public bool UpdateTransaction(int prmIdTransaction, double prmQuantity, string prmDate, string prmDescription, ClsCategory prmMyCategory, string prmType)
        {
            return fldMyBudGet.UpdateTransaction(prmIdTransaction, prmQuantity, prmDate, prmDescription, prmMyCategory, prmType);
        }

        public bool DeleteTransaction(int prmIdTransaction, string prmType)
        {
            return fldMyBudGet.DeleteTransaction( prmIdTransaction, prmType);
        }

        ///verify that the category exists
        public ClsCategory CategoryExists(int prmIdCategory)
        {
            foreach (ClsCategory objCategory in fldMyCategory)
            {
                if (objCategory.GetIdCategory() == prmIdCategory)
                {
                    return objCategory;
                }
            }
            throw new Exception("Category not found");
        }

        public bool CategoryExistsBool(int prmIdCategory)
        {
            foreach (ClsCategory objCategory in fldMyCategory)
            {
                if (objCategory.GetIdCategory() == prmIdCategory)
                {
                    return true;
                }
            }
            return false;

        }

        public ClsBudGet GetClsBudGet()
        {
            return fldMyBudGet;
        }
        public List<ClsCategory> GetListCategories()
        {
            return fldMyCategory;
        }

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
                   CreateCategory(Convert.ToInt32(row["idCategory"]), row["name"].ToString(), row["description"].ToString());
                }
            }

            foreach (DataTable table in dtTransaction.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    fldMyBudGet.CreateTransaction(Convert.ToInt32(row["idTransaction"]), Convert.ToDouble(row["quantity"]), row["transactionDate"].ToString(), row["description"].ToString(), CategoryExists(Convert.ToInt32(row["idCategory"])), row["type"].ToString());                               
                }
            }
        }
    }
}
