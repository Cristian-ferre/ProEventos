
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;
using ProEventos.Persistence.Contextos;
using ProEventos.Persistence.Contratos;

namespace ProEventos.Persistence
{
    public class EventoPersist : IEventoPersist
    {

        //mesma coisa que faço no context

        private readonly ProEventosContext _context;
        public EventoPersist(ProEventosContext context)
        {
            _context = context;
            //_context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

        }

        public async Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false)
        {
            IQueryable<Evento> query = _context.Eventos
            //para retornar lote  e redesSociais
            //dado evento a cada eventp vou retornar lotes e redesociasi
            .Include(e => e.Lotes)
            .Include(e => e.RedesSociais);

            //c a pessoa quer incluir um palestrante 
            if (includePalestrantes)
            {
                //dado o palestranteevneto eu vou incluir um palestrante
                query = query
                //a cada palestranteevento inclua palestrante
                .Include(e => e.PalestranteEventos)
                .ThenInclude(pe => pe.Palestrante);
            }

            //ordenar por ID
            query = query.AsNoTracking().OrderBy(e => e.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false)
        {
            IQueryable<Evento> query = _context.Eventos
            //para retornar lote  e redesSociais
            //dado evento a cada eventp vou retornar lotes e redesociasi
            .Include(e => e.Lotes)
            .Include(e => e.RedesSociais);

            //c a pessoa quer incluir um palestrante 
            if (includePalestrantes)
            {
                //dado o palestranteevneto eu vou incluir um palestrante
                query = query
                //a cada palestranteevento inclua palestrante
                .Include(e => e.PalestranteEventos)
                .ThenInclude(pe => pe.Palestrante);
            }


            query = query.AsNoTracking().OrderBy(e => e.Id)
            //ordenar por ID
            //dado um evento a cada evento q tiver converte pra lowercase e analisa c contem um tema 
            .Where(e => e.Tema.ToLower().Contains(tema.ToLower()));

            return await query.ToArrayAsync();
        }


        public async Task<Evento> GetEventosByIdAsync(int eventoId, bool includePalestrantes = false)
        {
            IQueryable<Evento> query = _context.Eventos
            //para retornar lote  e redesSociais
            //dado evento a cada eventp vou retornar lotes e redesociasi
            .Include(e => e.Lotes)
            .Include(e => e.RedesSociais);

            //c a pessoa quer incluir um palestrante 
            if (includePalestrantes)
            {
                //dado o palestranteevneto eu vou incluir um palestrante
                query = query
                //a cada palestranteevento inclua palestrante
                .Include(e => e.PalestranteEventos)
                .ThenInclude(pe => pe.Palestrante);
            }


            query = query.AsNoTracking().OrderBy(e => e.Id)
            .Where(e => e.Id == eventoId);

            return await query.FirstOrDefaultAsync();
        }

        


    }
}