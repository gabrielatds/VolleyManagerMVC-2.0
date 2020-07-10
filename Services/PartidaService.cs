using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VolleyMVC.Data;
using VolleyMVC.Models;

namespace VolleyManagerMvc.Services
{
    public class PartidaService
    {
        private readonly VolleyMVCContext _context;

        public PartidaService(VolleyMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Partida>> FindAllAsync()
        {
            return await _context.Partida.Include(db => db.Mandante).ToListAsync();
        }
    }
}