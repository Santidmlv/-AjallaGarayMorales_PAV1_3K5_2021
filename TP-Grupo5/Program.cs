using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Grupo5.GUILayer;
using TP_Grupo5.GUILayer.Reportes;

namespace TP_Grupo5
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
            //Application.Run(new frmReporteFactura());
            //Application.Run(new frmReporteDetalleCantidad());
            //Application.Run(new frmReporteDetalleFactura());
            //Application.Run(new frmConsultarFacturas());
            
        }
    }
}
