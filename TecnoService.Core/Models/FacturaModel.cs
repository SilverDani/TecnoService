using System;

namespace TecnoService.Core.Models
{
    public class FacturaModel
    {
        public int IDFactura { get; set; }
        public int IDInDis { get; set; }
        public decimal Monto { get; set; }
        public string DetalleArreglo { get; set; }
        public DateTime FechaRetiro { get; set; }
        public int IDTrabajador { get; set; }

        public InDisModel ingreso { get; set; }
        public TrabajadorModel Trabajador { get; set; }
    }
}
