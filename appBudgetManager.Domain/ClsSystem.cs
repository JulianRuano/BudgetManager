using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace AppBudGetManager.Domain
{
    internal class ClsSystem
    {
        public ClsBudGet fldMyBudGet = null;
        public List<ClsCategory> fldMyCategory = new List<ClsCategory>();

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
        public bool CreateTransaction(int prmIdTransaction, double prmQuantity, DateTime prmDate, string prmDescription, ClsCategory prmMyCategory, string prmType)
        {
            return fldMyBudGet.CreateTransaction(prmIdTransaction, prmQuantity, prmDate, prmDescription, prmMyCategory, prmType);
        }

        public bool UpdateTransaction(int prmIdTransaction, double prmQuantity, DateTime prmDate, string prmDescription, ClsCategory prmMyCategory, string prmType)
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
            string strMessage = "Category not found";
            foreach (ClsCategory objCategory in fldMyCategory)
            {
                if (objCategory.GetIdCategory() == prmIdCategory)
                {
                    return objCategory;
                }
            }
            throw new Exception(strMessage);
        }

        public ClsBudGet GetClsBudGet()
        {
            return fldMyBudGet;
        }
        public List<ClsCategory> GetListCategories()
        {
            return fldMyCategory;
        }


    }
}
