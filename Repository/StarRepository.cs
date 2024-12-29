using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VirtualPlanetarium.Interfaces;
using VirtualPlanetarium.Models;

namespace VirtualPlanetarium.Repositories
{
    public class StarRepository : IStarRepository
    {
        private readonly CelestialDatabaseContext _context;

        public StarRepository()
        {
            _context = new CelestialDatabaseContext();
        }

        public async Task<IEnumerable<Star>> GetAllStarsAsync()
        {
            return await _context.Stars.ToListAsync();
        }

        public async Task<Star> GetStarByIdAsync(Guid id)
        {
            return await _context.Stars.FindAsync(id);
        }

        public async Task AddStarAsync(Star star)
        {
            await _context.Stars.AddAsync(star);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateStarAsync(Star star)
        {
            _context.Stars.Update(star);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStarAsync(Guid id)
        {
            var star = await _context.Stars.FindAsync(id);
            if (star != null)
            {
                _context.Stars.Remove(star);
                await _context.SaveChangesAsync();
            }
        }
    }
}