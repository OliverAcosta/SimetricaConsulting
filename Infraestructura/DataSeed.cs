using Infraestructura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class DataSeed
    {
        public static List<Usuario> Usuarios = new List<Usuario>()
        {
            new Usuario { Id = 1, Nombre = "Simetrica", Apellido = "Consulting",
                Usuario_Nombre = "ADMIN", Contrasena = "ADMIN", Cedula = "25322522135", Fecha_Nacimiento = new DateTime(1990, 1, 1), Fecha_Transaccion = DateTime.Now, RolId = 1 },
            new Usuario { Id = 1, Nombre = "Juan Oliver", Apellido = "Consulting",
                Usuario_Nombre = "DESARROLLADOR", Contrasena = "APLICANTE", Cedula = "0000000000", Fecha_Nacimiento = new DateTime(2000, 2, 25), Fecha_Transaccion = DateTime.Now, RolId =  2  }

        };

        public static List<Role> Roles = new List<Role>()
        {
            new Role { Id = 1, Nombre = "ADMIN", Usuario_Transaccion = "DESARROLLADOR", Fecha_Transaccion = DateTime.Now },
            new Role { Id = 2, Nombre = "DESARROLLADOR", Usuario_Transaccion = "DESARROLLADOR", Fecha_Transaccion = DateTime.Now  }
        };
    }
}
