using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TP_Grupo5.Entities;

namespace TP_Grupo5.DataAccesLayer
{
    public class ClienteDao
    {
        public IList<Cliente> getAll()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            string consulta = string.Concat(" SELECT ",
                                            "c.id_cliente, ",
                                            "c.razon_social, ",
                                            "c.cuit, ",
                                            "c.fecha_alta, ",
                                            "c.calle, ",
                                            "c.numero, ",
                                            "c.borrado, ",
                                            "b.id_barrio, ",
                                            "b.nombre AS barrio, ",
                                            "cont.id_contacto, ",
                                            "cont.nombre, ",
                                            "cont.apellido, ",
                                            "cont.email, ",
                                            "cont.telefono ",
                                            " FROM Clientes c ",
                                            " INNER JOIN Barrios b ON (c.id_barrio=b.id_barrio) left JOIN Contactos cont ON (cont.id_contacto=c.id_contacto) ",
                                            " WHERE C.borrado=0",
                                            " ORDER BY c.razon_social");

            var resConsulta=DBHelper.GetDBHelper().ConsultaSQL(consulta);
            foreach (DataRow row in resConsulta.Rows)
            {
                listaClientes.Add(ObjectMapping(row));
            }
            return listaClientes;
        }

        public Cliente ClienteForId(string id)
        {
            string consulta = string.Concat("SELECT ",
                                            "c.id_cliente, ",
                                            "c.razon_social, ",
                                            "c.cuit, ",
                                            "c.fecha_alta, ",
                                            "c.calle, ",
                                            "c.numero, ",
                                            "c.borrado, ",
                                            "b.id_barrio, ",
                                            "b.nombre AS barrio, ",
                                            "cont.id_contacto, ",
                                            "cont.nombre, ",
                                            "cont.apellido, ",
                                            "cont.email, ",
                                            "cont.telefono ",
                                            " FROM Clientes c INNER JOIN Barrios b ON (c.id_barrio=b.id_barrio) left JOIN Contactos cont ON (cont.id_contacto=c.id_contacto)",
                                            " WHERE c.id_cliente=");
            consulta = consulta + id;
            var resConsulta = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            return ObjectMapping(resConsulta.Rows[0]);
        }

        public IList<Cliente> consultWithFilter(string filtro)
        {
            List<Cliente> listaClientes = new List<Cliente>();

            string consulta = string.Concat(" SELECT ",
                                            "c.id_cliente, ",
                                            "c.razon_social, ",
                                            "c.cuit, ",
                                            "c.fecha_alta, ",
                                            "c.calle, ",
                                            "c.numero, ",
                                            "c.borrado, ",
                                            "b.id_barrio, ",
                                            "b.nombre AS barrio, ",
                                            "cont.id_contacto, ",
                                            "cont.nombre, ",
                                            "cont.apellido, ",
                                            "cont.email, ",
                                            "cont.telefono ",
                                            " FROM Clientes c ",
                                            " INNER JOIN Barrios b ON (c.id_barrio=b.id_barrio) left JOIN Contactos cont ON (cont.id_contacto=c.id_contacto) ");

            consulta = consulta + " WHERE " + filtro+ " ORDER BY c.razon_social";
            var resConsulta = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            foreach (DataRow row in resConsulta.Rows)
            {
                listaClientes.Add(ObjectMapping(row));
            }
            return listaClientes;
        }

        private Cliente ObjectMapping(DataRow row)
        {
            Cliente oCliente = new Cliente
            {
                Id_cliente = Convert.ToInt32(row["id_cliente"].ToString()),
                Razon_social = row["razon_social"].ToString(),
                Cuit = Convert.ToInt32(row["cuit"].ToString()),
                Fecha_alta = Convert.ToDateTime(row["fecha_alta"].ToString()),
                Calle = row["calle"].ToString(),
                Barrio = new Barrio
                {
                    Id_Barrio = Convert.ToInt32(row["id_barrio"].ToString()),
                    Nombre = row["barrio"].ToString()
                },
                Borrado = Convert.ToBoolean(row["borrado"].ToString())
                
            };
            if (row["numero"].ToString() != "")
                oCliente.Numero = row["numero"].ToString();
            if (row["id_contacto"].ToString() != "")
            {
                oCliente.Contacto = new Contacto
                {
                    Id_Contacto = Convert.ToInt32(row["id_contacto"].ToString()),
                    Nombre = row["nombre"].ToString(),
                    Apellido = row["apellido"].ToString(),
                    Email = row["email"].ToString(),
                    Telefono = row["telefono"].ToString()
                };
            }
            return oCliente;
        }

        public bool Create(Cliente cliente)
        {
            string contacto="NULL";
            if (cliente.Contacto != null)
                contacto = cliente.Contacto.Id_Contacto.ToString();
            string nroCalle = "NULL";
            if (cliente.Numero !=null)
                nroCalle = cliente.Numero;

            string consulta = "INSERT INTO Clientes(cuit,razon_social,calle,numero,fecha_alta,id_barrio,id_contacto,borrado)" +
                              " VALUES (" +
                              "'" + cliente.Cuit + "'," +
                              "'" + cliente.Razon_social + "'," +
                              "'" + cliente.Calle + "'," +
                              nroCalle + "," +
                              "GETDATE()," +
                              cliente.Barrio.Id_Barrio + "," +
                              contacto + ",0)";
            
            return (DBHelper.GetDBHelper().EjecutarSQL(consulta)==1);
        }

        public bool Update(Cliente cliente)
        {
            string contacto = "NULL";
            if (cliente.Contacto != null)
                contacto = cliente.Contacto.Id_Contacto.ToString();
            string nroCalle = "NULL";
            if (cliente.Numero != null)
                nroCalle = cliente.Numero;

            string consulta = "UPDATE Clientes " +
                     "SET cuit='" + cliente.Cuit + "'," +
                     "razon_social='" + cliente.Razon_social + "'," +
                     "calle='" + cliente.Calle + "'," +
                     "numero=" + nroCalle + "," +
                     "id_barrio="+cliente.Barrio.Id_Barrio+","+
                     "id_contacto="+contacto+
                     " WHERE id_cliente="+cliente.Id_cliente;
            return (DBHelper.GetDBHelper().EjecutarSQL(consulta) == 1);
        }

        public bool Delete(Cliente cliente)
        {
            string consulta = "UPDATE Clientes " +
                              "SET borrado=1" +
                              " WHERE id_cliente=" + cliente.Id_cliente;
            return (DBHelper.GetDBHelper().EjecutarSQL(consulta) == 1);
        }

        public bool Restored(Cliente cliente)
        {
            string consulta = "UPDATE Clientes " +
                              "SET borrado=0" +
                              " WHERE id_cliente=" + cliente.Id_cliente;
            return (DBHelper.GetDBHelper().EjecutarSQL(consulta) == 1);
        }
    }
}
