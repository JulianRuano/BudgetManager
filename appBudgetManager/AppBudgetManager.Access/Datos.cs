using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace AppBudgetManager.Access
{
    internal class Datos
    {
        string cadenaConexion = "USER ID=BudGet;DATA SOURCE=localhost;Password=oracle";
        public int ejecutarDML(string consulta)
        {
                int filasAfectadas = 0;
                OracleConnection miConexion = new OracleConnection(cadenaConexion);
                OracleCommand miComando = new OracleCommand(consulta, miConexion);
                miConexion.Open();
                filasAfectadas = miComando.ExecuteNonQuery();
                miConexion.Close();
                return filasAfectadas;           
        }
        public DataSet ejecutarSELECT(string consulta)
        {
            DataSet ds = new DataSet();
            OracleDataAdapter miAdaptador = new OracleDataAdapter(consulta, cadenaConexion);
            miAdaptador.Fill(ds, "ResultadoDatos");
            return ds;
        }

        //Retornar el id de la consulta
        public int ejecutarSELECTID(string consulta)
        {
            int id = 0;
            OracleConnection miConexion = new OracleConnection(cadenaConexion);
            OracleCommand miComando = new OracleCommand(consulta, miConexion);
            miConexion.Open();
            OracleDataReader reader = miComando.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            miConexion.Close();
            return id;
        }

    }
}
