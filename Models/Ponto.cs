using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyMVC.Models
{
    public class Ponto
    {
        public int Id { get; set; }
        public Set Set { get; set; }
        public int SetId { get; set; }
        public int PontoMandante { get; set; }
        public int PontoVisistante { get; set; }
        public ICollection<Acao> Acoes { get; set; } = new List<Acao>();
    }
}
