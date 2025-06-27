using System.Collections.Generic;

namespace TecnoService.Core.Models
{
    public class ClienteModel
    {
        public int IDCliente {get;set;}
        public int IDPersona {get;set;}
        public string Telefono{get;set;}

        public PersonaModel Persona {get;set;}
        public ICollection<InDisModel> Ingreso{get;set;}
    }
}
