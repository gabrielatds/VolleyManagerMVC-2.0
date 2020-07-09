using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyMVC.Models
{
    public class PartidaTime
    {
        public Partida Partida { get; set; }
        public int PartidaId { get; set; }

        public Time Time { get; set; }
        public int TimeId { get; set; }

    }
}
