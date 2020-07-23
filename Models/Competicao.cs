using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyMVC.Models
{
    public class Competicao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ano_Temporada { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
        public ICollection<Partida> Partidas { get; set; } = new List<Partida>();

        public Competicao()
        {

        }

        public Competicao(string nome, int ano_Temporada, Categoria categoria)
        {
            Nome = nome;
            Ano_Temporada = ano_Temporada;
            Categoria = categoria;
        }
    }
}
