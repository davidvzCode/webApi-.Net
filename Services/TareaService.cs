using webApi.Models;

namespace webApi.Services
{
    public class TareaService: ITareaService
    {
        TareasContext tareasContext;

        public TareaService(TareasContext tareasContext)
        {
            this.tareasContext = tareasContext;
        }

        public IEnumerable<Tarea> Get()
        {
            return tareasContext.Tareas;

        }
    }
}

public interface ITareaService
{
    IEnumerable<Tarea> Get();
}
