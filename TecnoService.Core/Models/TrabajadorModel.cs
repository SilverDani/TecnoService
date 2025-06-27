using System;
using System.Collections.Generic;

namespace TecnoService.Core.Models
{
    public class TrabajadorModel
    {
        public int IDTrabajador{get;set;}
        public int IDPersona {get;set;}
        public string Email{get;set;}
        public string Telefono {get;set;}
        public DateTime FechaNacimiento {get;set;}

        public PersonaModel Persona {get;set;}
        public ICollection<FacturaModel> Facturas {get;set;}
    }
}
