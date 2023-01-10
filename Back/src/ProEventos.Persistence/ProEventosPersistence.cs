using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;
using ProEventos.Persistence.Contextos;

namespace ProEventos.Persistence
{
    public class ProEventosPersistence : IProEventosPersistence
    {
        //vou engetar o contexto na minha persistencia a mesma que é usada na controller
        private readonly ProEventosContext _context;
        public ProEventosPersistence(ProEventosContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<T>(T[] entityArray) where T : class
        {
            _context.RemoveRange(entityArray);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        //para retorna todos os eventos
        public async Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false)
        {
            IQueryable<Evento> query = _context.Eventos
            //vou incluir dado o evento a cada evento eu incluir lote e resdessociais
            .Include(e => e.Lotes)
            .Include(e => e.RedesSociais);

            if (includePalestrantes)
            {
                //a cada evento eu vou incluir por paletrante evento
                //a cada palestrante evento q eu tiver inclua os paletrante
                query = query
                .Include(e => e.PalestranteEventos)
                .ThenInclude(pe => pe.Palestrante);
            }

            //para retornar
            query = query.OrderBy(e => e.Id);
            return await query.ToArrayAsync();
        }

        public Task<Evento[]> GetAllEventosByNomeAsync(string tema, bool includeEventos)
        {
            throw new NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public Task<Evento[]> GetAllPalestrantesAsync(bool includeEventos)
        {
            throw new NotImplementedException();
        }

        public Task<Evento[]> GetEventosByIdAsync(string EventoId, bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public Task<Evento[]> GetPalestrantesByIdAsync(string EventoId, bool includeEventos)
        {
            throw new NotImplementedException();
        }

    }
}