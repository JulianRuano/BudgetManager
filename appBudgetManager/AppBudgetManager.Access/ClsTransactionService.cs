using System.Collections.Generic;
using System.Data;

namespace AppBudgetManager.Access
{
    public class ClsTransactionService
    {
        Datos dt = new Datos();

        public int InsertTransaction(double prmQuantity, string prmDescription, string prmDate, int prmIdCategory,string prmType)
        {
            string consulta;
            consulta = "INSERT INTO transaction (idTransaction, quantity, description, transactionDate, idCategory, type)" +
                       " VALUES(transaction_seq.NEXTVAL ," + prmQuantity + ",'" + prmDescription + "', TO_DATE('" + prmDate + "', 'DD-MM-YYYY'), "+ prmIdCategory + ",'" + prmType+ "')";
            return dt.ejecutarDML(consulta);
        }
      
        public DataSet ConsultTransaction()
        {
            string consulta;
            consulta = "SELECT * FROM transaction";
            return dt.ejecutarSELECT(consulta);
        }

    }
}
