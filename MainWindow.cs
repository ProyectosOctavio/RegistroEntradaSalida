using System;
using Gtk;
using MySql.Data.MySqlClient;


public partial class MainWindow : Gtk.Window
{
    MessageDialog ms = null;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

  
    protected void OnButton3Clicked(object sender, EventArgs e)
    {


        if (txtAdmin.Text == "1234")
        {
            COntrolREyS.ADminWindow Ad = new COntrolREyS.ADminWindow();
        Ad.Show();
        this.Hide();
        }

        else
        {
            txtAdmin.Text = "";

            ms = new MessageDialog(null, DialogFlags.Modal,
                    MessageType.Warning, ButtonsType.Ok, "Contraseña incorrecta");
            ms.Run();
            ms.Show();
            ms.Destroy();

        }

    }

    protected void OnBtnEmpleadoClicked(object sender, EventArgs e)
    {

        COntrolREyS.Entrada Entr = new COntrolREyS.Entrada();
        Entr.Show();
        this.Hide();
    }
}

