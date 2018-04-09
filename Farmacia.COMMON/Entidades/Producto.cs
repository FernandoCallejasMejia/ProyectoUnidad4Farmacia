using System;
using System.Collections.Generic;
using System.Text;

namespace Farmacia.COMMON.Entidades
{
    public class Producto:Base
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string PrecioCompra { get; set; }
        public string PrecioVenta { get; set; }
        public string Presentacion { get; set; }
        public override string ToString()
        {
            return string.Format("{0} ${1}", Nombre, PrecioVenta);
        }
    }
}
