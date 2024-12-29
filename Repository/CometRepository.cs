using Microsoft.EntityFrameworkCore;
using VirtualPlanetarium.Data;
using VirtualPlanetarium.Interfaces;
using VirtualPlanetarium.Models;

public class CometRepository : ICometRepository
{
    private readonly CelestialDatabaseContext _context;

    public CometRepository()
    {
        _context = new CelestialDatabaseContext();
    }

    public async Task<IEnumerable<Comet>> GetAllCometsAsync()
    {
        return await _context.Comets.ToListAsync();
    }

    public async Task<Comet> GetCometByIdAsync(Guid id)
    {
        return await _context.Comets.FindAsync(id);
    }

    public async Task AddCometAsync(Comet comet)
    {
        await _context.Comets.AddAsync(comet);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateCometAsync(Comet comet)
    {
        _context.Comets.Update(comet);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteCometAsync(Guid id)
    {
        var comet = await _context.Comets.FindAsync(id);
        if (comet != null)
        {
            _context.Comets.Remove(comet);
            await _context.SaveChangesAsync();
        }
    }
}