using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using AppBudgetManager.Access;


namespace AppBudGetManager.Domain.System
{
    public class ClsSystem
    {
        private ClsBudGet fldMyBudGet;
        private List<ClsCategory> fldMyCategory;
        private static ClsSystem objSystem;

        /// <summary>
        /// Singleton constructor 
        /// </summary>
        private ClsSystem()
        {
            fldMyCategory = new List<ClsCategory>();
            CreateBudGet();
        }
        /// <summary>
        /// Instance of the singleton
        /// </summary>
        public static ClsSystem GetInstance()
        {
            if (objSystem == null)
            {
                objSystem = new ClsSystem();
                return objSystem;
            }
            else
            {
                return objSystem;
            }
        }


        #region BudGet
        /// <summary>
        /// Create a new budGet 
        /// </summary>
        public bool CreateBudGet()
        {
            try
            {
                if (fldMyBudGet == null)
                {
                    fldMyBudGet = new ClsBudGet();                
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
        /// <summary>
        /// Delete all system information reSet to default
        /// </summary>
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

        #endregion BudGet

        #region Category

        /// <summary>
        ///  Create a new category and add to the list of categories
        /// </summary>
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
        ///  Update a category verify that the category exists first
        /// </summary>
        public bool UpdateCategory(int prmIdCategory, string prmName, string prmDescription)
        {
            return CategoryExists(prmIdCategory).Modify(prmName, prmDescription);
        }

        /// <summary>
        /// Delete a category verify that the category exists first
        /// </summary>
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

        #endregion Category

        #region Transaction

        /// <summary>
        /// Create a new transaction and add to the list of transactions
        /// </summary>
        public bool CreateTransaction(int prmIdTransaction, double prmQuantity, string prmDate, string prmDescription, ClsCategory prmMyCategory, string prmType)
        {          
            return fldMyBudGet.CreateTransaction(prmIdTransaction, prmQuantity, prmDate, prmDescription, prmMyCategory, prmType);
        }

        /// <summary>
        /// Update a transaction call the method in the budGet
        /// </summary>
        public bool UpdateTransaction(int prmIdTransaction, double prmQuantity, string prmDate, string prmDescription, ClsCategory prmMyCategory, string prmType)
        {
            return fldMyBudGet.UpdateTransaction(prmIdTransaction, prmQuantity, prmDate, prmDescription, prmMyCategory, prmType);
        }

        /// <summary>
        /// Delete a transaction call the method in the budGet
        /// </summary>
        public bool DeleteTransaction(int prmIdTransaction, string prmType)
        {
            return fldMyBudGet.DeleteTransaction( prmIdTransaction, prmType);
        }

        /// <summary>
        /// Check that the category exists and returns the category
        /// </summary>
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

        #endregion Transaction

        /// <summary>
        /// Check that the category exists and returns true or false
        /// </summary>
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
        /// <summary>
        /// Get the budGet
        /// </summary>
        public ClsBudGet GetClsBudGet()
        {
            return fldMyBudGet;
        }

        /// <summary>
        /// Get the list of categories
        /// </summary>
        public List<ClsCategory> GetListCategories()
        {
            return fldMyCategory;
        }

       
    }
}
