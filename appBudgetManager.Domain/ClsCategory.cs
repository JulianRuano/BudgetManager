using System;
using System.Diagnostics;

namespace AppBudGetManager.Domain
{
    public class ClsCategory: IComparable<ClsCategory>
    {
        private int fldOIdCategory = 0;
        private string fldName = " ";
        private string fldDescription = " ";
        public ClsTransaction[] myTransactions;

        public ClsCategory(int prmIdCategory, string prmName, string prmDescription)
        {
            fldOIdCategory = prmIdCategory;
            fldName = prmName;
            fldDescription = prmDescription;
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

        public bool Modify(string prmName, string prmDescription)
        {
            if (SetName(prmName))
                return SetDescription(prmDescription);
            return false;
        }

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
