using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos_.API.Models;

namespace ProEventos_.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                    EventoID = 1,
                    Tema= "Angular 11 e nt 5",
                    Local = "BH",
                    Lote = "1",
                    QuantPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImageURL = "foto page"
                },
                new Evento(){
                    EventoID = 2,
                    Tema= "Angular e suas novidades",
                    Local = "SP",
                    Lote = "2",
                    QuantPessoas = 500,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd//MM//yy"),
                    ImageURL = "foto page 2"
                }
            };
        public EventoController()
        {

        }

        //Aqui eu tenho uma rota com get que retorna todos os valores do arquivo json
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }
        //Aqui eu tenho outro get que retorna so uma rota com id específico
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            //comando dentro do where diz que é pra retornar o _evento com id indicada
            return _evento.Where(evento => evento.EventoID == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }
        
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put com id ={id}";
        }
        
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id ={id}";
        }
    }
}
