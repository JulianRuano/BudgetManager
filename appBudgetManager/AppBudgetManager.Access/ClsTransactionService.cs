using System;
using System.Collections.Generic;
using System.Data;

namespace AppBudgetManager.Access
{
    public class ClsTransactionService
    {
        Datos dt = new Datos();

        public bool InsertTransaction(double prmQuantity, string prmDescription, string prmDate, int prmIdCategory,string prmType)
        {
            string consulta;
            consulta = "INSERT INTO transaction (idTransaction, quantity, description, transactionDate, idCategory, type)" +
                       " VALUES(transaction_seq.NEXTVAL ," + prmQuantity + ",'" + prmDescription + "', TO_DATE('" + prmDate + "', 'DD-MM-YYYY'), "+ prmIdCategory + ",'" + prmType+ "')";
            if (dt.ejecutarDML(consulta) >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      
        public DataSet ConsultTransaction()
        {
            string consulta;
            consulta = "SELECT * FROM transaction";
            return dt.ejecutarSELECT(consulta);
        }
        public DataSet ConsultCategory()
        {
            string consulta;
            consulta = "SELECT * FROM category";
            return dt.ejecutarSELECT(consulta);
        }

    }
}
