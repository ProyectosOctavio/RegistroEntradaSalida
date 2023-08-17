using System;
using System.Collections.Generic;
using COntrolREyS.Datos;
using COntrolREyS.Properties;
using Gtk;

namespace COntrolREyS
{
    public partial class AdminCargo : Gtk.Window
    {
      
            //DECLARACIONES E INSTANCIAS DE OBJETOS
            tbl_Cargo tbu = new tbl_Cargo();

            DT_tbl_Cargo dtu = new DT_tbl_Cargo();

            MessageDialog ms = null;

        DT_tbl_Departamento dtur = new DT_tbl_Departamento();

        protected void OnButton6Clicked(object sender, EventArgs e)
        {

            COntrolREyS.ADminWindow Ad = new COntrolREyS.ADminWindow();
            Ad.Show();
            this.Hide();

        }

    //SE EJECUTA CUANDO SE ABRE LA VENTANA
    public AdminCargo() : base(Gtk.WindowType.Toplevel)
    {
        this.Build();
         llenarcbxDep();

            //CARGAMOS EL TREEVIEW
            this.TvListaCargo.Model = dtu.listaCargo();

        string[] titulos = { "Id Cargo", "Departamento","Cargo", "Descripcion", "Id Departamento" };
        for (int i = 0; i < titulos.Length; i++)
        {
            this.TvListaCargo.AppendColumn(titulos[i], new CellRendererText(), "text", i);
        }

        }

        protected void llenarcbxDep()
        {
            List<tbl_departamento> listaDep = new List<tbl_departamento>();
            listaDep = dtur.llenarcbxDep();

            this.cbxDepartamento.InsertText(0, "Seleccione...");


            foreach (tbl_departamento tbr in listaDep)
            {
                this.cbxDepartamento.InsertText(tbr.Id_departamento, tbr.NombreDepartamento);
            }
        }

        protected void OnBtnAgregarClicked(object sender, EventArgs e)
        {

            COntrolREyS.frmGuardarCargo frmCa = new frmGuardarCargo();
            frmCa.Show();
            this.Hide();
            this.TvListaCargo.Model = dtu.listaCargo();



        }



        protected void OnTvListaCargoCursorChanged(object sender, EventArgs e)
        {
            try
            {
                TreeSelection seleccion = (sender as TreeView).Selection;
                TreeIter iter;
                TreeModel model;
                if (seleccion.GetSelected(out model, out iter))
                {
                    tbu = dtu.listById(Convert.ToInt32(model.GetValue(iter, 0).ToString()));
                    this.txtId.Text = tbu.idCargo.ToString();
                    this.txtNombre.Text = tbu.NombreCargo.ToString();
                    this.txtEstado.Text = tbu.EstadoCargo.ToString();
                    this.txtDescipcion.Text = tbu.Descripcion.ToString();

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
            this.txtDescipcion.Text = "";
        }

        protected void OnBtnEliminarClicked(object sender, EventArgs e)
        {
            {
                if (txtId.Text.Equals(""))
                {
                    ms = new MessageDialog(null, DialogFlags.Modal,
                    MessageType.Warning, ButtonsType.Ok, "Debe seleccionar el Cargo a Eliminar");
                    ms.Run();
                    ms.Destroy();
                }
                else
                {
                    //Pregunta para confirmar eliminación de usuario
                    ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error,
                        ButtonsType.YesNo, "¿Desea eliminar este Cargo?");
                    ResponseType response = (ResponseType)ms.Run();
                    ms.Show();

                    if (response == ResponseType.Yes)
                    {
                        ms.Destroy();
                        //Se obtiene el valor del id
                        tbu.idCargo = Convert.ToInt32(this.txtId.Text);
                        if (dtu.eliminarCargo(tbu) > 0)
                        {
                            ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info,
                                ButtonsType.Ok, "El Cargo ha sido eliminado");
                            ms.Run();
                            ms.Destroy();
                            limpiarCampos();
                            this.TvListaCargo.Model = dtu.listaCargo();
                        }
                        else
                        {
                            ms = new MessageDialog(null, DialogFlags.Modal,
                                MessageType.Warning, ButtonsType.Ok, "Error: Verifique los datos del Cargo");
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
            txtEstado.Text.Equals("") || txtDescipcion.Text.Equals(""))
                {
                    ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Warning,
                    ButtonsType.Ok, "Todos los campos son requeridos");
                    ms.Run();
                    ms.Destroy();
                }
                else
                {
                    string Departamento;
                    Departamento = this.cbxDepartamento.ActiveText.Trim().ToString();
                    tbu.IdCargo = Convert.ToInt32(this.txtId.Text);
                    tbu.NombreCargo = this.txtNombre.Text.Trim();
                    tbu.Descripcion = this.txtDescipcion.Text.Trim();
                    tbu.EstadoCargo = Convert.ToInt32(this.txtEstado.Text);
                    tbu.IdDepartamento = dtur.getIdDep(Departamento);

                    if (dtu.EditarCargo(tbu))
                    {
                        ms = new MessageDialog(null, DialogFlags.Modal,
                            MessageType.Info, ButtonsType.Ok, "Datos actualizados");
                        ms.Run();
                        ms.Destroy();
                        limpiarCampos();
                        this.TvListaCargo.Model = dtu.listaCargo();
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
           
                this.TvListaCargo.Model = dtu.buscarCargo(this.txtBuscar.Text.Trim());
                

        }
    }
}
