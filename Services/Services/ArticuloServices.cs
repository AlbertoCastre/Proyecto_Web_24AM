using Microsoft.EntityFrameworkCore;
using ProyectoWeb24AM_NET._7.Context;
using ProyectoWeb24AM_NET._7.Entities;

namespace ProyectoWeb24AM_NET._7.Services.IServices.Service
{
    public class ArticuloService : IArticuloServices
    {
        private readonly ApplicationDbContext _context;
        public ArticuloService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<List<ArticuloService>> GetArticulo()
        {
            throw new NotImplementedException();
        }

        public async Task< List<Articulo>> GetArticulos()
        {
            try
            {
                List<Articulo> articulos = await _context.Articulos.ToListAsync();
                return articulos;

            }
            catch (Exception ex)
            {

                throw new Exception("Surgió un error"+ex.Message);
            }

        }

        public async Task<Articulo> GetByIdArticulo(int id)
        {
            try
            {
                Articulo response = await _context.Articulos.FirstOrDefaultAsync(x => x.PkArticulo == id);
                //Articulo response = await _context.Articulos.FindAsync(id);
                return response;
            }
            catch (Exception ex)
            {

                throw new Exception("Surgió un error" + ex.Message);
            }
        }
        public async Task<Articulo> CrearArticulo(Articulo i)
        {
            try
            {
                Articulo request = new Articulo()
                {
                    Nombre = i.Nombre,
                    Descripcion = i.Descripcion,
                    Precio = i.Precio
                };
                var result =  _context.Articulos.Add(request);
                await _context.SaveChangesAsync();
                return request;
            }
            catch (Exception ex)
            {

                throw new Exception("Surgió un error" + ex.Message);
            }
        }
    }
}
