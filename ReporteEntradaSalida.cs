
using System;
using COntrolREyS.Datos;
using COntrolREyS.Properties;
using Gtk;


namespace COntrolREyS
{
    public partial class ReporteEntradaSalida : Gtk.Window
    {

        //DECLARACIONES E INSTANCIAS DE OBJETOS
        tbl_Asistencia tbu4 = new tbl_Asistencia();

        DT_tbl_Asistencia dtu4 = new DT_tbl_Asistencia();

        MessageDialog ms = null;


        public ReporteEntradaSalida() :
                base(Gtk.WindowType.Toplevel)
        {

            //SE EJECUTA CUANDO SE ABRE LA VENTANA

            this.Build();

            //CARGAMOS EL TREEVIEW
            this.TvListaAsistencia.Model = dtu4.listaAsistencia();

            string[] titulos = { "Id Asistencia", "Tipo De Marca", "Horas Marcadas", "Nombre", "Apellido", "Cedula", };
            for (int i = 0; i < titulos.Length; i++)
            {
                this.TvListaAsistencia.AppendColumn(titulos[i], new CellRendererText(), "text", i);
            }

        }

   

        protected void OnBtnRegresarClicked(object sender, EventArgs e)
        {
            COntrolREyS.ADminWindow Ad = new COntrolREyS.ADminWindow();
            Ad.Show();
            this.Hide();
        }
    }
}
