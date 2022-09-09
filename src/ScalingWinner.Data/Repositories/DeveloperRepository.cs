using ScalingWinner.Core.Entities;
using ScalingWinner.Core.Interfaces;
using ScalingWinner.Data.Context;

namespace ScalingWinner.Data.Repositories;

public class DeveloperRepository : GenericRepository<Developer>, IDeveloperRepository
{
    public DeveloperRepository(ScalingWinnerDataContext scalingWinnerDataContext) : base(scalingWinnerDataContext) { }
    public IEnumerable<Developer> GetPopularDevelopers(int count)
    {
        return _scalingWinnerDataContext.Developers.OrderByDescending(d => d.Followers).Take(count).ToList();
    }
}
