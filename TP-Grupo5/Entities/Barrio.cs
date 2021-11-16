using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Grupo5.Entities
{
    public class Barrio
    {
        public int Id_Barrio { get; set; }
        public String Nombre { get; set; }
        public bool Borrado { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
