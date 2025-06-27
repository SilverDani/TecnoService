using System.Collections.Generic;

namespace TecnoService.Core.Models
{
    public class DispositivoModel
    {
        public int IDDispositivo { get; set; }
        public int IDMarca { get; set; }
        public string Modelo { get; set; }

        public MarcaModel Marca { get; set; }
        public ICollection<InDisModel> Ingreso{get;set;}
    }
}
