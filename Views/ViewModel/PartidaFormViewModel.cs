using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VolleyMVC.Models;

namespace VolleyMVC.Views.ViewModel
{
    public class PartidaFormViewModel
    {
        public Partida Partida { get; set; }
        public ICollection<Competicao> Competicoes { get; set; }
        public ICollection<Time> Times { get; set; }


    }
}
