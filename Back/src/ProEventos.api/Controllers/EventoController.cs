using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.api.Models;

namespace ProEventos.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento() {
                EventoId = 1,
                Local = "São Sebastião",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                Tema = "Angula 11 e .NET 5",
                QtdPessoas = 250,
                Lote = "Lote 1",
                ImagemUrl = "Foto.png"
            },
            new Evento() {
                EventoId = 2,
                Local = "São Paulo",
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                Tema = "Angula E Suas Novidades",
                QtdPessoas = 350,
                Lote = "Lote 2",
                ImagemUrl = "Foto1.png"
            }
        };  
        
        

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(Evento => Evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com o id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com o id = {id}";
        }
    }
}
