using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyMVC.Models
{
    public class Acao
    {
        public int Id { get; set; }
        public Jogador Jogador { get; set; }
        public int JogadorId { get; set; }
        public Ponto Ponto { get; set; }
        public int PontoId { get; set; }
        public char Movimento { get; set; }
        public int Origem { get; set; }
        public int Destino { get; set; }
        public int Qualidade { get; set; }
        public char Tipo { get; set; }
    }
}
