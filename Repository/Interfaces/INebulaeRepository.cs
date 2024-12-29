using System.Collections.Generic;
using System.Threading.Tasks;
using VirtualPlanetarium.Models;

namespace VirtualPlanetarium.Interfaces
{
    public interface INebulaeRepository
    {
        Task<IEnumerable<Nebulae>> GetAllNebulaeAsync();
        Task<Nebulae> GetNebulaeByIdAsync(Guid id);
        Task AddNebulaeAsync(Nebulae nebulae);
        Task UpdateNebulaeAsync(Nebulae nebulae);
        Task DeleteNebulaeAsync(Guid id);
    }
}