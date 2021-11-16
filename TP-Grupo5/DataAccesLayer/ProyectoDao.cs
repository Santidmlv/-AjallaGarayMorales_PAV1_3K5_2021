using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TP_Grupo5.Entities;

namespace TP_Grupo5.DataAccesLayer
{
    public class ProyectoDao
    {
        public IList<Proyecto> GetAll()
        {
            List<Proyecto> lst = new List<Proyecto>();
            String consultaSQL = string.Concat(
                "SELECT py.id_proyecto,py.id_producto,py.descripcion,py.version,py.alcance,py.id_responsable,py.borrado,pd.id_producto,pd.nombre as producto,u.id_usuario,u.usuario as responsable" +
                " FROM Proyectos py,Productos pd ,Usuarios u" +
                " WHERE py.id_producto=pd.id_producto and py.id_responsable=u.id_usuario ORDER BY py.descripcion");

            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSQL);

            foreach (DataRow row in resultado.Rows)
            {
                lst.Add(ObjectMapping(row));
            }
            return lst;
        }

        private Proyecto ObjectMapping(DataRow row)
        {
            Proyecto oProyecto = new Proyecto
            {
                Id_proyecto = Convert.ToInt32(row["id_proyecto"].ToString()),
                Descripcion = row["descripcion"].ToString(),
                Version = row["version"].ToString(),
                Alcance = row["alcance"].ToString(),
                Borrado = Convert.ToInt32(row["borrado"].ToString()),
                Producto = new Producto()
                {
                    Id_Producto = Convert.ToInt32(row["id_producto"].ToString()),
                    Nombre = row["producto"].ToString(),
                },
                Responsable = new Usuario()
                {
                    Id_Usuario = Convert.ToInt32(row["id_usuario"].ToString()),
                    Nombre = row["responsable"].ToString(),
                }
            };
            return oProyecto;
        }
        public Proyecto GetProyecto(string idProyecto)
        {
            String consultaSQL = string.Concat(
                "SELECT py.id_proyecto,py.id_producto,py.descripcion,py.version,py.alcance,py.id_responsable,py.borrado,pd.id_producto,pd.nombre as producto,u.id_usuario,u.usuario as responsable" +
                " FROM Proyectos py,Productos pd ,Usuarios u" +
                " WHERE py.id_producto=pd.id_producto and py.id_responsable=u.id_usuario ");

            consultaSQL += " AND py.id_proyecto=" + "'" + idProyecto + "'";

            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSQL);

            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }
            return null;
        }


        public bool Create(Proyecto oProyecto)
        {
            //La base de datos tiene id_proyecto autoincremental
            string consultaSQL = "INSERT INTO Proyectos (id_producto,descripcion,version,alcance,id_responsable,borrado)" +
                                " VALUES (" +
                                oProyecto.Producto.Id_Producto + ",'" +
                                oProyecto.Descripcion + "','" +
                                oProyecto.Version + "','" +
                                oProyecto.Alcance + "'," +
                                oProyecto.Responsable.Id_Usuario + ",'0')";
            return (DBHelper.GetDBHelper().EjecutarSQL(consultaSQL) == 1);
        }

        public bool Update(Proyecto oProyecto)
        {
            string consultaSQL = "UPDATE Proyectos" +
                                " SET id_producto = " + oProyecto.Producto.Id_Producto + "," +
                                "descripcion = '" + oProyecto.Descripcion + "'," +
                                "version = '" + oProyecto.Version + "'," +
                                "alcance = '" + oProyecto.Alcance + "'," +
                                "id_responsable = " + oProyecto.Responsable.Id_Usuario +
                                " WHERE id_proyecto = " + oProyecto.Id_proyecto + " AND borrado = '0'";
            return (DBHelper.GetDBHelper().EjecutarSQL(consultaSQL) == 1);
        }

        public bool Delete(Proyecto oProyecto)
        {
            string consultaSQL = "UPDATE Proyectos" +
                                " set borrado='1'" +
                                " where id_proyecto = " + oProyecto.Id_proyecto + " AND borrado = '0'";
            return (DBHelper.GetDBHelper().EjecutarSQL(consultaSQL) == 1);
        }

        public bool Restore(Proyecto oProyecto)
        {
            string consultaSQL = "UPDATE Proyectos" +
                                " set borrado='0'" +
                                " where id_proyecto = " + oProyecto.Id_proyecto + " AND borrado = '1'";
            return (DBHelper.GetDBHelper().EjecutarSQL(consultaSQL) == 1);
        }

        public IList<Proyecto> GetByFiltersSinParametros(String condiciones)
        {
            List<Proyecto> lst = new List<Proyecto>();
            String consultaSQL = string.Concat(
                "SELECT py.id_proyecto,py.id_producto,py.descripcion,py.version,py.alcance,py.id_responsable,py.borrado,pd.id_producto,pd.nombre as producto,u.id_usuario,u.usuario as responsable" +
                " FROM Proyectos py,Productos pd ,Usuarios u" +
                " WHERE py.id_producto=pd.id_producto AND py.id_responsable=u.id_usuario ");

            consultaSQL += condiciones+ " ORDER BY py.descripcion";

            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSQL);

            foreach (DataRow row in resultado.Rows)
            {
                lst.Add(ObjectMapping(row));
            }

            return lst;
        }

    }
}
