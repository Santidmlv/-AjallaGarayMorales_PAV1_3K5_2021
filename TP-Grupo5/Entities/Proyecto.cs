using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Grupo5.Entities
{
    public class Proyecto
    {
        public int Id_proyecto { get; set; }
        public Producto Producto { get; set; }
        public string Descripcion { get; set; }
        public string Version { get; set; }
        public string Alcance { get; set; }
        public Usuario Responsable { get; set; }
        public int Borrado { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
