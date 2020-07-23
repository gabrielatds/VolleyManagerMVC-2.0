using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyMVC.Models
{
    public class Time
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Categoria> Categorias { get; set; } = new List<Categoria>();
        public ICollection<Partida> Partidas { get; set; }

        public Time()
        {

        }
        public Time(string nome)
        {
            Nome = nome;
        }
    }
}
