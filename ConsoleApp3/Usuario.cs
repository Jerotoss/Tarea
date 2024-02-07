using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string NombreUsuario { get; set; }
    public string Contraseña { get; set; }
    public string Mail { get; set; }
}

public class Producto
{
    public int Id { get; set; }
    public string Descripcion { get; set; }
    public decimal Costo { get; set; }
    public decimal PrecioVenta { get; set; }
    public int Stock { get; set; }
    public int IdUsuario { get; set; }
}
public static class UsuarioDataAccess
{
    public static void AgregarUsuario(Usuario usuario)
    {
        using (var dbContext = new TuDbContext())
        {
            dbContext.Usuarios.Add(usuario);
            dbContext.SaveChanges();
        }
    }

    public static List<Usuario> ObtenerTodosLosUsuarios()
    {
        using (var dbContext = new TuDbContext())
        {
            return dbContext.Usuarios.ToList();
        }
    }
}

public static class ProductoDataAccess
{
    public static void AgregarProducto(Producto producto)
    {
        using (var dbContext = new TuDbContext())
        {
            dbContext.Productos.Add(producto);
            dbContext.SaveChanges();
        }
    }

    public static List<Producto> ObtenerTodosLosProductos()
    {
        using (var dbContext = new TuDbContext())
        {
            return dbContext.Productos.ToList();
        }
    }
}
