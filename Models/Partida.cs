using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyMVC.Models
{
    public class Partida
    {
        public int Id { get; set; }
        public Time Mandante { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public int MandanteId { get; set; }
        public Time Visitante { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public int VisitanteId { get; set; }
        public Competicao Competicao { get; set; }
        public int CompeticaoId { get; set; }
        public int Num_Sets { get; set; }
        public ICollection<Set> Sets { get; set; } = new List<Set>();
        public char OpcaoLancamento { get; set; }

        public Partida()
        {

        }

        public Partida(Time mandante, Time visitante, Competicao competicao, int num_Sets, char opcaoLancamento)
        {
            Mandante = mandante;
            Visitante = visitante;
            Competicao = competicao;
            Num_Sets = num_Sets;
            OpcaoLancamento = opcaoLancamento;
        }
    }
}
