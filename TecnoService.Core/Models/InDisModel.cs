using System;

namespace TecnoService.Core.Models
{
    public class InDisModel
    {
        public int IDInDis { get; set; }
        public int IDDispositivo { get; set; }
        public int IDCliente { get; set; }
        public DateTime FechaIngreso { get; set; }

        public DispositivoModel Dispositivo { get; set; }
        public ClienteModel Cliente { get; set; }
        public FacturaModel Factura { get; set; }
        
    }
}
