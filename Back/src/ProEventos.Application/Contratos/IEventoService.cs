using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Application.Contratos
{
    public interface IEventoService
    {
        //esses são nossos contratos em relação a adicionar
        Task<Evento> AddEventos(Evento model);
        Task<Evento> UpadateEvento(int eventoId, Evento model);
        Task<bool> DeleteEvento(int eventoId);

        //ja para pegar        
        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
        Task<Evento> GetEventosByIdAsync(int eventoId, bool includePalestrantes = false);
    }
}