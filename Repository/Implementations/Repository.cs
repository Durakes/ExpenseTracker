using ExpenseTracker.Data;
using Microsoft.EntityFrameworkCore;
namespace ExpenseTracker.Repositories;
public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly ApplicationDbContext _context;
    public Repository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<TEntity>> GetAll()
    {
        return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
    }
    public async Task<TEntity?> GetById(int id)
    {
        return await _context.Set<TEntity>().FindAsync(id);
    }
    public async Task Add(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }
    public async Task Update(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();
    }
    public async Task Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
        await _context.SaveChangesAsync();
    }
}