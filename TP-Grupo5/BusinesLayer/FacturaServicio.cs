using System;
using System.Collections.Generic;
using System.Text;
using TP_Grupo5.Entities;
using TP_Grupo5.DataAccesLayer;
namespace TP_Grupo5.BusinesLayer
{
    public class FacturaServicio
    {
        FacturaDao oFacturaDao = new FacturaDao();
        public bool InsertarFactura(Factura factura)
        {
            return oFacturaDao.Create(factura);
        }

        public IList<Factura> consulultaConFiltros(string filtro)
        {
            return oFacturaDao.consultWithFilter(filtro);
        }

    }
}
