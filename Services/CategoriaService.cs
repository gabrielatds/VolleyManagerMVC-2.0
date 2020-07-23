using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VolleyMVC.Data;
using VolleyMVC.Models;

namespace VolleyMVC.Services
{
    public class CategoriaService
    {
        private readonly VolleyMVCContext _context;

        public CategoriaService(VolleyMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Categoria>> FindAllAsync()
        {
            return await _context.Categoria.Include(x => x.Jogadores).Include(x => x.Time).ToListAsync();
        }
    }
}
