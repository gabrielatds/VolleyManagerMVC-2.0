using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VolleyMVC.Models;

namespace VolleyMVC.Data
{
    public class SeedingService
    {
        private readonly VolleyMVCContext _context;

        public SeedingService(VolleyMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Partida.Any() || _context.Time.Any() || _context.Competicao.Any() || _context.Categoria.Any())
            {
                return;
            }
        }
    }
}
