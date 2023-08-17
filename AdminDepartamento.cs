using System;
using COntrolREyS.Datos;
using COntrolREyS.Properties;
using Gtk;

namespace COntrolREyS
{
    public partial class AdminDepartamento : Gtk.Window
    {
        //DECLARACIONES E INSTANCIAS DE OBJETOS
        tbl_departamento tbu = new tbl_departamento();

        DT_tbl_Departamento dtu = new DT_tbl_Departamento();

        MessageDialog ms = null;

    

        //SE EJECUTA CUANDO SE ABRE LA VENTANA
        public AdminDepartamento() : base(Gtk.WindowType.Toplevel)
        {
            this.Build();

            //CARGAMOS EL TREEVIEW
            this.TvListaDepartamentoA.Model = dtu.listaDepartamento();

            string[] titulos = { "Id Deparamento", "Departamento", "Estado" };
            for (int i = 0; i < titulos.Length; i++)
            {
                this.TvListaDepartamentoA.AppendColumn(titulos[i], new CellRendererText(), "text", i);
            }

        }


        protected void OnBtnAgregarClicked(object sender, EventArgs e)
        {

            COntrolREyS.frmGuardarDepartamento frmDep = new frmGuardarDepartamento();
            frmDep.Show();
            this.Hide();
            this.TvListaDepartamentoA.Model = dtu.listaDepartamento();

        }


        protected void OnTvListaDepartamentoACursorChanged(object sender, EventArgs e)
        {
            try
            {
                TreeSelection seleccion = (sender as TreeView).Selection;
            TreeIter iter;
            TreeModel model;
            if (seleccion.GetSelected(out model, out iter))
            {
                tbu = dtu.listById(Convert.ToInt32(model.GetValue(iter, 0).ToString()));
                this.txtId.Text = tbu.Id_departamento.ToString();
                this.txtNombre.Text = tbu.NombreDepartamento.ToString();
                this.txtEstado.Text = tbu.EstadoDepartamento.ToString();

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
            this.txtEstado.Text = "";
            this.txtNombre.Text = "";
        }



        protected void OnBtnEliminarClicked(object sender, EventArgs e)
        {

            {
                if (txtId.Text.Equals(""))
                {
                    ms = new MessageDialog(null, DialogFlags.Modal,
                    MessageType.Warning, ButtonsType.Ok, "Debe seleccionar el Departamento a Eliminar");
                    ms.Run();
                    ms.Destroy();
                }
                else
                {
                    //Pregunta para confirmar eliminación de usuario
                    ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error,
                        ButtonsType.YesNo, "¿Desea eliminar este Departamento?");
                    ResponseType response = (ResponseType)ms.Run();
                    ms.Show();

                    if (response == ResponseType.Yes)
                    {
                        ms.Destroy();
                        //Se obtiene el valor del id
                        tbu.Id_departamento = Convert.ToInt32(this.txtId.Text);
                        if (dtu.eliminarDepartamento(tbu) > 0)
                        {
                            ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info,
                                ButtonsType.Ok, "El Departamento ha sido eliminado");
                            ms.Run();
                            ms.Destroy();
                            limpiarCampos();
                            this.TvListaDepartamentoA.Model = dtu.listaDepartamento();
                        }
                        else
                        {
                            ms = new MessageDialog(null, DialogFlags.Modal,
                                MessageType.Warning, ButtonsType.Ok, "Error: Verifique los datos del Departamento");
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



        protected void OnBtnModificarClicked(object sender, EventArgs e)
        {
                try
                {

                    if (txtId.Text.Equals("") || txtNombre.Text.Equals("") ||
                txtEstado.Text.Equals(""))
                    {
                        ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Warning,
                        ButtonsType.Ok, "Todos los campos son requeridos");
                        ms.Run();
                        ms.Destroy();
                    }
                    else
                    {
                        tbu.Id_departamento = Convert.ToInt32(this.txtId.Text);
                        tbu.NombreDepartamento = this.txtNombre.Text.Trim();
                        tbu.EstadoDepartamento = Convert.ToInt32(this.txtEstado.Text);

                        if (dtu.EditarDepartamento(tbu))
                        {
                            ms = new MessageDialog(null, DialogFlags.Modal,
                                MessageType.Info, ButtonsType.Ok, "Datos actualizados");
                            ms.Run();
                            ms.Destroy();
                            limpiarCampos();
                            this.TvListaDepartamentoA.Model = dtu.listaDepartamento();
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
            this.TvListaDepartamentoA.Model = dtu.buscarDepartamento(this.txtBuscar.Text.Trim());
        }

        protected void OnBtnRegresarClicked(object sender, EventArgs e)
        {
            COntrolREyS.ADminWindow Ad = new COntrolREyS.ADminWindow();
            Ad.Show();
            this.Hide();
        }
    }
}
