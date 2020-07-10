using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VolleyMVC.Data;
using VolleyMVC.Models;
using VolleyMVC.Services.Exceptions;

public class TimeService
{
    private readonly VolleyMVCContext _context;

    public TimeService(VolleyMVCContext context)
    {
        _context = context;
    }

    public async Task<List<Time>> FindAllAsync()
    {
        return await _context.Time.ToListAsync();
    }

    public async Task InsertAsync(Time time)
    {
        _context.Add(time);
        await _context.SaveChangesAsync();
    }

    public async Task<Time> FindByIdAsync(int id)
    {
        return await _context.Time.FirstOrDefaultAsync(time => time.Id == id);
    }

    public async Task RemoveAsync(int id)
    {
        try
        {
            var obj = _context.Time.Find(id);
            _context.Time.Remove(obj);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException e)
        {
            throw new IntegrityException(e.Message);
        }

    }

    public async Task UpdateAsync(Time time)
    {
        if (!_context.Time.Any(x => x.Id == time.Id))
        {
            throw new NotFoundException("Id não encontrado");
        }

        try
        {
            _context.Update(time);
            await _context.SaveChangesAsync();
        }
        catch (DbConcurrencyException e)
        {
            throw new DbConcurrencyException(e.Message);
        }
    }
}

