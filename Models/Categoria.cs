using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Genero { get; set; }
        public int Idade_Max { get; set; }
        public Time Time { get; set; }
        public int TimeId { get; set; }
        public ICollection<Jogador> Jogadores { get; set; } = new List<Jogador>();
    }
}
