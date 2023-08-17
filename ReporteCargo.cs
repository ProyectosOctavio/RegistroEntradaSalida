using System;
using Gtk;
using System.Data;
using System.Text;
using COntrolREyS.Datos;
using COntrolREyS.Properties;
namespace COntrolREyS
{
    public partial class ReporteCargo : Gtk.Window
    {
        //DECLARACIONES E INSTANCIAS DE OBJETOS
        tbl_Cargo tbu2 = new tbl_Cargo();

        DT_tbl_Cargo dtu2 = new DT_tbl_Cargo();

        MessageDialog ms = null;


        protected void OnButton10Clicked(object sender, EventArgs e)
        {

            COntrolREyS.ADminWindow Ad = new COntrolREyS.ADminWindow();
            Ad.Show();
            this.Hide();
        }


        public ReporteCargo() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();

            this.TvListaCargo.Model = dtu2.listaCargo();


            string[] titulos = { "Id Cargo", "Departamento", "Cargo", "Descripcion", "Id Departamento" };
            for (int i = 0; i < titulos.Length; i++)
            {
                this.TvListaCargo.AppendColumn(titulos[i], new CellRendererText(), "text", i);
            }


        }

   

    }
}
