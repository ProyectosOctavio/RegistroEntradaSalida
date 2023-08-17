using System;
using System.Data;
using System.Text;
using COntrolREyS.Properties;
using Gtk;


namespace COntrolREyS.Datos
{
    public class DT_tbl_Asistencia
    {
        #region atributos
        Conexion con = new Conexion();
        IDataReader idr = null;
        StringBuilder sb = new StringBuilder();
        MessageDialog ms = null;

        public Conexion Con { get => con; set => con = value; }
        public IDataReader Idr { get => idr; set => idr = value; }
        public StringBuilder Sb { get => sb; set => sb = value; }
        public MessageDialog Ms { get => ms; set => ms = value; }
        #endregion

        public ListStore listaAsistencia()
        { 
        ListStore asistencia_datos = new ListStore(typeof(int), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

            Sb.Clear();
            Sb.Append("Use QUICKIEBD;");
            sb.Append("SELECT Asistencia.idAsistencia, Asistencia.horasMarcadas, Asistencia.tipoDeMarca, Empleado.nombre, Empleado.apellido, " +
                "Asistencia.Cedula From Empleado INNER JOIN Asistencia ON Empleado.Cedula = Asistencia.Cedula ORDER BY idAsistencia DESC;");


            try
            {
                Con.AbrirConexion();
                Idr = Con.Leer(CommandType.Text, Sb.ToString());
                while (Idr.Read())
                {
                    asistencia_datos.AppendValues(Idr[0], Idr[2].ToString(), Idr[1].ToString(), Idr[3].ToString(), Idr[4].ToString(), 
                    Idr[5].ToString());
                }
                Console.WriteLine(asistencia_datos);
                return asistencia_datos;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error lista: " + e.Message);
            }
            finally
            {
                Idr.Close();
                Con.CerrarConexion();
            }
            return asistencia_datos;
        }


        public bool registrarAsistencia(tbl_Asistencia tbu)
        {
            bool guardado = false;
            int x = 0;
            sb.Clear();

            sb.Append("INSERT INTO QUICKIEBD.Asistencia");
            sb.Append("(tipoDeMarca, horasMarcadas, Cedula)");
            sb.Append("VALUES('" + tbu.TipoDeMarca + "','" + tbu.HorasMarcadas + "','"  +  tbu.Cedula + "');");

            try
            {
                con.AbrirConexion();
                x = con.Ejecutar(CommandType.Text, sb.ToString());
                if (x > 0)
                {
                    guardado = true;
                }
                return guardado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
        }

        public tbl_Asistencia listById(int idAsistencia)
        {
            tbl_Asistencia tbu = new tbl_Asistencia();
            sb.Clear();
            sb.Append("Use QUICKIEBD;");
            sb.Append("SELECT * FROM Asistencia where idAsistencia = " + idAsistencia);
            try
            {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                if (idr.Read())
                {
                    tbu.id_registro = Convert.ToInt32(idr["idAsistencia"]);
                    tbu.HorasMarcadas = Convert.ToString(idr["horasMarcadas"]);
                    tbu.Cedula = idr["Cedula"].ToString();
                }
                return tbu;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                idr.Close();
                con.CerrarConexion();
            }
        }
       
    }
}