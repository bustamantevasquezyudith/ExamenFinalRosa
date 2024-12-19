using ExamenFinal.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Dominio
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}

// Domain/Interfaces/IProductRepository.cs
namespace MiProyecto.Dominio.Interfaces
{
    public interface IRepositorioProducto
    {
        void Guardar(Producto producto);
        Producto ObtenerPorId(int id);
        // Agregar otros métodos según sea necesario (actualizar, eliminar, etc.)
    }
}
