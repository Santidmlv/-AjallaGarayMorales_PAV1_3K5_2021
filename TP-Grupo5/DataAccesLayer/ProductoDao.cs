using System;
using System.Collections.Generic;
using System.Text;
using TP_Grupo5.Entities;
using System.Data;

namespace TP_Grupo5.DataAccesLayer
{
    public class ProductoDao
    {
        public IList<Producto> GetAll()
        {
            List<Producto> listaProducto = new List<Producto>();

            string consulta = string.Concat("SELECT ",
                                            "id_producto,",
                                            "nombre",
                                            " FROM Productos",
                                            " WHERE borrado = 0");
            var resConsulta = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            foreach (DataRow row in resConsulta.Rows)
            {
                listaProducto.Add(ObjectMapping(row));
            }
            return listaProducto;
        }

        private Producto ObjectMapping(DataRow row)
        {
            Producto oProducto = new Producto
            {
                Id_Producto = Convert.ToInt32(row["id_producto"].ToString()),
                Nombre = row["nombre"].ToString()
            };
            return oProducto;
        }

        public IList<Producto> GetByFiltersSinParametros(String condiciones)
        {
            List<Producto> lst = new List<Producto>();
            String consultaSQL = string.Concat(
                "SELECT id_producto, nombre" +
                " FROM Productos " +
                " WHERE borrado=0");

            consultaSQL += condiciones;

            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSQL);

            foreach (DataRow row in resultado.Rows)
            {
                lst.Add(ObjectMapping(row));
            }

            return lst;
        }
    }
}
