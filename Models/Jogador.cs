﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyMVC.Models
{
    public class Jogador
    {
        public int Id { get; set; }
        public Categoria Categoia { get; set; }
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public int Numero_Camisa { get; set; }
        public DateTime Nascimento { get; set; }
        public int Altura { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
    }
}
