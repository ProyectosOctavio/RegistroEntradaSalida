using System;
using System.Data;
using System.Text;
using Gtk;


namespace COntrolREyS.Datos
{
    public class DT_tbl_AsistenciaC
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
            ListStore asistencia_datos = new ListStore(typeof(int), typeof(String), typeof(String),  typeof(String), typeof(String), typeof(float), typeof(int));

            Sb.Clear();
            Sb.Append("Use QUICKIEBD;");
            Sb.Append("SELECT Asistencia.idAsistencia, Empleado.nombre, Asistencia.fecha, Asistencia.horaEntrada, Asistencia.horaSalida, Asistencia.totalHoras, " +
            "Asistencia.idEmpleado From Empleado INNER JOIN Asistencia ON Empleado.idEmpleado = Asistencia.idEmpleado;");
            try
            {
                Con.AbrirConexion();
                Idr = Con.Leer(CommandType.Text, Sb.ToString());
                while (Idr.Read())
                {
                    asistencia_datos.AppendValues( Idr[0], Idr[1], Idr[2].ToString()
                    , Idr[3].ToString(), Idr[4].ToString(), Idr[5], Idr[6]);
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
    }
}