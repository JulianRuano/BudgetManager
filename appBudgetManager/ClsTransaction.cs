using System;


namespace appBudgetManager
{
    public class ClsTransaction
    {
        private int fldOIdTransaction = 0;
        private Double fldQuantity = 0.0;
        private DateTime fldDate = default;
        private string fldDescription = " ";
        public ClsCategory fldMyCategory;

        public ClsTransaction(int prmIdTransaction, double prmQuantity, DateTime prmDate, string prmDescription)
        {
            throw new NotImplementedException();
        }

        public int getIdTransaction()
        {
            return fldOIdTransaction;
        }

        public Double getQuantity()
        {
            return fldQuantity;
        }

        public DateTime getDate()
        {
            return fldDate;
        }

        public ClsCategory getCategory()
        {
            return fldMyCategory;
        }

        public string getDescription()
        {
            return fldDescription;
        }

        public bool setQuantity(double prmValue)
        {
            throw new NotImplementedException();
        }

        public bool setDate(DateTime prmValue)
        {
            throw new NotImplementedException();
        }

        public bool setCategory(ClsCategory prmValue)
        {
            throw new NotImplementedException();
        }

        public bool setDescription(string prmValues)
        {
            throw new NotImplementedException();
        }

        public bool Modify(Double prmQuantity, DateTime prmDate, string prmDescription, ClsCategory prmCategory)
        {
            if (setQuantity(prmQuantity) && setDate(prmDate) && setDescription(prmDescription))
                return setCategory(prmCategory);
            return false;
        }

        public bool Die()
        {
            throw new NotImplementedException();
        }

    }
}