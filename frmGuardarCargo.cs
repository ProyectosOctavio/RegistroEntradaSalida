using System;
using System.Collections.Generic;
using COntrolREyS.Datos;
using COntrolREyS.Properties;
using Gtk;

namespace COntrolREyS
{
  
    public partial class frmGuardarCargo : Gtk.Window
    {

        public frmGuardarCargo() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarcbxDep();
        }
        tbl_Cargo tbu = new tbl_Cargo();
        DT_tbl_Cargo dtu = new DT_tbl_Cargo();
        DT_tbl_Departamento dtr = new DT_tbl_Departamento();
        tbl_departamento tbur = new tbl_departamento();
        MessageDialog ms = null;

        protected void llenarcbxDep()
        {
            List<tbl_departamento> listaDep = new List<tbl_departamento>();
            listaDep = dtr.llenarcbxDep();

            this.cbxDepartamento.InsertText(0, "Seleccione...");


            foreach (tbl_departamento tbr in listaDep)
            {
                this.cbxDepartamento.InsertText(tbr.Id_departamento, tbr.NombreDepartamento);
            }
        }

      

        protected void OnBtnAlmacenarClicked(object sender, EventArgs e)
        {

            string Departamento;
            Departamento = this.cbxDepartamento.ActiveText.Trim().ToString();
            tbu.NombreCargo = this.txtNombre.Text.Trim();
            tbu.Descripcion = this.txtDescripcion.Text.Trim();
            tbu.idDepartamento = dtr.getIdDep(Departamento);

            try
            {
                if (dtu.guardarCargo(tbu))
                {
                    ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info,
            ButtonsType.Ok, "Cargo Agregado");
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
        public void limpiarCampos()
        {
            this.txtNombre.Text = "";
            this.txtDescripcion.Text = "";
        }


        protected void OnBtnRegresarClicked(object sender, EventArgs e)
        {

            COntrolREyS.AdminCargo AdC = new COntrolREyS.AdminCargo();
            AdC.Show();
            this.Hide();


        }



    }


}
