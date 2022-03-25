using ProEventos.Domain;
using System.Threading.Tasks;


namespace ProEventos.Persistence
{
    public interface IProEventosPersistence
    {
        //GERAL
        void Add<T>(T entity)where T: class;
        void Update<T>(T entity)where T: class;
        void Delete<T>(T entity)where T: class;
        void DeleteRange<T>(T[] entity)where T: class;

        Task<bool> SaveChangeAsync();

        //EVENTOS
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePralestrantes);
        Task<Evento[]> GetAllEventosAsync(bool includPalestrantes);
        Task<Evento> GetEventoByIdAsync(int EventoId, bool includPalestrantes);

        //PALESTRANTES
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string tema, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync(bool includEventos);
        Task<Palestrante> GetPalestranteByIdAsync(int PalestranteId, bool includEventos);
    }
}