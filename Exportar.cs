using System;
namespace COntrolREyS
{
    public partial class Exportar : Gtk.Window
    {
        public Exportar() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnButton5Clicked(object sender, EventArgs e)
        {

            COntrolREyS.ADminWindow Ad = new COntrolREyS.ADminWindow();
            Ad.Show();
            this.Hide();
        }


        protected void OnButton1Clicked(object sender, EventArgs e)
        {


        }
    }
}
