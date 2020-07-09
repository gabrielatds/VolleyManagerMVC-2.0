using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyMVC.Models
{
    public class Set
    {
        public int Id { get; set; }
        public Partida Partida { get; set; }
        public int PartidaId { get; set; }
        public int Num_Sets { get; set; }
        public int PontosMandante { get; set; }
        public int PontosVisitante { get; set; }
        public ICollection<Ponto> Pontos { get; set; } = new List<Ponto>();
    }
}
