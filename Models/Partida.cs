using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyMVC.Models
{
    public class Partida
    {
        public int Id { get; set; }
        public ICollection<PartidaTime> PartidaTimes { get; set; }
        public Competicao Competicao { get; set; }
        public int CompeticaoId { get; set; }
        public int Num_Sets { get; set; }
        public ICollection<Set> Sets { get; set; } = new List<Set>();
        public char OpcaoLancamento { get; set; }

    }
}
