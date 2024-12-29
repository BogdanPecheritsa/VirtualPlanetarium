using System.Collections.Generic;
using System.Threading.Tasks;
using VirtualPlanetarium.Models;

namespace VirtualPlanetarium.Interfaces
{
    public interface IGalaxyRepository
    {
        Task<IEnumerable<Galaxy>> GetAllGalaxiesAsync();
        Task<Galaxy> GetGalaxyByIdAsync(Guid id);
        Task AddGalaxyAsync(Galaxy galaxy);
        Task UpdateGalaxyAsync(Galaxy galaxy);
        Task DeleteGalaxyAsync(Guid id);
    }
}