using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VirtualPlanetarium.Interfaces;
using VirtualPlanetarium.Models;

namespace VirtualPlanetarium.Repositories
{
    public class PlanetRepository : IPlanetRepository
    {
        private readonly CelestialDatabaseContext _context;

        public PlanetRepository()
        {
            _context = new CelestialDatabaseContext();
        }

        public async Task<IEnumerable<Planet>> GetAllPlanetsAsync()
        {
            return await _context.Planets.ToListAsync();
        }

        public async Task<Planet> GetPlanetByIdAsync(Guid id)
        {
            return await _context.Planets.FindAsync(id);
        }

        public async Task AddPlanetAsync(Planet planet)
        {
            await _context.Planets.AddAsync(planet);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePlanetAsync(Planet planet)
        {
            _context.Planets.Update(planet);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePlanetAsync(Guid id)
        {
            var planet = await _context.Planets.FindAsync(id);
            if (planet != null)
            {
                _context.Planets.Remove(planet);
                await _context.SaveChangesAsync();
            }
        }
    }
}