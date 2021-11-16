using System;
using System.Collections.Generic;
using System.Text;
using TP_Grupo5.DataAccesLayer;
using TP_Grupo5.Entities;
namespace TP_Grupo5.BusinesLayer
{
    public class BarrioServicio
    {
        private BarrioDao oBarrioDao = new BarrioDao();

        public IList<Barrio> dameTodo()
        {
            return oBarrioDao.getAll();
        }
        public IList<Barrio> consultaConFiltros(string filtro)
        {
            return oBarrioDao.consultWithFilter(filtro);
        }
        public bool InsertarBarrio(Barrio barrio)
        {
            return oBarrioDao.Create(barrio);
        }
        public bool ActualizarBarrio(Barrio barrio)
        {
            return oBarrioDao.Update(barrio);
        }

        public bool EliminarBarrio(Barrio barrio)
        {
            return oBarrioDao.Delete(barrio);
        }

        public bool RestaurarBarrio(Barrio barrio)
        {
            return oBarrioDao.Restored(barrio);
        }
        public bool BarriosVinculadosConClientes(int id_barrio)
        {
            return oBarrioDao.EstaVinculado(id_barrio);
        }
    }
}
