using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VolleyMVC.Data;
using VolleyMVC.Models;

namespace VolleyMVC.Services
{
    public class CompeticaoService
    {
        private readonly VolleyMVCContext _context;

        public CompeticaoService(VolleyMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Competicao>> FindAllAsync()
        {
            return await _context.Competicao.Include(x => x.Categoria).ToListAsync();
        }
    }
}
