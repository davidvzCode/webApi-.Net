using webApi.Models;

namespace webApi.Services
{
    public class CategoriaService: ICategoriaService
    {

        TareasContext tareasContext;

        public CategoriaService(TareasContext tareasContext)
        {
            this.tareasContext = tareasContext;
        }

        public IEnumerable<Categoria> Get()
        {
            return tareasContext.Categorias;
        }

        public async Task Save(Categoria categoria)
        {
            tareasContext.Add(categoria);
            await tareasContext.SaveChangesAsync();
        }

        public async Task Update(Guid id,Categoria categoria)
        {
            var categoriaActual = tareasContext.Categorias.Find(id);
            if(categoriaActual != null)
            {
                categoriaActual.Nombre = categoria.Nombre;
                categoriaActual.Descripcion = categoria.Descripcion;
                categoriaActual.Peso = categoria.Peso;

                await tareasContext.SaveChangesAsync();
            }
            
        }

        public async Task Delete(Guid id)
        {
            var categoriaActual = tareasContext.Categorias.Find(id);
            if (categoriaActual != null)
            {
                tareasContext.Remove(categoriaActual);
                await tareasContext.SaveChangesAsync();
            }

        }
    }
}

public interface ICategoriaService
{
    IEnumerable<Categoria> Get();
    Task Save(Categoria categoria);
    Task Update (Guid id,Categoria categoria);
    Task Delete(Guid id);
}
