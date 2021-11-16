using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TP_Grupo5.Entities;

namespace TP_Grupo5.DataAccesLayer
{
    public class ReportesDao
    {
        //facturacion
        public DataTable consultFacturaReport(string filtro)
        {
            string consulta = string.Concat("SELECT ",
                                            "f.numero_factura 'NroFactura',",
                                            "f.Fecha,",
                                            "c.razon_social 'Cliente',",
                                            "sum(fd.precio) as 'TOTAL'",
                                            " FROM Facturas f ",
                                            " JOIN Clientes c ON f.id_cliente=c.id_cliente ",
                                            " JOIN Usuarios u ON u.id_usuario=f.id_usuario_creador",
                                            " JOIN FacturasDetalle fd ON f.id_factura=fd.id_factura",
                                            " WHERE f.borrado=0");
            consulta = consulta + filtro+ " GROUP BY f.numero_factura,f.fecha,c.razon_social,u.usuario ORDER BY CONVERT(int,f.numero_factura) desc";
            return DBHelper.GetDBHelper().ConsultaSQL(consulta);
        }

        //relacion entre la cantidad y el proyecto/producto vendido
        public DataTable consultDetalleCant(string filtro)
        {
            string consulta = string.Concat("SELECT ",
                                            "CONCAT_WS('',py.descripcion,p.nombre)'Descripcion',",
                                            "COUNT(CONCAT_WS('',fd.id_proyecto,fd.id_producto))'Cantidad'",
                                            " FROM FacturasDetalle fd",
                                            " LEFT JOIN Proyectos py ON fd.id_proyecto=py.id_proyecto",
                                            " LEFT JOIN Productos p ON fd.id_producto=p.id_producto",
                                            " JOIN Facturas f on f.id_factura=fd.id_factura",
                                            " WHERE fd.borrado = 0");
            consulta = consulta + filtro + " GROUP BY py.descripcion,p.nombre ORDER BY COUNT(CONCAT_WS('',fd.id_proyecto,fd.id_producto)) DESC";
            return DBHelper.GetDBHelper().ConsultaSQL(consulta);
        }
        //Detalle de la factura
        public DataTable consultFacturaAndDetail(string filtro)
        {
            string consulta = string.Concat("SELECT ",
                                            "c.razon_social 'Cliente',",
                                            "b.nombre 'Barrio',",
                                            "c.calle'Calle',",
                                            "c.numero'Nro',",
                                            "f.numero_factura 'NroFactura',",
                                            "fd.numero_orden 'NroOrden',",
                                            "CONCAT_WS('',py.descripcion,p.nombre) AS 'Descripcion',",
                                            "fd.precio 'Monto',",
                                            "f.fecha 'Fecha'",
                                            " FROM FacturasDetalle fd",
                                            " LEFT JOIN Proyectos py ON fd.id_proyecto=py.id_proyecto",
                                            " LEFT JOIN Productos p ON fd.id_producto=p.id_producto",
                                            " JOIN Facturas f on fd.id_factura=f.id_factura",
                                            " JOIN Clientes c on c.id_cliente = f.id_cliente",
                                            " JOIN Barrios b on b.id_barrio=c.id_barrio",
                                            " WHERE f.borrado=0 AND f.id_factura=");
            consulta = consulta + filtro;
            return DBHelper.GetDBHelper().ConsultaSQL(consulta);
        }
    }
}
