
// This file has been generated by the GUI designer. Do not modify.
namespace COntrolREyS
{
	public partial class frmGuardarCargo
	{
		private global::Gtk.Fixed fixed1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label Nombre;

		private global::Gtk.Entry txtNombre;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label3;

		private global::Gtk.Entry txtDescripcion;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label Departamentos;

		private global::Gtk.ComboBox cbxDepartamento;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Button btnAlmacenar;

		private global::Gtk.Button btnRegresar;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget COntrolREyS.frmGuardarCargo
			this.Name = "COntrolREyS.frmGuardarCargo";
			this.Title = global::Mono.Unix.Catalog.GetString("frmGuardarCargo");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child COntrolREyS.frmGuardarCargo.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.Nombre = new global::Gtk.Label();
			this.Nombre.Name = "Nombre";
			this.Nombre.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre");
			this.hbox1.Add(this.Nombre);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.Nombre]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.txtNombre = new global::Gtk.Entry();
			this.txtNombre.CanFocus = true;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.IsEditable = true;
			this.txtNombre.InvisibleChar = '•';
			this.hbox1.Add(this.txtNombre);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.txtNombre]));
			w2.Position = 1;
			this.fixed1.Add(this.hbox1);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.hbox1]));
			w3.X = 39;
			w3.Y = 19;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Descripcion");
			this.hbox2.Add(this.label3);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label3]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.txtDescripcion = new global::Gtk.Entry();
			this.txtDescripcion.CanFocus = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.IsEditable = true;
			this.txtDescripcion.InvisibleChar = '•';
			this.hbox2.Add(this.txtDescripcion);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.txtDescripcion]));
			w5.Position = 1;
			this.fixed1.Add(this.hbox2);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.hbox2]));
			w6.X = 17;
			w6.Y = 58;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.Departamentos = new global::Gtk.Label();
			this.Departamentos.Name = "Departamentos";
			this.Departamentos.LabelProp = global::Mono.Unix.Catalog.GetString("Departamentos");
			this.hbox3.Add(this.Departamentos);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.Departamentos]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.cbxDepartamento = global::Gtk.ComboBox.NewText();
			this.cbxDepartamento.Name = "cbxDepartamento";
			this.hbox3.Add(this.cbxDepartamento);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.cbxDepartamento]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.fixed1.Add(this.hbox3);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.hbox3]));
			w9.X = 47;
			w9.Y = 96;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.btnAlmacenar = new global::Gtk.Button();
			this.btnAlmacenar.CanFocus = true;
			this.btnAlmacenar.Name = "btnAlmacenar";
			this.btnAlmacenar.UseUnderline = true;
			this.btnAlmacenar.Label = global::Mono.Unix.Catalog.GetString("Guardar");
			this.hbox4.Add(this.btnAlmacenar);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.btnAlmacenar]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.btnRegresar = new global::Gtk.Button();
			this.btnRegresar.CanFocus = true;
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.UseUnderline = true;
			this.btnRegresar.Label = global::Mono.Unix.Catalog.GetString("Regresar");
			this.hbox4.Add(this.btnRegresar);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.btnRegresar]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.fixed1.Add(this.hbox4);
			global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.hbox4]));
			w12.X = 31;
			w12.Y = 140;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 285;
			this.DefaultHeight = 188;
			this.Show();
			this.btnAlmacenar.Clicked += new global::System.EventHandler(this.OnBtnAlmacenarClicked);
			this.btnRegresar.Clicked += new global::System.EventHandler(this.OnBtnRegresarClicked);
		}
	}
}