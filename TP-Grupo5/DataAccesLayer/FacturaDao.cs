using System;
using System.Collections.Generic;
using System.Text;
using TP_Grupo5.Entities;
using System.Data;
using System.Data.SqlClient;

namespace TP_Grupo5.DataAccesLayer
{
    class FacturaDao
    {
        public IList<Factura> consultWithFilter(string filtro)
        {
            List<Factura> listaFactura = new List<Factura>();

            string consulta = string.Concat("SELECT ",
                                            "f.id_factura,",
                                            "f.numero_factura,",
                                            "f.fecha,f.id_cliente,",
                                            "c.razon_social,",
                                            "f.id_usuario_creador,",
                                            "u.usuario",
                                            " FROM Facturas f",
                                            " JOIN Clientes c on f.id_cliente=c.id_cliente",
                                            " JOIN Usuarios u on u.id_usuario=f.id_usuario_creador",
                                            " WHERE f.borrado = 0 ");
            consulta = consulta + filtro+ " ORDER BY f.fecha DESC";
            var resConsulta = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            foreach (DataRow row in resConsulta.Rows)
                listaFactura.Add(ObjectMapping(row));

            return listaFactura;
        }

        private Factura ObjectMapping(DataRow row)
        {
            Factura oFactura = new Factura
            {
                ID_factura = Convert.ToInt32(row["id_factura"].ToString()),
                NroFactura = Convert.ToInt32(row["numero_factura"].ToString()),
                Cliente = new Cliente {
                    Id_cliente = Convert.ToInt32(row["id_cliente"].ToString()),
                    Razon_social = row["razon_social"].ToString()
                },
                Fecha = Convert.ToDateTime(row["fecha"].ToString()),
                Creador = new Usuario
                {
                    Id_Usuario = Convert.ToInt32(row["id_usuario_creador"].ToString()),
                    Nombre = row["usuario"].ToString()
                }
            };
            return oFactura;
        }

        public bool Create(Factura factura)
        {
            SqlTransaction transaction = null;
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BugTracker;Integrated Security=True");

            bool flag = true;

            try
            {
                cnn.Open();
                transaction = cnn.BeginTransaction();

                SqlCommand cmdNFactura = new SqlCommand("SELECT MAX(CONVERT(int,f.numero_factura)) FROM Facturas f", cnn, transaction);
                string NroFactura = cmdNFactura.ExecuteScalar().ToString();
                if (NroFactura == string.Empty)
                    NroFactura ="0";

                SqlCommand cmdMaestro = new SqlCommand("INSERT INTO Facturas(numero_factura,id_cliente,fecha,id_usuario_creador,borrado) VALUES(@numfactura,@id_cliente,@fecha,@id_creador,0)", cnn, transaction);
                cmdMaestro.Parameters.AddWithValue("@numfactura", Convert.ToInt32(NroFactura) + 1);
                cmdMaestro.Parameters.AddWithValue("@id_cliente", factura.Cliente.Id_cliente);
                cmdMaestro.Parameters.AddWithValue("@fecha", DateTime.Today);
                cmdMaestro.Parameters.AddWithValue("@id_creador", factura.Creador.Id_Usuario);

                cmdMaestro.ExecuteNonQuery();

                SqlCommand cmdAux = new SqlCommand("SELECT @@IDENTITY", cnn, transaction);
                int idFactura = Convert.ToInt32(cmdAux.ExecuteScalar().ToString());

                for (int i = 0; i < factura.Detalle.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO FacturasDetalle(id_factura,numero_orden,id_proyecto,id_producto,precio,borrado) VALUES(@id_factura,@numOrden,@id_proyecto,@id_producto,@precio,0)",cnn,transaction);
                    cmd.Parameters.AddWithValue("@id_factura", idFactura);
                    cmd.Parameters.AddWithValue("@numOrden", i + 1);
                    if (factura.Detalle[i].Proyecto != null)
                    {
                        cmd.Parameters.AddWithValue("@id_proyecto", factura.Detalle[i].Proyecto.Id_proyecto);
                        cmd.Parameters.AddWithValue("@id_producto", DBNull.Value);
                    }
                    if(factura.Detalle[i].Producto != null)
                    {
                        cmd.Parameters.AddWithValue("@id_proyecto", DBNull.Value);
                        cmd.Parameters.AddWithValue("@id_producto", factura.Detalle[i].Producto.Id_Producto);
                    }
                    cmd.Parameters.AddWithValue("@precio", factura.Detalle[i].precio);
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
            }

            catch (SqlException)
            {
                transaction.Rollback();
                flag = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return flag;
        }




    }
}
