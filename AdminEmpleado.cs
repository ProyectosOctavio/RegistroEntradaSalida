using System;
using System.Collections.Generic;
using COntrolREyS.Datos;
using COntrolREyS.Properties;
using Gtk;
namespace COntrolREyS
{
    public partial class AdminEmpleado : Gtk.Window
    {
        //DECLARACIONES E INSTANCIAS DE OBJETOS

        DT_tbl_Cargo dtr = new DT_tbl_Cargo();
        tbl_empleado tbu = new tbl_empleado();
        DT_tbl_Empleado dtu = new DT_tbl_Empleado();
 
        MessageDialog ms = null;

 

        protected void OnButton5Clicked(object sender, EventArgs e)
        {
            COntrolREyS.AdminCargo Ad = new COntrolREyS.AdminCargo();
            Ad.Show();
            this.Hide();

        }


        //SE EJECUTA CUANDO SE ABRE LA VENTANA
        public AdminEmpleado() : base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarcbxCargo();
            //CARGAMOS EL TREEVIEW
            this.TvListaEmpleado.Model = dtu.listaEmpleado();

            string[] titulos = { "Id Empleado", "Nombre", "Apellido", "Nombre Cargo", "Telefono", 
                "Email", "Estado", "Direccion", "Cedula", "Id Cargo"  };
            for (int i = 0; i < titulos.Length; i++)
            {
                this.TvListaEmpleado.AppendColumn(titulos[i], new CellRendererText(), "text", i);
            }

 


        }

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

        protected void OnButton11Clicked(object sender, EventArgs e)
        {

            COntrolREyS.ADminWindow Ad = new COntrolREyS.ADminWindow();
            Ad.Show();
            this.Hide();
        }

        protected void OnTvListaEmpleadoCursorChanged(object sender, EventArgs e)
        {
            try
            {
                TreeSelection seleccion = (sender as TreeView).Selection;
                TreeIter iter;
                TreeModel model;
                if (seleccion.GetSelected(out model, out iter))
                {
                    tbu = dtu.listById(Convert.ToInt32(model.GetValue(iter, 0).ToString()));
                    this.txtId.Text = tbu.id_empleado.ToString();
                    this.txtNombre.Text = tbu.Nombre.ToString();
                    this.txtEstado.Text = tbu.EstadoEmpleado.ToString();
                    this.txtApellido.Text = tbu.Apellido.ToString();
                    this.txtEmail.Text = tbu.Email.ToString();
                    this.txtDireccion.Text = tbu.Direccion.ToString();
                    this.txtTelefono.Text = tbu.Telefono.ToString();
                    this.txtCedula.Text = tbu.Cedula.ToString();
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
            this.txtId.Text = "";
            this.txtEmail.Text = "";
            this.txtBuscar.Text = "";
            this.txtCedula.Text = "";
            this.txtEstado.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtTelefono.Text = "";
            this.txtDireccion.Text = "";
        }

        protected void OnButton9Clicked(object sender, EventArgs e)
        {
            {
                if (txtId.Text.Equals(""))
                {
                    ms = new MessageDialog(null, DialogFlags.Modal,
                    MessageType.Warning, ButtonsType.Ok, "Debe seleccionar el usuario a Eliminar");
                    ms.Run();
                    ms.Destroy();
                }
                else
                {
                    //Pregunta para confirmar eliminación de usuario
                    ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error,
                        ButtonsType.YesNo, "¿Desea eliminar al usuario?");
                    ResponseType response = (ResponseType)ms.Run();
                    ms.Show();

                    if (response == ResponseType.Yes)
                    {
                        ms.Destroy();
                        //Se obtiene el valor del id
                        tbu.id_empleado = Convert.ToInt32(this.txtId.Text);
                        if (dtu.eliminarEmpleado(tbu) > 0)
                        {
                            ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info,
                                ButtonsType.Ok, "El usuario ha sido eliminado");
                            ms.Run();
                            ms.Destroy();
                            limpiarCampos();
                            this.TvListaEmpleado.Model = dtu.listaEmpleado();
                        }
                        else
                        {
                            ms = new MessageDialog(null, DialogFlags.Modal,
                                MessageType.Warning, ButtonsType.Ok, "Error: Verifique los datos del usuario");
                            ms.Run();
                            ms.Destroy();
                        }
                    }
                    else
                    {
                        Console.WriteLine("F");
                        ms.Destroy();
                    }


                }

            }
        }

        protected void OnButton10Clicked(object sender, EventArgs e)
        {
            try
            {

                if (txtId.Text.Equals("") || txtNombre.Text.Equals("") ||
            txtEstado.Text.Equals("") || txtEmail.Text.Equals("") || txtCedula.Text.Equals("") || txtTelefono.Text.Equals("")
                    || txtApellido.Text.Equals("") || txtDireccion.Text.Equals(""))
                {
                    ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Warning,
                    ButtonsType.Ok, "Todos los campos son requeridos");
                    ms.Run();
                    ms.Destroy();
                }
                else
                {
                    string Cargo;
                    Cargo = this.cbxCargo.ActiveText.Trim().ToString();
                    tbu.id_empleado = Convert.ToInt32(this.txtId.Text);
                    tbu.Nombre = this.txtNombre.Text.Trim();
                    tbu.Apellido = this.txtApellido.Text.Trim();
                    tbu.Telefono = this.txtTelefono.Text;
                    tbu.Email = this.txtEmail.Text;
                    tbu.EstadoEmpleado = Convert.ToInt32(this.txtEstado.Text);
                    tbu.Direccion = this.txtDireccion.Text;
                    tbu.Cedula = this.txtCedula.Text;
                    tbu.IdCargo = dtr.getIdCargo(Cargo);

                    if (dtu.EditarEmpleado(tbu))
                    {
                        ms = new MessageDialog(null, DialogFlags.Modal,
                            MessageType.Info, ButtonsType.Ok, "Datos actualizados");
                        ms.Run();
                        ms.Destroy();
                        limpiarCampos();
                        this.TvListaEmpleado.Model = dtu.listaEmpleado();
                    }
                    else
                    {
                        ms = new MessageDialog(null, DialogFlags.Modal,
                            MessageType.Error, ButtonsType.Ok,
                            "Error al editar datos");
                        ms.Run();
                        ms.Destroy();
                    }
                }
            }
            catch (Exception ex)
            {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, ex.Message);
                ms.Run();
                ms.Destroy();
            }
        }

        protected void OnBtnBuscarClicked(object sender, EventArgs e)
        {
            this.TvListaEmpleado.Model = dtu.buscarEmpleado(this.txtBuscar.Text.Trim());
        }

        protected void OnBtnAgregarClicked(object sender, EventArgs e)
        {
            COntrolREyS.frmGuardarEmpleado frmCa = new frmGuardarEmpleado();
            frmCa.Show();
            this.Hide();
            this.TvListaEmpleado.Model = dtu.listaEmpleado();
        }
    }
}
