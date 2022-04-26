using ProEventos.Domain;
using System.Threading.Tasks;


namespace ProEventos.Persistence.Contratos
{
    public interface IPalestrantePersist
    {
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync(bool includEventos);
        Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includEventos);
    }
}