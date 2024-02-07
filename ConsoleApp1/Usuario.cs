using SistemaGestionData.DataAccess; // Importar el namespace donde se encuentra UsuarioData
using SistemaGestionEntities; // Importar el namespace donde se encuentra la clase Usuario
using System.Collections.Generic;

namespace SistemaGestionBussiness.BusinessLogic
{
    public static class UsuarioBussiness
    {
        public static List<Usuario> GetUsuarios()
        {
            // Invocar al método GetUsuarios de SistemaGestionData
            return UsuarioData.GetUsuarios();
        }
    }
}
