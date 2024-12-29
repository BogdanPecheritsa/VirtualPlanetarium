using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VirtualPlanetarium.Data;
using VirtualPlanetarium.Interfaces;
using VirtualPlanetarium.Models;

namespace VirtualPlanetarium.Repositories
{
    public class GalaxyRepository : IGalaxyRepository
    {
        private readonly CelestialDatabaseContext _context;

        public GalaxyRepository()
        {
            _context = new CelestialDatabaseContext();
        }

        public async Task<IEnumerable<Galaxy>> GetAllGalaxiesAsync()
        {
            return await _context.Galaxies.ToListAsync();
        }

        public async Task<Galaxy> GetGalaxyByIdAsync(Guid id)
        {
            return await _context.Galaxies.FindAsync(id);
        }

        public async Task AddGalaxyAsync(Galaxy galaxy)
        {
            await _context.Galaxies.AddAsync(galaxy);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateGalaxyAsync(Galaxy galaxy)
        {
            _context.Galaxies.Update(galaxy);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGalaxyAsync(Guid id)
        {
            var galaxy = await _context.Galaxies.FindAsync(id);
            if (galaxy != null)
            {
                _context.Galaxies.Remove(galaxy);
                await _context.SaveChangesAsync();
            }
        }
    }
}