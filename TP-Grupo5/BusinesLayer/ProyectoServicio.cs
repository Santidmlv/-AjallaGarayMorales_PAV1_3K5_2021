using System;
using System.Collections.Generic;
using System.Text;
using TP_Grupo5.DataAccesLayer;
using TP_Grupo5.Entities;

namespace TP_Grupo5.BusinesLayer
{
    class ProyectoServicio
    {
        private ProyectoDao oProyectoDao;
        public ProyectoServicio()
        {
            oProyectoDao = new ProyectoDao();
        }
        public IList<Proyecto> ObtenerTodos()
        {
            return oProyectoDao.GetAll();
        }
        public Proyecto ObtenerProyectoPorID(String idProyecto)
        {
            return oProyectoDao.GetProyecto(idProyecto);
        }
        internal IList<Proyecto> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return oProyectoDao.GetByFiltersSinParametros(condiciones);
        }

        internal bool CrearProyecto(Proyecto oProyecto)
        {
            return oProyectoDao.Create(oProyecto);
        }

        internal bool ActualizarProyecto(Proyecto oProyecto)
        {
            return oProyectoDao.Update(oProyecto);
        }
        internal bool EliminarProyecto(Proyecto oProyecto)
        {
            return oProyectoDao.Delete(oProyecto);
        }
        public bool RestaurarProyecto(Proyecto oProyecto)
        {
            return oProyectoDao.Restore(oProyecto);
        }
        


    }
}
