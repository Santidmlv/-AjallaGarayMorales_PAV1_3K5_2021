using System;
using System.Collections.Generic;
using System.Text;
using TP_Grupo5.Entities;
using System.Data;
namespace TP_Grupo5.DataAccesLayer
{
    public class BarrioDao
    {
        public IList<Barrio> getAll()
        {
            List<Barrio> listaBarrio = new List<Barrio>();

            string consulta = string.Concat("SELECT ",
                                            "b.id_barrio,",
                                            "b.nombre as barrio,",
                                            "b.borrado",
                                            " FROM Barrios b",
                                            " ORDER BY b.nombre");
            var resConsulta = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            foreach (DataRow row in resConsulta.Rows)
            {
                listaBarrio.Add(ObjectMapping(row));
            }
            return listaBarrio;
        }

        private Barrio ObjectMapping(DataRow row)
        {
            Barrio oBarrio = new Barrio
            {
                Id_Barrio = Convert.ToInt32(row["id_barrio"].ToString()),
                Nombre = row["barrio"].ToString(),
                Borrado = Convert.ToBoolean(row["borrado"].ToString())
            };
            return oBarrio;
        }

        public IList<Barrio> consultWithFilter(string filtro)
        {
            List<Barrio> listaBarrios = new List<Barrio>();

            string consulta = string.Concat("SELECT ",
                                            "b.id_barrio,",
                                            "b.nombre as barrio,",
                                            "b.borrado",
                                            " FROM Barrios b");

            consulta = consulta +" WHERE "+ filtro+ " ORDER BY b.nombre";
            var resConsulta = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            foreach (DataRow row in resConsulta.Rows)
            {
                listaBarrios.Add(ObjectMapping(row));
            }
            return listaBarrios;
        }

        public bool Create(Barrio barrio)
        {
            string consulta = "INSERT INTO Barrios(nombre,borrado)" +
                              " VALUES (" +
                              "'" + barrio.Nombre + "','0')";
            return (DBHelper.GetDBHelper().EjecutarSQL(consulta) == 1);
        }

        public bool Update(Barrio barrio)
        {
            string consulta = "UPDATE Barrios " +
                     "SET nombre='" + barrio.Nombre + "'" +
                     " WHERE id_barrio=" + barrio.Id_Barrio;
            return (DBHelper.GetDBHelper().EjecutarSQL(consulta) == 1);
        }

        public bool Delete(Barrio barrio)
        {
            string consulta = "UPDATE Barrios " +
                              "SET borrado=1" +
                              " WHERE id_barrio=" + barrio.Id_Barrio; 
            return (DBHelper.GetDBHelper().EjecutarSQL(consulta) == 1);
        }

        public bool Restored(Barrio barrio)
        {
            string consulta = "UPDATE Barrios " +
                              "SET borrado=0" +
                              " WHERE id_barrio=" + barrio.Id_Barrio;
            return (DBHelper.GetDBHelper().EjecutarSQL(consulta) == 1);
        }

        public bool EstaVinculado(int id_barrio)
        {
            string consulta = string.Concat("SELECT ",
                                "b.id_barrio,",
                                "b.nombre as barrio",
                                " FROM Barrios b",
                                " JOIN Clientes c",
                                " ON (b.id_barrio = c.id_barrio)",
                                " WHERE (" + id_barrio + " = c.id_barrio)",
                                " AND c.borrado = 0");
            var resConsulta = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            int cantidad = resConsulta.Rows.Count;
            if (cantidad == 0)
                return false;
            else
                return true;
        }

    }
}
