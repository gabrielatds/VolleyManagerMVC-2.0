using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyMVC.Models
{
    public class PartidaTime
    {
        public Partida Partida { get; set; }
        public int PartidaId { get; set; }

        public Time Time { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerat‌ed(System.ComponentM‌​odel.DataAnnotations‌​.Schema.DatabaseGeneratedOp‌​tion.None)]
        public int TimeId { get; set; }


    }
}
