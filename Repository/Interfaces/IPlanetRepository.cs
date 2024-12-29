using System.Collections.Generic;
using System.Threading.Tasks;
using VirtualPlanetarium.Models;

namespace VirtualPlanetarium.Interfaces
{
    public interface IPlanetRepository
    {
        Task<IEnumerable<Planet>> GetAllPlanetsAsync();
        Task<Planet> GetPlanetByIdAsync(Guid id);
        Task AddPlanetAsync(Planet planet);
        Task UpdatePlanetAsync(Planet planet);
        Task DeletePlanetAsync(Guid id);
    }
}