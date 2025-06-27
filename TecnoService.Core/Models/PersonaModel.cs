namespace TecnoService.Core.Models
{
    public class PersonaModel
    {
        public int IDPersona{get;set;}
        public string nombre{get;set;}
        public string Apellido{get;set;}
        public string Documento{ get; set; }

        public ClienteModel Cleinte{get;set;}
        public TrabajadorModel Trabajador{get;set;}
    }
}
