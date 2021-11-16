﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Grupo5.Entities
{
    public class Contacto
    {
        public int Id_Contacto { get; set;}
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Email { get; set; }
        public String Telefono { get; set; }

        public bool Borrado { get; set; }
        public override String ToString()
        { 
            return Nombre;
        }
    }

    
}
