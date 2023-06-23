using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;


namespace AppBudGetManager.Domain
{
    public class ClsBudGet
    {

        private double fldBalance;
        private double fldTotalIncomes;
        private double fldTotalExpenses;
        private List<ClsTransaction> fldMyIncomes;
        private List<ClsTransaction> flbMyExpenses;
        private DataSet fldReport;

        public ClsBudGet()
        {
            fldBalance = 0.0;
            fldTotalIncomes = 0.0;
            fldTotalExpenses = 0.0;
            fldMyIncomes = new List<ClsTransaction>();
            flbMyExpenses = new List<ClsTransaction>();
            fldReport = new DataSet();
        }

        protected bool SetBalance(double prmValue)
        {
            try { 
                fldBalance = prmValue; 
                return true; 
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
                return false; 
            }           
        }

        protected bool SetTotalIncomes(double prmValue)
        {
            try {                 
                fldTotalIncomes = prmValue;
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        protected bool SetTotalExpenses(double prmValue)
        {
            try
            {
                fldTotalExpenses = prmValue;
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public double GetBalance()
        {
            fldBalance = fldTotalIncomes - fldTotalExpenses;
            return fldBalance;
        }

        public double GetTotalExpenses()
        {
            return fldTotalExpenses;
        }

        public double GetTotalIncomes()
        {
            return fldTotalIncomes;
        }

        public bool CreateTransaction(int prmIdTransaction, double prmQuantity, string prmDate, string prmDescription, ClsCategory prmMyCategory, string prmType)
        {
            ClsTransaction objTransaction = new ClsTransaction(prmIdTransaction, prmQuantity, prmDate, prmDescription);
            objTransaction.SetCategory(prmMyCategory);
            prmMyCategory.AddTransactions(objTransaction);

            if (prmType == "Incomes")
            {
                fldMyIncomes.Add(objTransaction);
                fldTotalIncomes += prmQuantity;
                return true;
            }
            else if (prmType == "Expenses")
            {
                flbMyExpenses.Add(objTransaction);
                fldTotalExpenses += prmQuantity;
                return true;
            }
            return false;
        }

        public bool UpdateTransaction(int prmIdTransaction, double prmQuantity, string prmDate, string prmDescription, ClsCategory prmMyCategory, string prmType)
        {
            return TransactionExists(prmIdTransaction, prmType).Modify(prmQuantity, prmDate, prmDescription, prmMyCategory);
        }

        public bool DeleteTransaction(int prmIdTransaction, string prmType)
        {
            ClsTransaction objTransaction = TransactionExists(prmIdTransaction, prmType);
            objTransaction.GetCategory().RemoveTransaction(objTransaction.GetIdTransaction());

            if (objTransaction.Die())
            {
                if (prmType == "Incomes")
                {
                    fldMyIncomes.Remove(objTransaction);
                    return true;
                }
                else if (prmType == "Expenses")
                {
                    flbMyExpenses.Remove(objTransaction);
                    return true;
                }
            }
            return false;
        }


        public DataSet GetReport()
        {
            return fldReport;
        }

        public bool SetReport(DataSet prmReport)
        {
            fldReport = prmReport;
            return true;
        }


        public ClsTransaction TransactionExists(int prmIdTransaction, string prmType)
        {
            if (prmType == "Incomes")
            {
                for (int i = 0; i < fldMyIncomes.Count; i++)
                {
                    if (fldMyIncomes[i].GetIdTransaction() == prmIdTransaction)
                    {
                        return fldMyIncomes[i];
                    }
                }
            }
            else if (prmType == "Expenses")
            {
                for (int i = 0; i < flbMyExpenses.Count; i++)
                {
                    if (flbMyExpenses[i].GetIdTransaction() == prmIdTransaction)
                    {
                        return flbMyExpenses[i];
                    }
                }
            }
            return null;
        }

        public bool TransactionExistsBool(int prmIdTransaction, string prmType)
        {
            if (prmType == "Incomes")
            {
                for (int i = 0; i < fldMyIncomes.Count; i++)
                {
                    if (fldMyIncomes[i].GetIdTransaction() == prmIdTransaction)
                    {
                        return true;
                    }
                }
            }
            else if (prmType == "Expenses")
            {
                for (int i = 0; i < flbMyExpenses.Count; i++)
                {
                    if (flbMyExpenses[i].GetIdTransaction() == prmIdTransaction)
                    {
                        return true;
                    }
                }
            }
            return false;
        }



        /// <summary>
        /// Property for collection of ClsTransaction
        /// </summary>     
        public List<ClsTransaction> MyIncomes
        {
            get
            {
                if (fldMyIncomes == null)
                    fldMyIncomes = new List<ClsTransaction>();
                return fldMyIncomes;
            }
            set
            {
                RemoveAllMyIncomes();
                if (value != null)
                {
                    foreach (ClsTransaction oClsTransaction in value)
                        AddMyIncomes(oClsTransaction);
                }
            }
        }

        /// <summary>
        /// Add a new ClsTransaction in the collection
        /// </summary>
        public void AddMyIncomes(ClsTransaction newClsTransaction)
        {
            if (newClsTransaction == null)
                return;
            if (this.fldMyIncomes == null)
                this.fldMyIncomes = new List<ClsTransaction>();
            if (!this.fldMyIncomes.Contains(newClsTransaction))
                this.fldMyIncomes.Add(newClsTransaction);
        }

        /// <summary>
        /// Remove an existing ClsTransaction from the collection
        /// </summary>
        public void RemoveMyIncomes(ClsTransaction oldClsTransaction)
        {
            if (oldClsTransaction == null)
                return;
            if (this.fldMyIncomes != null)
                if (this.fldMyIncomes.Contains(oldClsTransaction))
                    this.fldMyIncomes.Remove(oldClsTransaction);
        }

        /// <summary>
        /// Remove all instances of ClsTransaction from the collection
        /// </summary>
        public void RemoveAllMyIncomes()
        {
            fldMyIncomes?.Clear();
        }
       

        /// <summary>
        /// Property for collection of ClsTransaction
        /// </summary>
        public List<ClsTransaction> MyExpenses
        {
            get
            {
                if (flbMyExpenses == null)
                    flbMyExpenses = new List<ClsTransaction>();
                return flbMyExpenses;
            }
            set
            {
                RemoveAllMyExpenses();
                if (value != null)
                {
                    foreach (ClsTransaction oClsTransaction in value)
                        AddMyExpenses(oClsTransaction);
                }
            }
        }

        /// <summary>
        /// Add a new ClsTransaction in the collection
        /// </summary>
        public void AddMyExpenses(ClsTransaction newClsTransaction)
        {
            if (newClsTransaction == null)
                return;
            if (this.flbMyExpenses == null)
                this.flbMyExpenses = new List<ClsTransaction>();
            if (!this.flbMyExpenses.Contains(newClsTransaction))
                this.flbMyExpenses.Add(newClsTransaction);
        }

        /// <summary>
        /// Remove an existing ClsTransaction from the collection
        /// </summary>
        public void RemoveMyExpenses(ClsTransaction oldClsTransaction)
        {
            if (oldClsTransaction == null)
                return;
            if (this.flbMyExpenses != null)
                if (this.flbMyExpenses.Contains(oldClsTransaction))
                    this.flbMyExpenses.Remove(oldClsTransaction);
        }

        /// <summary>
        /// Remove all instances of ClsTransaction from the collection
        /// </summary>
        public void RemoveAllMyExpenses()
        {
            flbMyExpenses?.Clear();
        }
    }
}
