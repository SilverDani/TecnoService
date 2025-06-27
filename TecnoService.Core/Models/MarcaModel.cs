using System.Collections.Generic;

namespace TecnoService.Core.Models
{
    public class MarcaModel
    {
        public int IDMarca { get; set; }
        public string Nombre { get; set; }

        public ICollection<DispositivoModel> Dispositivos { get; set; }
    }
}
