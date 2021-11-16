using System;
using System.Collections.Generic;
using System.Text;
using TP_Grupo5.DataAccesLayer;
using TP_Grupo5.Entities;

namespace TP_Grupo5.BusinesLayer
{
    public class ContactoServicio
    {
        private ContactoDao oContactoDao = new ContactoDao();
        public IList<Contacto> dameTodo()
        {
            return oContactoDao.getAll();
        }
        public IList<Contacto> consultaConFiltros(string filtro)
        {
            return oContactoDao.consultWithFilter(filtro);
        }

        public bool InsertarContacto(Contacto contacto)
        {
            return oContactoDao.Create(contacto);
        }

        public bool ActualizarContacto(Contacto contacto)
        {
            return oContactoDao.Update(contacto);
        }

        public bool EliminarContacto(Contacto contacto)
        {
            return oContactoDao.Delete(contacto);
        }
        public bool RecuperarContacto(Contacto contacto)
        {
            return oContactoDao.Restore(contacto);
        }
        public Contacto ContactoPorId(string id)
        {
            return oContactoDao.ContactoForId(id);
        }
        public bool ContactosVinculadosConClientes(int id_contacto)
        {
            return oContactoDao.EstaVinculado(id_contacto);
        }
    }
    

}
