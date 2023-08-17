using System;
namespace COntrolREyS.Properties
{
    public class tbl_Asistencia
    {

        public int id_registro;
        private string horasMarcadas;
        private string nombre;
        private string cedula;
        private string tipoDeMarca;


        public string HorasMarcadas { get => horasMarcadas; set => horasMarcadas =  value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cedula{ get => cedula; set => cedula = value; }
        public string TipoDeMarca { get => tipoDeMarca; set => tipoDeMarca = value; }



        public tbl_Asistencia(int id_registro, int id_empleado)
        {
        }

        public tbl_Asistencia()
        {
        }
    }
}
