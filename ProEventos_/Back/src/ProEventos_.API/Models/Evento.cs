using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos_.API.Models
{
    public class Evento
    {
        public int EventoID { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string Tema { get; set; }
        public int QuantPessoas { get; set; }
        public string Lote { get; set; }
        public string ImageURL { get; set; }

    }
}