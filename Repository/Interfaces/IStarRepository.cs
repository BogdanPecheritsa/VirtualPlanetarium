using System.Collections.Generic;
using System.Threading.Tasks;
using VirtualPlanetarium.Models;

namespace VirtualPlanetarium.Interfaces
{
    public interface IStarRepository
    {
        Task<IEnumerable<Star>> GetAllStarsAsync();
        Task<Star> GetStarByIdAsync(Guid id);
        Task AddStarAsync(Star star);
        Task UpdateStarAsync(Star star);
        Task DeleteStarAsync(Guid id);
    }
}