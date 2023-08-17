using System;
using Gtk;
using COntrolREyS.Datos;
using COntrolREyS.Properties;

namespace COntrolREyS
{
    public partial class ReporteDepartamento : Gtk.Window
    {
        //DECLARACIONES E INSTANCIAS DE OBJETOS
        tbl_departamento tbu = new tbl_departamento();

        DT_tbl_Departamento dtu = new DT_tbl_Departamento();

        MessageDialog ms = null;

        protected void OnButton9Clicked(object sender, EventArgs e)
        {
            COntrolREyS.ADminWindow Ad = new COntrolREyS.ADminWindow();
            Ad.Show();
            this.Hide();


        }


        public ReporteDepartamento() :
                base(Gtk.WindowType.Toplevel)
        {
 

            //SE EJECUTA CUANDO SE ABRE LA VENTANA
          
                this.Build();
                
                //CARGAMOS EL TREEVIEW
                this.TvListaDepartamento.Model = dtu.listaDepartamento();

                string[] titulos = { "Id Deparamento", "Departamento", "Estado"};
                for (int i = 0; i < titulos.Length; i++)
                {
                    this.TvListaDepartamento.AppendColumn(titulos[i], new CellRendererText(), "text", i);
                }

            }
       


    }

      
    }






