using ProyectoWeb24AM_NET._7.Entities;
using ProyectoWeb24AM_NET._7.Services.IServices.Service;


namespace ProyectoWeb24AM_NET._7.Services.IServices
{
    public interface IArticuloServices
    {
        public Task<List<ArticuloService>> GetArticulo();
        public Task<Articulo> GetByIdArticulo(int id);

        public Task<Articulo> CrearArticulo(Articulo i);
    }
}
