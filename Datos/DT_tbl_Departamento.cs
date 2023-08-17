using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using COntrolREyS.Properties;
using Gtk;


namespace COntrolREyS.Datos
{
    public class DT_tbl_Departamento
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

        public ListStore listaDepartamento()
        {
            ListStore departamento_datos = new ListStore(typeof(int), typeof(string), typeof(int));

            Sb.Clear();
            Sb.Append("Use QUICKIEBD;");
            Sb.Append("SELECT * FROM QUICKIEBD.Departamento;");
            try
            {
                Con.AbrirConexion();
                Idr = Con.Leer(CommandType.Text, Sb.ToString());
                while (Idr.Read())
                {
                    departamento_datos.AppendValues(Idr[0], Idr[1], Idr[2]);
                }
                Console.WriteLine(departamento_datos);
                return departamento_datos;
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
            return departamento_datos;
        }

        public bool guardarDepartamento(tbl_departamento departamento)
        {
            bool guardado = false;
            int x = 0;
            sb.Clear();
            sb.Append("INSERT INTO QUICKIEBD.Departamento");
            sb.Append("(nombreDepartamento, estadoDepartamento)");
            sb.Append("VALUES('" + departamento.NombreDepartamento + "', 1);");

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

        //METODO PARA ELIMINAR
        public Int32 eliminarDepartamento(tbl_departamento departamento)
        {
            int eliminado;
            sb.Clear();
            sb.Append("DELETE FROM QUICKIEBD.Departamento WHERE idDepartamento = "
            + departamento.Id_departamento);

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

        public bool EditarDepartamento(tbl_departamento u)
        {
            bool editado = false;
            int x = 0;
            sb.Clear();
            sb.Append("Update QUICKIEBD.Departamento");
            sb.Append(" set nombreDepartamento= '" + u.NombreDepartamento + "',");
            sb.Append(" estadoDepartamento= '" + u.EstadoDepartamento + "'");
            sb.Append(" WHERE idDepartamento = " + u.Id_departamento);

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


        public tbl_departamento listById(int iddepartamento)
        {
            tbl_departamento tu = new tbl_departamento();
            sb.Clear();
            sb.Append("Use QUICKIEBD;");
            sb.Append("SELECT * FROM Departamento where idDepartamento = " + iddepartamento);
            try
            {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                if (idr.Read())
                {
                    tu.Id_departamento = Convert.ToInt32(idr["idDepartamento"]);
                    tu.NombreDepartamento = idr["nombreDepartamento"].ToString();
                    tu.EstadoDepartamento= Convert.ToInt32(idr["estadoDepartamento"]);
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


        public ListStore buscarDepartamento(string cadena)
        {

                ListStore datos = new ListStore(typeof(int), typeof(string), typeof(int));

            sb.Clear();
            sb.Append("Use QUICKIEBD;");
            sb.Append("Select * from QUICKIEBD.Departamento ");
            sb.Append("WHERE Departamento.nombreDepartamento like '%" + cadena + "%'");
            try
            {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    datos.AppendValues(idr[0], idr[1], idr[2]);

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


        public List<tbl_departamento> llenarcbxDep()
        {
            List<tbl_departamento> listaDep = new List<tbl_departamento>();

            sb.Clear();
            sb.Append("Use QUICKIEBD;");
            sb.Append("select * from Departamento;");
            try
            {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    tbl_departamento tr = new tbl_departamento()
                    {
                        Id_departamento = Convert.ToInt32(idr["idDepartamento"]),
                        NombreDepartamento= idr["nombreDepartamento"].ToString(),
                       
                    };
                    listaDep.Add(tr);
                }
                return listaDep;
            }
            catch (Exception e)
            {
                throw new Exception(e.StackTrace);
            }
            finally
            {
                idr.Close();
                con.CerrarConexion();
            }
        }

        public Int32 getIdDep(string dep)
        {
            int existe = 0;
            sb.Clear();
            sb.Append("Use QUICKIEBD;");
            sb.Append("SELECT idDepartamento from Departamento where nombreDepartamento = '" + dep + "';");

            try
            {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                if (idr.Read())
                {
                    existe = Convert.ToInt32(idr["idDepartamento"]);
                }
                return existe;
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