using ScalingWinner.Core.Entities;
using ScalingWinner.Core.Interfaces;
using ScalingWinner.Data.Context;

namespace ScalingWinner.Data.Repositories;

public class ProjectRepository : GenericRepository<Project>, IProjectRepository
{
    public ProjectRepository(ScalingWinnerDataContext scalingWinnerDataContext) : base(scalingWinnerDataContext)
    {
    }
}
