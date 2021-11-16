using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_Grupo5.DataAccesLayer;
namespace TP_Grupo5.BusinesLayer
{
    public class ReporteServicio
    {
        ReportesDao oReportesDao = new ReportesDao();
        public DataTable consultarFacturaReporte(string filtro)
        {
            return oReportesDao.consultFacturaReport(filtro);
        }

        public DataTable consultarDetalleCantidad(string filtro)
        {
            return oReportesDao.consultDetalleCant(filtro);
        }

        public DataTable consultarFacturaDetalle(string filtro)
        {
            return oReportesDao.consultFacturaAndDetail(filtro);
        }
    }
}
