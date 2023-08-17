using System;
using System.Collections.Generic;
using COntrolREyS.Datos;
using COntrolREyS.Properties;
using Gtk;

namespace COntrolREyS
{
    public partial class frmGuardarEmpleado : Gtk.Window
    {
        public frmGuardarEmpleado() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarcbxCargo();
        }

        tbl_Cargo tbur = new tbl_Cargo();
        DT_tbl_Cargo dtr = new DT_tbl_Cargo();
        tbl_empleado tbu = new tbl_empleado();
        DT_tbl_Empleado dtu = new DT_tbl_Empleado();
        MessageDialog ms = null;

        protected void llenarcbxCargo()
        {
            List<tbl_Cargo> listaCargo = new List<tbl_Cargo>();
            listaCargo = dtr.llenarcbxCargo();

            this.cbxCargo.InsertText(0, "Seleccione...");


            foreach (tbl_Cargo tbr in listaCargo)
            {
                this.cbxCargo.InsertText(tbr.IdCargo, tbr.NombreCargo);
            }
        }

        public void limpiarCampos()
        {
        
            this.txtEmail.Text = "";
            this.txtCedula.Text = "";
            this.txtEstado.Text = "";
            this.txtNombre.Text = "";
            this.txtApellidos.Text = "";
            this.txtTelefono.Text = "";
            this.txtDireccion.Text = "";
        }

        protected void OnBtnGuardarClicked(object sender, EventArgs e)
        {
            string Cargo;
            Cargo = this.cbxCargo.ActiveText.Trim().ToString();
            tbu.Nombre = this.txtNombre.Text.Trim();
            tbu.Apellido = this.txtApellidos.Text.Trim();
            tbu.Telefono = this.txtTelefono.Text.Trim();
            tbu.Email = this.txtEmail.Text.Trim();
            tbu.EstadoEmpleado = Int32.Parse(this.txtEstado.Text.Trim());
            tbu.Direccion = this.txtDireccion.Text.Trim();
            tbu.Cedula = this.txtCedula.Text.Trim();
            tbu.IdCargo = dtr.getIdCargo(Cargo);

            try
            {
                if (dtu.guardarEmpleado(tbu))
                {
                    ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info,
            ButtonsType.Ok, "Empleado Agregado");
                    limpiarCampos();
                    ms.Run();
                    ms.Destroy();

                }
                else
                {
                    Console.WriteLine("Ocurrió un Error");
                }
            }

            catch (Exception ex)
            {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, ex.Message);
                ms.Run();
                ms.Destroy();
            }
        }

        protected void OnBtnRegresarClicked(object sender, EventArgs e)
        {
            COntrolREyS.AdminEmpleado AdC = new COntrolREyS.AdminEmpleado();
            AdC.Show();
            this.Hide();
        }
    }
}
