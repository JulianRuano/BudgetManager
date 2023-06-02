using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace appBudgetManager
{
    internal class ClsBudget
    {

        private double fldBalance = 0.0;
        private double fldTotalIncomes = 0.0;
        private double fldTotalExpenses = 0.0;
        public List<ClsTransaction> fldMyIncomes;
        public List<ClsTransaction> flbMyExpenses;

        protected bool setBalance(double prmValue)
        {
            throw new NotImplementedException();
        }

        protected bool setTotalIncomes(double prmValue)
        {
            throw new NotImplementedException();
        }

        protected bool setTotalExpenses(double prmValue)
        {
            throw new NotImplementedException();
        }

        public Double getBalance()
        {
            return fldBalance;
        }

        public double getTotalExpenses()
        {
            return fldTotalExpenses;
        }

        public double getTotalIncomes()
        {
            return fldTotalIncomes;
        }

        public bool CreateTransaction(int prmIdTransaction, double prmQuantity, DateTime prmDate, string prmDescription, ClsCategory prmMyCategory, string prmType)
        {
            ClsTransaction objTransaction = new ClsTransaction(prmIdTransaction, prmQuantity, prmDate, prmDescription);
            objTransaction.setCategory(prmMyCategory);

            if (prmType == "Incomes")
            {
                fldMyIncomes.Add(objTransaction);
                   return true;
            }
            else if (prmType == "Expenses")
            {
                flbMyExpenses.Add(objTransaction);
                   return true;
            }
            return false;
        }

        public bool UpdateTransaction(int prmIdTransaction, double prmQuantity, DateTime prmDate, string prmDescription, ClsCategory prmMyCategory, string prmType)
        {
            return TransactionExists(prmIdTransaction, prmType).Modify(prmQuantity, prmDate, prmDescription, prmMyCategory);
        }

        public bool DeleteTransaction(int prmIdTransaction, string prmType)
        {
            ClsTransaction objTransaction = TransactionExists(prmIdTransaction, prmType);
            if (objTransaction.Die())
            {
                if (prmType == "Incomes")
                {
                    fldMyIncomes.Remove(objTransaction);
                    objTransaction = null;
                    return true;
                }
                else if (prmType == "Expenses")
                {
                    flbMyExpenses.Remove(objTransaction);
                    objTransaction = null;
                    return true;
                }
            }
            return false;
        }

        public double GenerateBalance()
        {
            throw new NotImplementedException();
        }

        public string GenerateReport(DateTime prmStartDate, DateTime prmEndingDate)
        {
            throw new NotImplementedException();
        }


        public ClsTransaction TransactionExists(int prmIdTransaction, string prmType)
        {
            throw new NotImplementedException();
        }

       

        /// <summary>
        /// Property for collection of ClsTransaction
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
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
        /// <pdGenerated>Default Add</pdGenerated>
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
        /// <pdGenerated>Default Remove</pdGenerated>
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
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllMyIncomes()
        {
            if (fldMyIncomes != null)
                fldMyIncomes.Clear();
        }
       

        /// <summary>
        /// Property for collection of ClsTransaction
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
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
        /// <pdGenerated>Default Add</pdGenerated>
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
        /// <pdGenerated>Default Remove</pdGenerated>
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
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllMyExpenses()
        {
            if (flbMyExpenses != null)
                flbMyExpenses.Clear();
        }
    }
}
