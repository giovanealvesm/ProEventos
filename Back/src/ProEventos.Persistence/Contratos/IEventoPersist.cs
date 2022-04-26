using ProEventos.Domain;
using System.Threading.Tasks;


namespace ProEventos.Persistence.Contratos
{
    public interface IEventoPersist
    {
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePralestrantes = false);
        Task<Evento[]> GetAllEventosAsync(bool includPalestrantes = false);
        Task<Evento> GetEventoByIdAsync(int eventoId, bool includPalestrantes = false);
    }
}