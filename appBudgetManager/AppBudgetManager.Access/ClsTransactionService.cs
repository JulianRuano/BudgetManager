﻿using System;
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

        public bool InsertCategory(string prmName, string prmDescription)
        {
            string consulta;
            consulta = "INSERT INTO category (idCategory, name, description)" +
                       " VALUES(category_seq.NEXTVAL ,'" + prmName + "','" + prmDescription + "')";
            if (dt.ejecutarDML(consulta) >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteTransaction(int prmIdTransaction)
        {
            string consulta;
            consulta = "DELETE FROM transaction WHERE idTransaction = " + prmIdTransaction;
            if (dt.ejecutarDML(consulta) >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteCategory(int prmIdCategory)
        {
            string consulta;
            consulta = "DELETE FROM category WHERE idCategory = " + prmIdCategory;
            if (dt.ejecutarDML(consulta) >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateTransaction(int prmIdTransaction, double prmQuantity, string prmDate, string prmDescription, int prmMyCategory, string prmType)
        {
            string consulta;
            consulta = "UPDATE transaction SET quantity = " + prmQuantity + ", description = '" + prmDescription + "', transactionDate = TO_DATE('" + prmDate + "', 'DD-MM-YYYY'), idCategory = " + prmMyCategory + ", type = '" + prmType + "' WHERE idTransaction = " + prmIdTransaction;
            if (dt.ejecutarDML(consulta) >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateCategory(int prmIdCategory, string prmName, string prmDescription)
        {
            string consulta;
            consulta = "UPDATE category SET name = '" + prmName + "', description = '" + prmDescription + "' WHERE idCategory = " + prmIdCategory;
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


        public int ConsultIdTransaction()
        {
            string consulta;
            consulta = "SELECT MAX(idcategory) AS max_id FROM transaction";
            return dt.ejecutarSELECTID(consulta);
        }

        public int ConsultIdCategory()
        {
            string consulta;
            consulta = "SELECT MAX(idcategory) AS max_id FROM category";
            return dt.ejecutarSELECTID(consulta);
        }

        public DataSet ConsultTransactionReport(string startDate, string endDate)
        {
            string consulta;
            consulta = "SELECT  CASE WHEN t.type = 'Incomes' THEN 'Ingresos' ELSE 'Gastos' END AS Tipo, " +
                    " COUNT(*) AS TotalTransacciones,   SUM(t.quantity) AS SumaCantidad" +
                    " FROM  " +
                    " transaction t " +
                    " WHERE   t.transactionDate >= TO_DATE('"+startDate+ "', 'dd-mm-yyyy') AND t.transactionDate <= TO_DATE('"+endDate+ "', 'dd-mm-yyyy') " +
                    " GROUP BY  t.type;";
            return dt.ejecutarSELECT(consulta);
        }


    }
}
