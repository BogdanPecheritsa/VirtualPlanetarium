using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VirtualPlanetarium.Interfaces;
using VirtualPlanetarium.Models;

namespace VirtualPlanetarium.Repositories
{
    public class CelestialObjectRepository : ICelestialObjectRepository
    {
        private readonly CelestialDatabaseContext _context;

        public CelestialObjectRepository()
        {
            _context = new CelestialDatabaseContext();
        }

        public async Task<IEnumerable<CelestialObject>> GetAllCelestialObjectsAsync()
        {
            return await _context.CelestialObjects.ToListAsync();
        }

        public async Task<CelestialObject> GetCelestialObjectByIdAsync(Guid id)
        {
            return await _context.CelestialObjects.FindAsync(id);
        }

        public async Task AddCelestialObjectAsync(CelestialObject celestialObject)
        {
            await _context.CelestialObjects.AddAsync(celestialObject);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCelestialObjectAsync(CelestialObject celestialObject)
        {
            _context.CelestialObjects.Update(celestialObject);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCelestialObjectAsync(Guid id)
        {
            var celestialObject = await _context.CelestialObjects.FindAsync(id);
            if (celestialObject != null)
            {
                _context.CelestialObjects.Remove(celestialObject);
                await _context.SaveChangesAsync();
            }
        }
    }
}