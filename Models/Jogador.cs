using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyMVC.Models
{
    public class Jogador
    {
        public int Id { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public int Numero_Camisa { get; set; }
        public DateTime Nascimento { get; set; }
        public int Altura { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public ICollection<Acao> Acoes { get; set; } = new List<Acao>();

        public Jogador()
        {

        }

        public Jogador(Categoria categoria, string nome, int numero_Camisa, DateTime nascimento, int altura, string cpf, string rg)
        {
            Categoria = categoria;
            Nome = nome;
            Numero_Camisa = numero_Camisa;
            Nascimento = nascimento;
            Altura = altura;
            Cpf = cpf;
            Rg = rg;
        }
    }
}
