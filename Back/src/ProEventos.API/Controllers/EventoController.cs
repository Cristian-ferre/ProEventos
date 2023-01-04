using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventoController : ControllerBase
{

    public IEnumerable<Evento> _evento = new Evento[]{
           new Evento (){
             EventoId = 1,
            Tema = "Vue",
            Local = "websupply",
            Lote = "1 Lote",
            QtdPessoas = 346,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImagemURL = "cris.png"
           },
           new Evento (){
             EventoId = 2,
            Tema = "Vue",
            Local = "websupply",
            Lote = "1 Lote",
            QtdPessoas = 346,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImagemURL = "cris1.png"
           }
        };


    public EventoController()
    {

    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }



}

