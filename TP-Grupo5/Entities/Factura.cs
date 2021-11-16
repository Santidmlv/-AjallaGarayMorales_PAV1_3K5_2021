using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Grupo5.Entities
{
    public class Factura
    {
        public int ID_factura { get; set; }
        public int NroFactura { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario Creador { get; set; }
        public IList<FacturaDetalle> Detalle { get; set; }
        public int Borrado { get; set; }
    }
}
