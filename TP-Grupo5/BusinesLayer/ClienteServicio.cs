using System;
using System.Collections.Generic;
using System.Text;
using TP_Grupo5.DataAccesLayer;
using TP_Grupo5.Entities;

namespace TP_Grupo5.BusinesLayer
{
    public class ClienteServicio
    {
        private ClienteDao oClienteDao = new ClienteDao();

        public IList<Cliente> dameTodo()
        {
            return oClienteDao.getAll();
        }

        public IList<Cliente> consultaConFiltros(string filtro)
        {
            return oClienteDao.consultWithFilter(filtro);
        }

        public bool InsertarCliente(Cliente cliente)
        {
            return oClienteDao.Create(cliente);
        }

        public bool ActualizarCliente(Cliente cliente)
        {
            return oClienteDao.Update(cliente);
        }

        public bool EliminarCliente(Cliente cliente)
        {
            return oClienteDao.Delete(cliente);
        }

        public bool RecuperarCliente(Cliente cliente)
        {
            return oClienteDao.Restored(cliente);
        }

        public Cliente ClientePorId(string id)
        {
            return oClienteDao.ClienteForId(id);
        }
    }
}
