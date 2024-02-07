using SistemaGestionEntities;
using System.Collections.Generic;

namespace SistemaGestionData.DataAccess
{
    public static class UsuarioData
    {
        public static List<Usuario> GetUsuarios()
        {
            // Simular datos estáticos de usuarios
            var usuarios = new List<Usuario>
            {
                new Usuario { Id = 1, Nombre = "Juan", Apellido = "Perez", NombreUsuario = "jperez", Contraseña = "contraseña123", Mail = "jperez@example.com" },
                new Usuario { Id = 2, Nombre = "María", Apellido = "González", NombreUsuario = "mgonzalez", Contraseña = "clave123", Mail = "mgonzalez@example.com" },
                // Agregar más usuarios si es necesario
            };

            return usuarios;
        }
    }
}
