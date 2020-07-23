using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyMVC.Models
{
    public class Acao
    {
        public int Id { get; set; }
        public Ponto Ponto { get; set; }
        public int PontoId { get; set; }
        public bool Mandante { get; set; }
        public Jogador Jogador { get; set; }
        public int JogadorId { get; set; }
        public char Movimento { get; set; }
        public int Origem { get; set; }
        public int Destino { get; set; }
        public int Qualidade { get; set; }
        public char Tipo { get; set; }

        public Acao()
        {

        }

        public Acao(Ponto ponto, int pontoId, bool mandante, Jogador jogador, char movimento, int origem, int destino, int qualidade, char tipo)
        {
            Ponto = ponto;
            Mandante = mandante;
            Jogador = jogador;
            Movimento = movimento;
            Origem = origem;
            Destino = destino;
            Qualidade = qualidade;
            Tipo = tipo;
        }
    }
}
