using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Template.Domain.Common;
using Template.Infrastructure.DataContext;
using Template.Infrastructure.Interfaces;

namespace Template.Infrastructure.Repositories;

public abstract class BaseRepository<T, TContext> : IBaseRepository<T> where T : EntityBase<long> where TContext : TemplateDbContext
{
    protected readonly TContext _context;
    protected BaseRepository(TContext context)
    {
        _context = context;
    }

    public virtual async Task<IEnumerable<T>> FindAll()
    {
        IQueryable<T> query = _context.Set<T>();

        return await query.AsNoTracking().ToListAsync();
    }
    public virtual IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
    => _context.Set<T>().Where(expression).AsNoTracking();

    public virtual async Task Create(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }
    public virtual async Task Update(T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }
    public virtual async Task Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }
}