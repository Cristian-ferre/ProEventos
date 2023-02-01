using ProEventos.Domain;
namespace ProEventos.Persistence.Contratos
{
    public interface IGeralPersist
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
       
    }
}