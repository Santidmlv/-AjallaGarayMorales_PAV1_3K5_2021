using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Grupo5.Entities
{
    public class FacturaDetalle
    {
        public int Id_FacturaDetalle { get; set; }
        public Factura Factura { get; set; }
        public int NroOrden{ get; set; }
        public Producto Producto { get; set; }
        public Proyecto Proyecto { get; set; }
        public double precio { get; set; }
        public int Borrado { get; set; }
    }
}
