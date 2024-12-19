// Domain/CasosDeUso/CrearProductoCasoDeUso.cs
using ExamenFinal.Dominio;
using MiProyecto.Dominio.Interfaces;

namespace MiProyecto.Dominio.CasosDeUso
{
    public class CrearProductoCasoDeUso
    {
        private readonly IRepositorioProducto _repositorio;

        public CrearProductoCasoDeUso(IRepositorioProducto repositorio)
        {
            _repositorio = repositorio;
        }

        public void Ejecutar(Producto producto)
        {
            // Agregar validación aquí si es necesario
            _repositorio.Guardar(producto);
        }
    }
}