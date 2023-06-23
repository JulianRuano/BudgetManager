using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AppBudGetManager.Domain
{
    public class ClsCategory: IComparable<ClsCategory>
    {
        private int fldOIdCategory = 0;
        private string fldName = " ";
        private string fldDescription = " ";
        public List<ClsTransaction>  myTransactions;

        public ClsCategory(int prmIdCategory, string prmName, string prmDescription)
        {
            fldOIdCategory = prmIdCategory;
            fldName = prmName;
            fldDescription = prmDescription;
            myTransactions = new List<ClsTransaction>();
        }

        public int GetIdCategory()
        {
            return fldOIdCategory;
        }

        public string GetName()
        {
            return fldName;
        }

        public string GetDescription()
        {
            return fldDescription;
        }

        public List<ClsTransaction> GetListTransactions()
        {
            return myTransactions;
        }

        public bool SetName(string prmValue)
        {
            try
            {
                fldName = prmValue;
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool SetDescription(string prmDescription)
        {
            try
            {
                fldDescription = prmDescription;
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        // add transaction to list
        public bool AddTransactions(ClsTransaction prmTransaction)
        {
            try
            {
                myTransactions.Add(prmTransaction);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }
        // remove transaction from list
        public bool RemoveTransaction(int prmIdTransactions)
        {
            try
            {
                for (int i = 0; i < myTransactions.Count; i++)
                {
                    if (myTransactions[i].GetIdTransaction() == prmIdTransactions)
                    {
                        myTransactions.RemoveAt(i);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
            
        }

        // modify all data from object
        public bool Modify(string prmName, string prmDescription)
        {
            if (SetName(prmName))
                return SetDescription(prmDescription);
            return false;
        }

        // delete all data from object
        public bool Die()
        {
            try { 
                fldOIdCategory = 0;
                fldName = " ";
                fldDescription = " ";
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }

        }
        // Test if two objects are equal
        public int CompareTo(ClsCategory other)
        {
            //cero si son iguales
            if ( this.fldOIdCategory == other.fldOIdCategory)
            {
                if (this.fldName == other.fldName)
                {
                    if(this.fldDescription == other.fldDescription)
                    {
                        return 0;
                    }

                }   
            }
            return -1;

        }
    }
}
