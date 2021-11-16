using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Grupo5.Entities
{
    public class Cliente
    {
        public int Id_cliente { get; set;}
        public int Cuit { get; set; }
        public String Razon_social { get; set; }
        public DateTime Fecha_alta { get; set; }
        public bool Borrado { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public Barrio Barrio { get; set; }
        public Contacto Contacto { get; set; }
        public override string ToString()
        {
            return Razon_social;
        }
    }

    
}
