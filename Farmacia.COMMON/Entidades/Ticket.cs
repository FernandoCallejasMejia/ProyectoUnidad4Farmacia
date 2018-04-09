using System;
using System.Collections.Generic;
using System.Text;

namespace Farmacia.COMMON.Entidades
{
    public class Ticket:Base
    {
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float Total { get; set; }
        public DateTime FechaHoraVenta { get; set; }
        public List<Producto> ProductosVendidos { get; set; }
        public Empleado Vendedor { get; set; }
        public Cliente Comprador { get; set; }
        public float CalcularTotal()
        {
            float total;
            return total = Cantidad * Precio;
        }
    }
}
