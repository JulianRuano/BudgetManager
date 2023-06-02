using System;

namespace appBudgetManager
{
    public class ClsCategory
    {
        private int fldOIdCategory = 0;
        private string fldName = " ";
        private string fldDescription = " ";
        public ClsTransaction[] myTransactions;

        public ClsCategory(int prmIdCategory, string prmName, string prmDescription)
        {
            throw new NotImplementedException();
        }

        public int getIdCategory()
        {
            return fldOIdCategory;
        }

        public string getName()
        {
            return fldName;
        }

        public String getDescription()
        {
            return fldDescription;
        }

        public bool setName(string prmValue)
        {
            throw new NotImplementedException();
        }

        public bool setDescription(string prmDescription)
        {
            throw new NotImplementedException();
        }

        public bool Modify(string prmName, string prmDescription)
        {
            if (setName(prmName))
                return setDescription(prmDescription);
            return false;
        }

        public bool Die(int prmIdCategory)
        {
            throw new NotImplementedException();
        }

       
    }
}
