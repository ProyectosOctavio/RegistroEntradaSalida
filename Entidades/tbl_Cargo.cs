namespace COntrolREyS.Properties
{
    public class tbl_Cargo
    {


        public int idCargo;
       private string nombreCargo;
        private int estadoCargo;
      private string descripcion;
        public int idDepartamento;

        public int IdCargo { get => idCargo; set => idCargo = value; }
        public string NombreCargo { get => nombreCargo; set => nombreCargo = value; }
        public int EstadoCargo { get => estadoCargo; set => estadoCargo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdDepartamento { get => idDepartamento; set => idDepartamento = value; }




        public tbl_Cargo()
        {
        }



    }
}


