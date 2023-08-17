using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using COntrolREyS.Properties;
using Gtk;


namespace COntrolREyS.Datos
{
    public class DT_tbl_Cargo
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

        public ListStore listaCargo()
        {
            ListStore cargo_datos = new ListStore(typeof(int), typeof(string), typeof(string), typeof(string), typeof(int));

            Sb.Clear();
            Sb.Append("Use QUICKIEBD;");
            Sb.Append("SELECT Departamento.nombreDepartamento, Cargo.idCargo, Cargo.nombreCargo, Cargo.descripcion, " +
                "Cargo.idDepartamento From Departamento INNER JOIN Cargo ON Departamento.idDepartamento = Cargo.idDepartamento;");
            try
            {
                Con.AbrirConexion();
                Idr = Con.Leer(CommandType.Text, Sb.ToString());
                while (Idr.Read())
                {
                    cargo_datos.AppendValues(Idr[1], Idr[0], Idr[2], Idr[3], Idr[4]);
                }
                Console.WriteLine(cargo_datos);
                return cargo_datos;
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
            return cargo_datos;
        }

        public bool guardarCargo(tbl_Cargo cargo)
        {
            bool guardado = false;
            int x = 0;
            sb.Clear();
            sb.Append("INSERT INTO QUICKIEBD.Cargo");
            sb.Append("(nombreCargo, descripcion, estadoCargo, idDepartamento)");
            sb.Append("VALUES('" + cargo.NombreCargo + "', '" + cargo.Descripcion + "',  1 ," + cargo.idDepartamento + ");");

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


        public tbl_Cargo listById(int idcargo)
        {
            tbl_Cargo tu = new tbl_Cargo();
            sb.Clear();
            sb.Append("Use QUICKIEBD;");
            sb.Append("SELECT * FROM Cargo where idCargo = " + idcargo);
            try
            {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                if (idr.Read())
                {
                    tu.idCargo = Convert.ToInt32(idr["idCargo"]);
                    tu.NombreCargo = idr["nombreCargo"].ToString();
                    tu.Descripcion = idr["descripcion"].ToString();
                    tu.EstadoCargo = Convert.ToInt32(idr["estadoCargo"]);
                    tu.idDepartamento = Convert.ToInt32(idr["idDepartamento"]);
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
        public Int32 eliminarCargo(tbl_Cargo cargo)
        {
            int eliminado;
            sb.Clear();
            sb.Append("DELETE FROM QUICKIEBD.Cargo WHERE idCargo = "
            + cargo.idCargo);

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

        public bool EditarCargo(tbl_Cargo u)
        {


            bool editado = false;
            int x = 0;
            sb.Clear();
            sb.Append("Update QUICKIEBD.Cargo");
            sb.Append(" set nombreCargo= '" + u.NombreCargo + "',");
            sb.Append(" descripcion= '" + u.Descripcion + "',");
            sb.Append(" estadoCargo= '" + u.EstadoCargo + "',");
            sb.Append("  idDepartamento= '" + u.IdDepartamento + "'");
            sb.Append(" WHERE idCargo = " + u.IdCargo);

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


        public ListStore buscarCargo(string cadena)
        {

            ListStore datos = new ListStore(typeof(int), typeof(string), typeof(string), typeof(string), typeof(int));

            sb.Clear();
            sb.Append("Use QUICKIEBD;");
            Sb.Append("SELECT Departamento.nombreDepartamento, Cargo.idCargo, Cargo.nombreCargo, Cargo.descripcion, " +
            	"Cargo.idDepartamento From Departamento INNER JOIN Cargo ON Departamento.idDepartamento = Cargo.idDepartamento WHERE Cargo.nombreCargo like '%" + cadena + "%'");


            try
            {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    datos.AppendValues(idr[1], idr[0], idr[2], idr[3], idr[4]);

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


        public List<tbl_Cargo> llenarcbxCargo()
        {
            List<tbl_Cargo> listaCargo = new List<tbl_Cargo>();

            sb.Clear();
            sb.Append("Use QUICKIEBD;");
            sb.Append("select * from Cargo;");
            try
            {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    tbl_Cargo tr = new tbl_Cargo()
                    {
                        IdCargo = Convert.ToInt32(idr["idCargo"]),
                        NombreCargo = idr["nombreCargo"].ToString(),

                    };
                    listaCargo.Add(tr);
                }
                return listaCargo;
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

        public Int32 getIdCargo(string cargo)
        {
            int existe = 0;
            sb.Clear();
            sb.Append("Use QUICKIEBD;");
            sb.Append("SELECT idCargo from Cargo where nombreCargo = '" + cargo + "';");

            try
            {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                if (idr.Read())
                {
                    existe = Convert.ToInt32(idr["idCargo"]);
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

