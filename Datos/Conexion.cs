using System;
using System.Data;
using Gtk;
using MySql.Data.MySqlClient;

namespace COntrolREyS.Datos
{

    public class Conexion
    {

        #region atributos
        private string cadena = String.Empty;
        private MySqlConnection con { get; set; }
        private MySqlCommand sqlcomand { get; set; }
        private IDataReader idr { get; set; }
        #endregion

        #region metodos
        public string CadenaConexion()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "Yizi";
            sb.Database = "QUICKIEBD";
            sb.Password = "pa";
            return sb.ConnectionString;
        }//fin del metodo

        public void AbrirConexion()
        {
            MessageDialog ms = null;
            if (con.State == ConnectionState.Open)
            {
                return;
            }
            else
            {
                con.ConnectionString = cadena;
                try
                {
                    con.Open();

                    Console.WriteLine("Se conectó a la BD");
                }
                catch (Exception e)
                {
                    ms = new MessageDialog(null, DialogFlags.Modal,
                        MessageType.Error, ButtonsType.Ok, e.Message);
                    ms.Run();
                    ms.Destroy();
                    Console.WriteLine("ERROR: " + e);
                }//fin try-catch
            }//fin if-else
        }//fin del metodo

        public void CerrarConexion()
        {
            if (con.State == ConnectionState.Closed)
            {
                return;
            }
            else
            {
                con.Close();
            }
        }//fin del metodo

        public IDataReader Leer(CommandType ct, string consulta)
        {
            idr = null;
            sqlcomand.Connection = con;
            sqlcomand.CommandType = ct;
            sqlcomand.CommandText = consulta;

            try
            {
                idr = sqlcomand.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error LEER: " + e.Message);
            }

            return idr;
        }

        public Int32 Ejecutar(CommandType ct, string consulta)
        {
            int retorno = 0;
            sqlcomand.Connection = con;
            sqlcomand.CommandType = ct;
            sqlcomand.CommandText = consulta;

            try
            {
                retorno = sqlcomand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return retorno;
        }

        #endregion

        #region constructor
        public Conexion()
        {
            cadena = CadenaConexion();
            con = new MySqlConnection();
            sqlcomand = new MySqlCommand();
        }
        #endregion


    }
}
