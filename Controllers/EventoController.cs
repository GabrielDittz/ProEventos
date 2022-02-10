using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {  
                new Evento(){
                EventoId = 1,
                Tema = "Curso",
                Local = "Belo Horizonte",
                Lote = "1° Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImageURL = "foto.png"
                },
                new Evento(){
                EventoId = 2,
                Tema = "Curso",
                Local = "São Paulo",
                Lote = "2° Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImageURL = "foto.png"
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
        public IEnumerable<Evento> Get(int id)
        {   
           return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {   
            return "Exemplo Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo Put com Id = {id}";
        }

        [HttpDelete]
        public string Delete(int id)
        {
            return $"Exemplo Put com Id = {id}";
        }
    }
}
