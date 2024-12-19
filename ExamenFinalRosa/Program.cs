using MiProyecto.Dominio.CasosDeUso;
using MiProyecto.Infraestructura.Persistencia;
using ExamenFinal.Dominio;

public class Program
{
    public static void Main(string[] args)
    {
        var repositorio = new RepositorioProductoEnMemoria();
        var casoDeUso = new CrearProductoCasoDeUso(repositorio);

        var nuevoProducto = new Producto { Nombre = "Ejemplo de Producto", Precio = 19.99m };
        casoDeUso.Ejecutar(nuevoProducto);

        Console.WriteLine($"Producto creado con ID: {nuevoProducto.Id}");
    }
}