// Infrastructure/Persistencia/InMemoryProductRepository.cs
using MiProyecto.Dominio.Interfaces;
using System.Collections.Generic;
using System.Linq;
using ExamenFinal.Dominio;

namespace MiProyecto.Infraestructura.Persistencia
{
    public class RepositorioProductoEnMemoria : IRepositorioProducto
    {
        private readonly List<Producto> _productos = new List<Producto>();

        public void Guardar(Producto producto)
        {
            if (producto.Id == 0)
            {
                producto.Id = _productos.Count + 1;
            }
            _productos.Add(producto); // o actualizar si el Id ya existe
        }

        public Producto ObtenerPorId(int id)
        {
            return _productos.FirstOrDefault(p => p.Id == id);
        }
    }
}