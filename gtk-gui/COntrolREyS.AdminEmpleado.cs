
// This file has been generated by the GUI designer. Do not modify.
namespace COntrolREyS
{
	public partial class AdminEmpleado
	{
		private global::Gtk.Fixed fixed2;

		private global::Gtk.Entry txtId;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button btnBuscar;

		private global::Gtk.Entry txtBuscar;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label3;

		private global::Gtk.Entry txtNombre;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label4;

		private global::Gtk.Entry txtApellido;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label6;

		private global::Gtk.Entry txtCedula;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Label label7;

		private global::Gtk.Entry txtEmail;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label label8;

		private global::Gtk.Entry txtTelefono;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Label label9;

		private global::Gtk.Entry txtDireccion;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Label label10;

		private global::Gtk.Entry txtEstado;

		private global::Gtk.HBox hbox9;

		private global::Gtk.Label label5;

		private global::Gtk.ComboBox cbxCargo;

		private global::Gtk.HBox hbox10;

		private global::Gtk.Button btnAgregar;

		private global::Gtk.Button btnEliminar;

		private global::Gtk.HBox hbox13;

		private global::Gtk.Button btnModificar;

		private global::Gtk.Button btnRegresar;

		private global::Gtk.VBox vbox1;

		private global::Gtk.Label label11;

		private global::Gtk.ScrolledWindow scrolledwindow1;

		private global::Gtk.TreeView TvListaEmpleado;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget COntrolREyS.AdminEmpleado
			this.Name = "COntrolREyS.AdminEmpleado";
			this.Title = global::Mono.Unix.Catalog.GetString("Empleado");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child COntrolREyS.AdminEmpleado.Gtk.Container+ContainerChild
			this.fixed2 = new global::Gtk.Fixed();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.txtId = new global::Gtk.Entry();
			this.txtId.WidthRequest = 80;
			this.txtId.HeightRequest = 30;
			this.txtId.CanFocus = true;
			this.txtId.Name = "txtId";
			this.txtId.IsEditable = true;
			this.txtId.InvisibleChar = '•';
			this.fixed2.Add(this.txtId);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.txtId]));
			w1.X = 87;
			w1.Y = 54;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnBuscar = new global::Gtk.Button();
			this.btnBuscar.CanFocus = true;
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.UseUnderline = true;
			this.btnBuscar.Label = global::Mono.Unix.Catalog.GetString("Buscar");
			this.hbox1.Add(this.btnBuscar);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.btnBuscar]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.txtBuscar = new global::Gtk.Entry();
			this.txtBuscar.CanFocus = true;
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.IsEditable = true;
			this.txtBuscar.InvisibleChar = '•';
			this.hbox1.Add(this.txtBuscar);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.txtBuscar]));
			w3.Position = 1;
			this.fixed2.Add(this.hbox1);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.hbox1]));
			w4.X = 23;
			w4.Y = 19;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre");
			this.hbox2.Add(this.label3);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label3]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.txtNombre = new global::Gtk.Entry();
			this.txtNombre.WidthRequest = 222;
			this.txtNombre.HeightRequest = 30;
			this.txtNombre.CanFocus = true;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.IsEditable = true;
			this.txtNombre.InvisibleChar = '•';
			this.hbox2.Add(this.txtNombre);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.txtNombre]));
			w6.Position = 1;
			this.fixed2.Add(this.hbox2);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.hbox2]));
			w7.X = 22;
			w7.Y = 96;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Apellido");
			this.hbox3.Add(this.label4);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label4]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.txtApellido = new global::Gtk.Entry();
			this.txtApellido.WidthRequest = 222;
			this.txtApellido.HeightRequest = 30;
			this.txtApellido.CanFocus = true;
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.IsEditable = true;
			this.txtApellido.InvisibleChar = '•';
			this.hbox3.Add(this.txtApellido);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.txtApellido]));
			w9.Position = 1;
			this.fixed2.Add(this.hbox3);
			global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.hbox3]));
			w10.X = 21;
			w10.Y = 136;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Cedula");
			this.hbox4.Add(this.label6);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label6]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.txtCedula = new global::Gtk.Entry();
			this.txtCedula.WidthRequest = 222;
			this.txtCedula.HeightRequest = 30;
			this.txtCedula.CanFocus = true;
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.IsEditable = true;
			this.txtCedula.InvisibleChar = '•';
			this.hbox4.Add(this.txtCedula);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.txtCedula]));
			w12.Position = 1;
			this.fixed2.Add(this.hbox4);
			global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.hbox4]));
			w13.X = 31;
			w13.Y = 175;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Mail");
			this.hbox5.Add(this.label7);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label7]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.txtEmail = new global::Gtk.Entry();
			this.txtEmail.WidthRequest = 222;
			this.txtEmail.HeightRequest = 30;
			this.txtEmail.CanFocus = true;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.IsEditable = true;
			this.txtEmail.InvisibleChar = '•';
			this.hbox5.Add(this.txtEmail);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.txtEmail]));
			w15.Position = 1;
			this.fixed2.Add(this.hbox5);
			global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.hbox5]));
			w16.X = 46;
			w16.Y = 215;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Telefono");
			this.hbox6.Add(this.label8);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.label8]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.txtTelefono = new global::Gtk.Entry();
			this.txtTelefono.WidthRequest = 222;
			this.txtTelefono.HeightRequest = 30;
			this.txtTelefono.CanFocus = true;
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.IsEditable = true;
			this.txtTelefono.InvisibleChar = '•';
			this.hbox6.Add(this.txtTelefono);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.txtTelefono]));
			w18.Position = 1;
			this.fixed2.Add(this.hbox6);
			global::Gtk.Fixed.FixedChild w19 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.hbox6]));
			w19.X = 15;
			w19.Y = 254;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Direccion");
			this.hbox7.Add(this.label9);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.label9]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.txtDireccion = new global::Gtk.Entry();
			this.txtDireccion.WidthRequest = 222;
			this.txtDireccion.HeightRequest = 30;
			this.txtDireccion.CanFocus = true;
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.IsEditable = true;
			this.txtDireccion.InvisibleChar = '•';
			this.hbox7.Add(this.txtDireccion);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.txtDireccion]));
			w21.Position = 1;
			this.fixed2.Add(this.hbox7);
			global::Gtk.Fixed.FixedChild w22 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.hbox7]));
			w22.X = 11;
			w22.Y = 295;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Estado");
			this.hbox8.Add(this.label10);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.label10]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.txtEstado = new global::Gtk.Entry();
			this.txtEstado.WidthRequest = 100;
			this.txtEstado.HeightRequest = 30;
			this.txtEstado.CanFocus = true;
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.IsEditable = true;
			this.txtEstado.InvisibleChar = '•';
			this.hbox8.Add(this.txtEstado);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.txtEstado]));
			w24.Position = 1;
			this.fixed2.Add(this.hbox8);
			global::Gtk.Fixed.FixedChild w25 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.hbox8]));
			w25.X = 25;
			w25.Y = 333;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.hbox9 = new global::Gtk.HBox();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Cargo");
			this.hbox9.Add(this.label5);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.label5]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.cbxCargo = global::Gtk.ComboBox.NewText();
			this.cbxCargo.Name = "cbxCargo";
			this.hbox9.Add(this.cbxCargo);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.cbxCargo]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			this.fixed2.Add(this.hbox9);
			global::Gtk.Fixed.FixedChild w28 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.hbox9]));
			w28.X = 35;
			w28.Y = 373;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.hbox10 = new global::Gtk.HBox();
			this.hbox10.Name = "hbox10";
			this.hbox10.Spacing = 6;
			// Container child hbox10.Gtk.Box+BoxChild
			this.btnAgregar = new global::Gtk.Button();
			this.btnAgregar.CanFocus = true;
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.UseUnderline = true;
			this.btnAgregar.Label = global::Mono.Unix.Catalog.GetString("Agregar");
			this.hbox10.Add(this.btnAgregar);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.btnAgregar]));
			w29.Position = 0;
			w29.Expand = false;
			w29.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.btnEliminar = new global::Gtk.Button();
			this.btnEliminar.CanFocus = true;
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.UseUnderline = true;
			this.btnEliminar.Label = global::Mono.Unix.Catalog.GetString("Eliminar");
			this.hbox10.Add(this.btnEliminar);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.btnEliminar]));
			w30.Position = 1;
			w30.Expand = false;
			w30.Fill = false;
			this.fixed2.Add(this.hbox10);
			global::Gtk.Fixed.FixedChild w31 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.hbox10]));
			w31.X = 17;
			w31.Y = 413;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.hbox13 = new global::Gtk.HBox();
			this.hbox13.Name = "hbox13";
			this.hbox13.Spacing = 6;
			// Container child hbox13.Gtk.Box+BoxChild
			this.btnModificar = new global::Gtk.Button();
			this.btnModificar.CanFocus = true;
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.UseUnderline = true;
			this.btnModificar.Label = global::Mono.Unix.Catalog.GetString("Modificar");
			this.hbox13.Add(this.btnModificar);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.btnModificar]));
			w32.Position = 0;
			w32.Expand = false;
			w32.Fill = false;
			// Container child hbox13.Gtk.Box+BoxChild
			this.btnRegresar = new global::Gtk.Button();
			this.btnRegresar.CanFocus = true;
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.UseUnderline = true;
			this.btnRegresar.Label = global::Mono.Unix.Catalog.GetString("Regresar");
			this.hbox13.Add(this.btnRegresar);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.btnRegresar]));
			w33.Position = 1;
			w33.Expand = false;
			w33.Fill = false;
			this.fixed2.Add(this.hbox13);
			global::Gtk.Fixed.FixedChild w34 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.hbox13]));
			w34.X = 163;
			w34.Y = 413;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Bienvenido a registro de empleados!");
			this.vbox1.Add(this.label11);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label11]));
			w35.Position = 0;
			w35.Expand = false;
			w35.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow1.WidthRequest = 800;
			this.scrolledwindow1.HeightRequest = 304;
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.TvListaEmpleado = new global::Gtk.TreeView();
			this.TvListaEmpleado.CanFocus = true;
			this.TvListaEmpleado.Name = "TvListaEmpleado";
			this.scrolledwindow1.Add(this.TvListaEmpleado);
			this.vbox1.Add(this.scrolledwindow1);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.scrolledwindow1]));
			w37.Position = 1;
			this.fixed2.Add(this.vbox1);
			global::Gtk.Fixed.FixedChild w38 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.vbox1]));
			w38.X = 319;
			w38.Y = 62;
			this.Add(this.fixed2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 1144;
			this.DefaultHeight = 458;
			this.txtId.Hide();
			this.Show();
			this.btnBuscar.Clicked += new global::System.EventHandler(this.OnBtnBuscarClicked);
			this.btnAgregar.Clicked += new global::System.EventHandler(this.OnBtnAgregarClicked);
			this.btnEliminar.Clicked += new global::System.EventHandler(this.OnButton9Clicked);
			this.btnModificar.Clicked += new global::System.EventHandler(this.OnButton10Clicked);
			this.btnRegresar.Clicked += new global::System.EventHandler(this.OnButton11Clicked);
			this.TvListaEmpleado.CursorChanged += new global::System.EventHandler(this.OnTvListaEmpleadoCursorChanged);
		}
	}
}
