using System;
using COntrolREyS.Datos;
using COntrolREyS.Properties;
using Gtk;

namespace COntrolREyS
{
    public partial class frmGuardarDepartamento : Gtk.Window
    {


        tbl_departamento tbu = new tbl_departamento();

    DT_tbl_Departamento dtu = new DT_tbl_Departamento();
        MessageDialog ms = null;

        protected void OnBtnAlmacenarClicked(object sender, EventArgs e)
        {
            tbu.NombreDepartamento = this.txtNombre.Text.Trim();
           
            try {
                if (dtu.guardarDepartamento(tbu))
                {
                    ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info,
            ButtonsType.Ok, "Departamento Agregado");
                    limpiarCampos();
                    ms.Run();
                    ms.Destroy();

                }
                else
                {
                    Console.WriteLine("Ocurrió un Error");
                }
            }

            catch(Exception ex)
            {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, ex.Message);
                ms.Run();
                ms.Destroy();
            }

   
        }

        public void limpiarCampos()
        {
            this.txtNombre.Text = "";
        }

        public frmGuardarDepartamento() :
          base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnBtnRegresarClicked(object sender, EventArgs e)
        {


            COntrolREyS.AdminDepartamento AdDe = new COntrolREyS.AdminDepartamento();
            AdDe.Show();
            this.Hide();


        }
    }
}

