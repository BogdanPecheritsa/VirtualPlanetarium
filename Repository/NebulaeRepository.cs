using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VirtualPlanetarium.Data;
using VirtualPlanetarium.Interfaces;
using VirtualPlanetarium.Models;

namespace VirtualPlanetarium.Repositories
{
    public class NebulaeRepository : INebulaeRepository
    {
        private readonly CelestialDatabaseContext _context;

        public NebulaeRepository()
        {
            _context = new CelestialDatabaseContext();
        }

        public async Task<IEnumerable<Nebulae>> GetAllNebulaeAsync()
        {
            return await _context.Nebulaes.ToListAsync();
        }

        public async Task<Nebulae> GetNebulaeByIdAsync(Guid id)
        {
            return await _context.Nebulaes.FindAsync(id);
        }


        public async Task AddNebulaeAsync(Nebulae nebulae)
        {
            await _context.Nebulaes.AddAsync(nebulae);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateNebulaeAsync(Nebulae nebulae)
        {
            _context.Nebulaes.Update(nebulae);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteNebulaeAsync(Guid id)
        {
            var nebulae = await _context.Nebulaes.FindAsync(id);
            if (nebulae != null)
            {
                _context.Nebulaes.Remove(nebulae);
                await _context.SaveChangesAsync();
            }
        }
    }
}