using System;
using COntrolREyS.Datos;
using COntrolREyS.Properties;
using Gtk;
using MySql.Data.MySqlClient;

namespace COntrolREyS
{
    public partial class Entrada : Gtk.Window
    {

        tbl_Asistencia tbu = new tbl_Asistencia();
        DT_tbl_Asistencia dtu = new DT_tbl_Asistencia();
        MessageDialog ms = null;

        public Entrada() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();

            Iteracion();

            this.btnSalida.Visible = false;

        }

        private void Iteracion()
        {
            GLib.Timeout.Add(100, new GLib.TimeoutHandler(Actualizacion));
        }

        private bool Actualizacion()
        {

            lblHora.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            return true;
        }

        
        string cedula;
        string tipodemarca;
        string horasMarcadas;

        protected void OnBtnEntradaClicked(object sender, EventArgs e)
        {
            if (txtTipoDeMarca.Text.Equals("Entrada") || txtTipoDeMarca.Text.Equals("Salida") || 
            txtTipoDeMarca.Text.Equals("entrada") || txtTipoDeMarca.Text.Equals("salida"))
            {

                if (existeUsuario(txtNombre.Text))
                {
                    DateTime now = DateTime.Now;
                    Console.WriteLine("Existe");
                    cedula = txtNombre.Text.Trim();
                    tipodemarca = txtTipoDeMarca.Text.Trim();
                    horasMarcadas = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    tbu.HorasMarcadas = horasMarcadas;
                    tbu.TipoDeMarca = tipodemarca;
                    tbu.Cedula = cedula;
                    btnEntrada.Visible = false;
                    btnSalida.Visible = true;
                }
                else
                {

                    txtNombre.Text = "";

                    ms = new MessageDialog(null, DialogFlags.Modal,
                     MessageType.Warning, ButtonsType.Ok, "Empleado no encontrado, vuelva a digitar su Cedula");
                    ms.Run();
                    ms.Show();
                    ms.Destroy();

                }
            }

            else
            {
                txtTipoDeMarca.Text = "";
                ms = new MessageDialog(null, DialogFlags.Modal,
                    MessageType.Warning, ButtonsType.Ok, "Tipo de marca no valido");
                ms.Run();
                ms.Show();
                ms.Destroy();
                this.btnEntrada.Visible = true;
                this.btnSalida.Visible = false;

             
                }

        }

        private bool existeUsuario(string Cedula)
        {
            string cadenita = "server=localhost;uid=Yizi;database=QUICKIEBD;pwd=pa";
            MySqlConnection conn = new MySqlConnection(cadenita);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT cedula FROM Empleado WHERE Cedula = '" + Cedula + "'";

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["cedula"].ToString() == Cedula)
                    {
                        Console.WriteLine(reader["cedula"].ToString());
                        return true;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                conn.Close();
            }

            Console.WriteLine("No existe");
            return false;
        }

        protected void OnBtnSalidaClicked(object sender, EventArgs e)
        {

            try
            {
                if (dtu.registrarAsistencia(tbu))
                {
                    ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Se guardó correctamente");
                    ms.Run();
                    ms.Destroy();
                    REmpleado re = new REmpleado();
                    re.Show();

                    this.Destroy();
                }
                else
                {
                    Console.WriteLine("Ocurrió un Error");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            btnEntrada.Visible = true;

        }
    }

}



