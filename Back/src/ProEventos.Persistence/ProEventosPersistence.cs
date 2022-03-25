using System.Threading.Tasks;
using ProEventos.Domain;
using System;

namespace ProEventos.Persistence
{
	public class ProEventosPersistence : IProEventosPersistence
	{
        public ProEventosPersistence (ProEventosContext _context)
	{

	}
		public void Add<T>(T entity) where T: class
        {
			throw new System.NotImplementedException();
        }
        public void Update<T>(T entity)where T: class
        {
            throw new System.NotImplementedException();
        }
        public void Delete<T>(T entity)where T: class
        {
            throw new System.NotImplementedException();
        }
        public void DeleteRange<T>(T[] entity)where T: class
        {
            throw new System.NotImplementedException();
        }
        public Task<bool> SaveChangeAsync()
        {
            throw new System.NotImplementedException();
        }
        public Task<Evento[]> GetAllEventosAsync(bool includPalestrantes)
        {
            throw new System.NotImplementedException();
        }
        public Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePralestrantes)
        {
            throw new System.NotImplementedException();
        } 
        public Task<Evento> GetEventoByIdAsync(int EventoId, bool includPalestrantes)
        {
            throw new System.NotImplementedException();
        }
        public Task<Palestrante[]> GetAllPalestrantesAsync(bool includEventos)
        {
            throw new System.NotImplementedException();
        }
        public Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string tema, bool includeEventos)
        {
            throw new System.NotImplementedException();
        }
        public Task<Palestrante> GetPalestranteByIdAsync(int PalestranteId, bool includEventos)
        {
            throw new System.NotImplementedException();
        }
        
	}
}