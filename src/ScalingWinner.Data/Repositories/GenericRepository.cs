using ScalingWinner.Core.Interfaces;
using ScalingWinner.Data.Context;
using System.Linq.Expressions;

namespace ScalingWinner.Data.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly ScalingWinnerDataContext _scalingWinnerDataContext;
    public GenericRepository(ScalingWinnerDataContext scalingWinnerDataContext)
    {
        _scalingWinnerDataContext = scalingWinnerDataContext;
    }
    public void Add(T entity)
    {
        _scalingWinnerDataContext.Set<T>().Add(entity);
    }
    public void AddRange(IEnumerable<T> entities)
    {
        _scalingWinnerDataContext.Set<T>().AddRange(entities);
    }
    public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
        return _scalingWinnerDataContext.Set<T>().Where(expression);
    }
    public IEnumerable<T> GetAll()
    {
        return _scalingWinnerDataContext.Set<T>().ToList();
    }
    public T GetById(int id)
    {
        return _scalingWinnerDataContext.Set<T>().Find(id);
    }
    public void Remove(T entity)
    {
        _scalingWinnerDataContext.Set<T>().Remove(entity);
    }
    public void RemoveRange(IEnumerable<T> entities)
    {
        _scalingWinnerDataContext.Set<T>().RemoveRange(entities);
    }
}
