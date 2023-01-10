using ProEventos.Domain;
namespace ProEventos.Persistence
{
    public interface IProEventosPersistence
    {
        //geral
        //Aqui vou criar todas as chamadas da minha persitencia
        //são nossos itens gerais (todo e qualquer adicionar, atualizar, salvar, deletar e deletar todos que tivermos )
        //ele vai ser feito utilizando esses metodos
        //é como c tiverssemos acabando de acabar todos os add, update, delete 
        //apenas os gets seram diferentes
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void DeleteRange<T>(T[] entity) where T : class;
        Task<bool> SaveChangesAsync();
        //EVENTOS
        // vou retornar (são os gets)
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes);
        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes);
        Task<Evento[]> GetEventosByIdAsync(string EventoId, bool includePalestrantes);
        //em evento ele ja vai retonar lote e rede social 
        //ja o palestrante evento é mais custozo pois não é 1 pra 1 ou 1 pra muitos 
        //mas sim muitos pra muitos
        //então fazemos isso
        //passa esse parametro  bool includeEventos
        //PALESTRANTES
        Task<Evento[]> GetAllEventosByNomeAsync(string tema, bool includeEventos);
        Task<Evento[]> GetAllPalestrantesAsync(bool includeEventos);
        Task<Evento[]> GetPalestrantesByIdAsync(string EventoId, bool includeEventos);
    }
}