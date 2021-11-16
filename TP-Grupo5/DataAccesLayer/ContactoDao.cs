using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TP_Grupo5.Entities;

namespace TP_Grupo5.DataAccesLayer
{
    public class ContactoDao
    {
        public IList<Contacto> getAll()
        {
            List<Contacto> listaCliente = new List<Contacto>();
            string consulta = string.Concat(" SELECT ",
                                            "c.id_contacto,",
                                            "c.apellido,",
                                            "c.email,",
                                            "c.nombre,",
                                            "c.telefono,",
                                            "c.borrado",
                                            " FROM Contactos c ",
                                            " WHERE (c.borrado=0 OR c.borrado=1)",
                                            " ORDER BY c.apellido");
            var resConsulta=DBHelper.GetDBHelper().ConsultaSQL(consulta);
            foreach (DataRow row in resConsulta.Rows)
            {
                listaCliente.Add(ObjectMapping(row));
            }
            return listaCliente;
        }

        public Contacto ContactoForId(string id)
        {
            string consulta = string.Concat(" SELECT ",
                                            "c.id_contacto,",
                                            "c.apellido,",
                                            "c.email,",
                                            "c.nombre,",
                                            "c.telefono,",
                                            "c.borrado",
                                            " FROM Contactos c",
                                            " WHERE c.id_contacto=");
            consulta = consulta + id;
            var resConsulta = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return ObjectMapping(resConsulta.Rows[0]);
        }

        public IList<Contacto> consultWithFilter(string filtro)
        {
            List<Contacto> listaCliente = new List<Contacto>();
            string consulta = string.Concat(" SELECT ",
                                            "c.id_contacto,",
                                            "c.apellido,",
                                            "c.email,",
                                            "c.nombre,",
                                            "c.telefono,",
                                            "c.borrado",
                                            " FROM Contactos c ");
            consulta = consulta + " WHERE " + filtro + " ORDER BY c.apellido";
            var resConsulta = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            foreach (DataRow row in resConsulta.Rows)
            {
                listaCliente.Add(ObjectMapping(row));
            }
            return listaCliente;
        }

        public Contacto ObjectMapping(DataRow row)
        {
            Contacto oContacto = new Contacto
            {
                Id_Contacto = Convert.ToInt32(row["id_contacto"].ToString()),
                Apellido = row["apellido"].ToString(),
                Email = row["email"].ToString(),
                Nombre= row["nombre"].ToString(),
                Telefono=row["telefono"].ToString(),
                Borrado = Convert.ToBoolean(row["borrado"].ToString())
            };
            return oContacto;
        }
        public bool Create(Contacto contacto)
        {

            string consulta = "INSERT INTO Contactos(nombre,apellido,email,telefono,borrado)" +
                            " VALUES (" +
                            "'" + contacto.Nombre + "'," +
                            "'" + contacto.Apellido + "'," +
                            "'" + contacto.Email + "'," +
                            "'" + contacto.Telefono + "'," +
                            "0)";

            return (DBHelper.GetDBHelper().EjecutarSQL(consulta) == 1);
        }

        public bool Update(Contacto contacto)
        {
            string consulta = "UPDATE Contactos" +
                                " SET " +
                                "nombre='" + contacto.Nombre + "'," +
                                "apellido='" + contacto.Apellido + "'," +
                                "email='" + contacto.Email + "'," +
                                "telefono='" + contacto.Telefono + "'" +
                               " WHERE id_contacto=" + contacto.Id_Contacto;
            return (DBHelper.GetDBHelper().EjecutarSQL(consulta) == 1);
        }

        public bool Delete(Contacto contacto)
        {
            string consulta = "UPDATE Contactos " +
                              "SET borrado=1" +
                              " WHERE id_contacto=" + contacto.Id_Contacto;
            return (DBHelper.GetDBHelper().EjecutarSQL(consulta) == 1);
        }
        public bool EstaVinculado(int id_contacto)
        {
            string consulta = string.Concat(" SELECT ",
                                            "c.id_contacto,",
                                            "c.apellido,",
                                            "c.email,",
                                            "c.nombre,",
                                            "c.telefono,",
                                            "c.borrado",
                                            " FROM Contactos c",
                                            " JOIN Clientes cli",
                                            " ON (c.id_contacto = cli.id_contacto)",
                                            " WHERE (" + id_contacto + " = cli.id_contacto)",
                                            " AND cli.borrado = 0");
            var resConsulta = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            int cantidad = resConsulta.Rows.Count;
            if (cantidad == 0)
                return false;
            else
                return true;
        }

        public bool Restore(Contacto contacto)
        {
            string consulta = "UPDATE Contactos " +
                              "SET borrado=0" +
                              " WHERE id_contacto=" + contacto.Id_Contacto;
            return (DBHelper.GetDBHelper().EjecutarSQL(consulta) == 1);
        }
    }
}
