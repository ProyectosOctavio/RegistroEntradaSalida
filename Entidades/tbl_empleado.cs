using System;
namespace COntrolREyS.Properties
{
    public class tbl_empleado
    {


        public int id_empleado;
        private string cedula;
        private string nombre;
        private string apellido;
        private string telefono;
        private string email;
        private string direccion;
        private int estadoEmpleado;
        public int id_cargo;


        public string Cedula{ get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int EstadoEmpleado { get => estadoEmpleado; set => estadoEmpleado = value; }
        public int IdCargo { get => id_cargo; set => id_cargo = value; }


        public tbl_empleado()
        {  
        }


    }
}
