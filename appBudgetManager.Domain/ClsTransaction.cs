using System;
using System.Diagnostics;


namespace AppBudGetManager.Domain
{
    public class ClsTransaction
    {
        private int fldOIdTransaction;
        private Double fldQuantity;
        private string fldDate;
        private string fldDescription;
        public ClsCategory fldMyCategory;

        public ClsTransaction(int prmIdTransaction, double prmQuantity, string prmDate, string prmDescription)
        {
            fldOIdTransaction = prmIdTransaction;
            fldQuantity = prmQuantity;
            fldDate = prmDate;
            fldDescription = prmDescription;
        }
        public ClsTransaction() { }

        public int GetIdTransaction()
        {
            return fldOIdTransaction;
        }

        public Double GetQuantity()
        {
            return fldQuantity;
        }

        public string GetDate()
        {
            return fldDate;
        }

        public ClsCategory GetCategory()
        {
            return fldMyCategory;
        }

        public string GetDescription()
        {
            return fldDescription;
        }

        public bool SetIdTransaction(int prmValue)
        {
            try
            {
                fldOIdTransaction = prmValue;
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool SetQuantity(double prmValue)
        {
            try 
            {
                fldQuantity = prmValue;
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool SetDate(string prmValue)
        {
            try 
            {                
                fldDate = prmValue;
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool SetCategory(ClsCategory prmValue)
        {
            try 
            {                 
                fldMyCategory = prmValue;
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool SetDescription(string prmValues)
        {
            try 
            { 
                fldDescription = prmValues;
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Modify(Double prmQuantity, string prmDate, string prmDescription, ClsCategory prmCategory)
        {
            if (SetQuantity(prmQuantity) && SetDate(prmDate) && SetDescription(prmDescription))
                return SetCategory(prmCategory);
            return false;
        }

        public bool Die()
        {
            try
            {
                fldOIdTransaction = 0;
                fldQuantity = 0.0;
                fldDate = default;
                fldDescription = " ";
                fldMyCategory = null;
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

    }
}