using System.Collections.Generic;
using System.Threading.Tasks;
using VirtualPlanetarium.Models;

namespace VirtualPlanetarium.Interfaces
{
    public interface ICelestialObjectRepository
    {
        Task<IEnumerable<CelestialObject>> GetAllCelestialObjectsAsync();
        Task<CelestialObject> GetCelestialObjectByIdAsync(Guid id);
        Task AddCelestialObjectAsync(CelestialObject celestialObject);
        Task UpdateCelestialObjectAsync(CelestialObject celestialObject);
        Task DeleteCelestialObjectAsync(Guid id);
    }
}
