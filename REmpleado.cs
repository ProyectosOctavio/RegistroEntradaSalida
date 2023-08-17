using System;
using Gtk;
using COntrolREyS.Datos;
using COntrolREyS.Properties;
namespace COntrolREyS

{
    public partial class REmpleado : Gtk.Window
    {

         protected void CLick(object sender, EventArgs e)
        {
            MainWindow MainW = new MainWindow();
            MainW.Show();
            this.Hide();

        }

        //DECLARACIONES E INSTANCIAS DE OBJETOS
        tbl_Asistencia tbu4 = new tbl_Asistencia();
        DT_tbl_Asistencia dtu4 = new DT_tbl_Asistencia();
        MessageDialog ms = null;
        public REmpleado() :
             base(Gtk.WindowType.Toplevel)
        {

            //SE EJECUTA CUANDO SE ABRE LA VENTANA

            this.Build();

            //CARGAMOS EL TREEVIEW
            this.TvListaReempleado.Model = dtu4.listaAsistencia();


                string[] titulos = { "Id Asistencia", "Tipo De Marca", "Horas Marcadas", "Nombre", "Apellido", "Cedula" };
            for (int i = 0; i < titulos.Length; i++)
            {
                this.TvListaReempleado.AppendColumn(titulos[i], new CellRendererText(), "text", i);
            }

            }
           


        }
}

