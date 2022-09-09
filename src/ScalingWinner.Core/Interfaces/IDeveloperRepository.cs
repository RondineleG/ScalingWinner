using ScalingWinner.Core.Entities;

namespace ScalingWinner.Core.Interfaces
{
    public interface IDeveloperRepository : IGenericRepository<Developer>
    {
        IEnumerable<Developer> GetPopularDevelopers(int count);
    }
}
