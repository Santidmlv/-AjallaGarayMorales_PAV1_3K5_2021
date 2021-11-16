using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Grupo5.Entities
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public Perfil Perfil { get; set; }
        public string  Nombre{ get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Estado { get; set; }
        public int Borrado { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
