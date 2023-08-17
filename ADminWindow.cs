using System;
namespace COntrolREyS
{
    public partial class ADminWindow : Gtk.Window
    {



        private void Iteracion()
        {
            GLib.Timeout.Add(100, new GLib.TimeoutHandler(Actualizacion));
        }

        private bool Actualizacion()
        {

            lblHora.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");

            return true;
        }




        public ADminWindow() :
        base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            Iteracion();


        }
        protected void OnCerrarSesionAction1Activated(object sender, EventArgs e)
        {

            MainWindow MainW = new MainWindow();
            MainW.Show();
            this.Hide();
        }

        protected void OnEmpleadoActionActivated(object sender, EventArgs e)
        {


            COntrolREyS.AdminEmpleado AdEm = new COntrolREyS.AdminEmpleado();
            AdEm.Show();
            this.Hide();

        }

        protected void OnDepartamentoActionActivated(object sender, EventArgs e)
        {
            COntrolREyS.AdminDepartamento AdDe = new COntrolREyS.AdminDepartamento();
            AdDe.Show();
            this.Hide();

        }

        protected void OnCargoActionActivated(object sender, EventArgs e)
        {

            COntrolREyS.AdminCargo AdCa = new COntrolREyS.AdminCargo();
            AdCa.Show();
            this.Hide();

        }

        protected void OnEmpleadoAction1Activated(object sender, EventArgs e)
        {

            COntrolREyS.ReporteEmpleado ReEM = new COntrolREyS.ReporteEmpleado();
            ReEM.Show();
            this.Hide();


        }

        protected void OnArchivoActionActivated(object sender, EventArgs e)
        {
        }

        protected void OnExportarActionActivated(object sender, EventArgs e)
        {
            COntrolREyS.Exportar Exp = new COntrolREyS.Exportar();
            Exp.Show();
            this.Hide();
        }

       

        protected void OnCerrarSesinActionActivated(object sender, EventArgs e)
        {
            MainWindow MainW = new MainWindow();
            MainW.Show();
            this.Hide();

        }

        protected void OnDepartamentoAction1Activated(object sender, EventArgs e)
        {

            COntrolREyS.ReporteDepartamento  ReDe = new COntrolREyS.ReporteDepartamento();
            ReDe.Show();
            this.Hide();

        }

        protected void OnCargoAction1Activated(object sender, EventArgs e)
        {

            COntrolREyS.ReporteCargo ReCa = new COntrolREyS.ReporteCargo();
            ReCa.Show();
            this.Hide();

        }

        protected void OnHoraEntradaYSalidaActionActivated(object sender, EventArgs e)
        {

            COntrolREyS.ReporteEntradaSalida ReEnSA = new COntrolREyS.ReporteEntradaSalida();
            ReEnSA.Show();
            this.Hide();

        }
    }
}