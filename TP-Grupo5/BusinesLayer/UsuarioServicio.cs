using System;
using System.Collections.Generic;
using System.Text;
using TP_Grupo5.DataAccesLayer;
using TP_Grupo5.Entities;
namespace TP_Grupo5.BusinesLayer
{
    public class UsuarioServicio
    {
        private UsuarioDao oUsuarioDao;
        public UsuarioServicio()
        {
            oUsuarioDao = new UsuarioDao();
        }
        public IList<Usuario> ObtenerTodos()
        {
            return oUsuarioDao.GetAll();
        }
    }
}
