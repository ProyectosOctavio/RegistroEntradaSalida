using System;
using System.Data;
using System.Text;
using COntrolREyS.Properties;
using Gtk;


namespace COntrolREyS.Datos
{
    public class DT_tbl_Empleado
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

        public ListStore listaEmpleado()
        {
            ListStore empleado_datos = new ListStore(typeof(int), typeof(string), 
                typeof(string), typeof(string), typeof(string), typeof(string),
                typeof(int), typeof(string), typeof(string), typeof(int));

            Sb.Clear();
            Sb.Append("Use QUICKIEBD;");
            Sb.Append("SELECT Empleado.idEmpleado, Empleado.nombre, Empleado.apellido, Cargo.nombreCargo, " +
            	"Empleado.telefono, Empleado.email, Empleado.estadoEmpleado, Empleado.direccion, Empleado.cedula, " + 
            "Empleado.idCargo From Cargo INNER JOIN Empleado ON Cargo.idCargo = Empleado.idCargo;");
            try
            {
                Con.AbrirConexion();
                Idr = Con.Leer(CommandType.Text, Sb.ToString());
                while (Idr.Read())
                {
                    empleado_datos.AppendValues(Idr[0], Idr[1], Idr[2], Idr[3], Idr[4], Idr[5], Idr[6], Idr[7], Idr[8], Idr[9]);
                }
                Console.WriteLine(empleado_datos);
                return empleado_datos;
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
            return empleado_datos;
        }

        public tbl_empleado listById(int idempleado)
        {
            tbl_empleado tu = new tbl_empleado();
            sb.Clear();
            sb.Append("Use QUICKIEBD;");
            sb.Append("SELECT * FROM Empleado where idEmpleado = " + idempleado);
            try
            {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                if (idr.Read())
                {
                    tu.id_empleado = Convert.ToInt32(idr["idEmpleado"]);
                    tu.Nombre = idr["nombre"].ToString();
                    tu.Apellido = idr["apellido"].ToString();
                    tu.Telefono = idr["telefono"].ToString();
                    tu.Email = idr["email"].ToString();
                    tu.EstadoEmpleado = Convert.ToInt32(idr["estadoEmpleado"]);
                    tu.Direccion = idr["direccion"].ToString();
                    tu.id_cargo = Convert.ToInt32(idr["idCargo"]);
                    tu.Cedula = idr["Cedula"].ToString();

                }
                return tu;

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

        //METODO PARA ELIMINAR
        public Int32 eliminarEmpleado(tbl_empleado empleado)
        {
            int eliminado;
            sb.Clear();
            sb.Append("DELETE FROM QUICKIEBD.Empleado WHERE idEmpleado = "
            + empleado.id_empleado);

            try
            {
                con.AbrirConexion();
                eliminado = con.Ejecutar(CommandType.Text, sb.ToString());
                return eliminado;
            }
            catch (Exception e)
            {
                ms = new MessageDialog(null, DialogFlags.Modal,
                MessageType.Error, ButtonsType.Ok, e.Message);
                ms.Run();
                ms.Destroy();
                throw;
            }
            finally
            {
                con.CerrarConexion();
            }
        }

        public bool guardarEmpleado(tbl_empleado empleado)
        {
            bool guardado = false;
            int x = 0;
            sb.Clear();
            sb.Append("INSERT INTO QUICKIEBD.Empleado");
            sb.Append("(nombre, apellido, telefono, email, estadoEmpleado, direccion, Cedula, idCargo)");
            sb.Append("VALUES('" + empleado.Nombre + "', '" + empleado.Apellido + "', '" + empleado.Telefono
            + "', '" + empleado.Email + "', '" + empleado.EstadoEmpleado + "', '" + empleado.Direccion + "', '" + empleado.Cedula + "', '" + empleado.id_cargo + "');");

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


        public bool EditarEmpleado(tbl_empleado u)
        {


            bool editado = false;
            int x = 0;
            sb.Clear();
            sb.Append("Update QUICKIEBD.Empleado");
            sb.Append(" set nombre= '" + u.Nombre + "',");
            sb.Append(" apellido= '" + u.Apellido + "',");
            sb.Append(" telefono= '" + u.Telefono + "',");
            sb.Append(" email= '" + u.Email + "',");
            sb.Append(" estadoEmpleado= '" + u.EstadoEmpleado + "',");
            sb.Append(" direccion= '" + u.Direccion + "',");
            sb.Append(" Cedula= '" + u.Cedula + "',");
            sb.Append("  idCargo= '" + u.IdCargo + "'");
            sb.Append(" WHERE idEmpleado = " + u.id_empleado);

            Console.WriteLine(sb.ToString());
            try
            {
                con.AbrirConexion();
                x = con.Ejecutar(CommandType.Text, sb.ToString());
                if (x > 0)
                {
                    editado = true;
                }
                return editado;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.CerrarConexion();
            }

        }

        public ListStore buscarEmpleado(string cadena)
        {

            ListStore datos = new ListStore(typeof(int), typeof(string),
           typeof(string), typeof(string), typeof(string), typeof(string),
           typeof(int), typeof(string), typeof(string), typeof(int));

            sb.Clear();
            sb.Append("Use QUICKIEBD;");
            Sb.Append("SELECT Empleado.idEmpleado, Empleado.nombre, Empleado.apellido, Cargo.nombreCargo, " +
                "Empleado.telefono, Empleado.email, Empleado.estadoEmpleado, Empleado.direccion, Empleado.cedula, " +
            "Empleado.idCargo From Cargo INNER JOIN Empleado ON Cargo.idCargo = Empleado.idCargo WHERE Empleado.nombre like '%" + cadena + "%'");
            try
            {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    datos.AppendValues(Idr[0], Idr[1], Idr[2], Idr[3], Idr[4], Idr[5], Idr[6], Idr[7], Idr[8], Idr[9]);

                }
                return datos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                idr.Close();
                con.CerrarConexion();
            }

        }
    }
}