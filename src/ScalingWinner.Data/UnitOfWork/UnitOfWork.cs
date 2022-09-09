using ScalingWinner.Core.Interfaces;
using ScalingWinner.Data.Context;
using ScalingWinner.Data.Repositories;

namespace ScalingWinner.Data.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ScalingWinnerDataContext _scalingWinnerDataContext;
    public UnitOfWork(ScalingWinnerDataContext scalingWinnerDataContext)
    {
        _scalingWinnerDataContext = scalingWinnerDataContext;
        Developers = new DeveloperRepository(_scalingWinnerDataContext);
        Projects = new ProjectRepository(_scalingWinnerDataContext);
    }
    public IDeveloperRepository Developers { get; private set; }
    public IProjectRepository Projects { get; private set; }
    public int Complete()
    {
        return _scalingWinnerDataContext.SaveChanges();
    }
    public void Dispose()
    {
        _scalingWinnerDataContext.Dispose();
    }
}