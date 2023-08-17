using System;
using Gtk;
using COntrolREyS.Datos;
using COntrolREyS.Properties;
namespace COntrolREyS
{
    public partial class ReporteEmpleado : Gtk.Window
    {
        //DECLARACIONES E INSTANCIAS DE OBJETOS
        tbl_empleado tbu = new tbl_empleado();

        DT_tbl_Empleado dtu3 = new DT_tbl_Empleado();

        MessageDialog ms = null;


        protected void OnButton8Clicked(object sender, EventArgs e)
        {

            COntrolREyS.ADminWindow Ad = new COntrolREyS.ADminWindow();
            Ad.Show();
            this.Hide();
        }


        public ReporteEmpleado() :
              base(Gtk.WindowType.Toplevel)
        {
         
            //SE EJECUTA CUANDO SE ABRE LA VENTANA

            this.Build();

            //CARGAMOS EL TREEVIEW
            this.TvListaEmpleado.Model = dtu3.listaEmpleado();

            string[] titulos = { "Id Empleado", "Nombre", "Apellido", "Cargo", "Telefono", "Email", 
                "Estado", "Direccion", "Cedula", "Id Cargo" };
            for (int i = 0; i < titulos.Length; i++)
            {
                this.TvListaEmpleado.AppendColumn(titulos[i], new CellRendererText(), "text", i);
            }



        }

    }
}
