using System.Collections.Generic;
using System.Threading.Tasks;
using VirtualPlanetarium.Models;

namespace VirtualPlanetarium.Interfaces
{
    public interface ICometRepository
    {
        Task<IEnumerable<Comet>> GetAllCometsAsync();
        Task<Comet> GetCometByIdAsync(Guid id);
        Task AddCometAsync(Comet comet);
        Task UpdateCometAsync(Comet comet);
        Task DeleteCometAsync(Guid id);
    }
}