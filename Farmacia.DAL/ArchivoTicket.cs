using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Farmacia.DAL
{
    public class ArchivoTicket
    {
        public bool GenerarTicket(string nombreCliente, string datos, float precioVenta, int cantidad, float totalVenta, string empleado, string ruta)
        {
            try
            {
                StreamWriter archivo = new StreamWriter(ruta);
                archivo.WriteLine("\tMi Querido Enfermito");
                archivo.WriteLine("Fecha: " + DateTime.Now.ToLongDateString());
                archivo.WriteLine("Hora: " + DateTime.Now.ToLongTimeString());
                archivo.WriteLine("Empleado: " + empleado);
                archivo.WriteLine("Cliente: " + nombreCliente);
                archivo.WriteLine("\nCantidad\tProducto\tPrecio");
                archivo.Write("" + cantidad);
                archivo.Write("\t\t" + datos);
                archivo.WriteLine("\n");
                archivo.WriteLine("Total: $" + totalVenta);
                archivo.WriteLine("\tGRACIAS POR SU COMPRA");
                archivo.Close();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}