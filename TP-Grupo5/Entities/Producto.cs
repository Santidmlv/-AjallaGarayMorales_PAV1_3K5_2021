using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Grupo5.Entities
{
    public class Producto
    {
        
        public int Id_Producto{ get; set; }
        public string Nombre { get; set; }
        public int Borrado { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

    }

}
