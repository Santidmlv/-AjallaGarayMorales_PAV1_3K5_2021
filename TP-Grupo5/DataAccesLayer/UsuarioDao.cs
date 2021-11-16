using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TP_Grupo5.Entities;
namespace TP_Grupo5.DataAccesLayer
{
    public class UsuarioDao
    {
        public IList<Usuario> GetAll()
        {
            List<Usuario> listadoBugs = new List<Usuario>();

            var strSql = "SELECT * From Usuarios WHERE borrado=0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(ObjectMapping(row));
            }
            return listadoBugs;
        }

        private Usuario ObjectMapping(DataRow row)
        {
            Usuario oUsuario = new Usuario
            {
                Id_Usuario = Convert.ToInt32(row["id_usuario"].ToString()),
                Nombre = row["usuario"].ToString()
            };
            return oUsuario;
        }
    }
}
