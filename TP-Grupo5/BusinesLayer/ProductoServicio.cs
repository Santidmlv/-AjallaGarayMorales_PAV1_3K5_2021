using System;
using System.Collections.Generic;
using System.Text;
using TP_Grupo5.DataAccesLayer;
using TP_Grupo5.Entities;

namespace TP_Grupo5.BusinesLayer
{
    class ProductoServicio
    {
        private ProductoDao oProductoDao;
        public ProductoServicio()
        {
            this.oProductoDao = new ProductoDao();
        }
        public IList<Producto> ObtenerTodos()
        {
            return oProductoDao.GetAll();
        }
        internal IList<Producto> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return oProductoDao.GetByFiltersSinParametros(condiciones);
        }
    }
}
