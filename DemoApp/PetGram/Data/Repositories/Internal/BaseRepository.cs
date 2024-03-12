using Microsoft.EntityFrameworkCore;
using PetGram.Core.Models.Internal;

namespace PetGram.Data.Repositories.Internal;

public abstract class BaseRepository<T>
    where T : class, IEntity
{
    protected readonly PetShopDbContext context;

    public BaseRepository(PetShopDbContext context)
    {
        this.context = context;
    }

    protected abstract IQueryable<T> Query { get; }

    public virtual async Task<int> Create(T entity)
    {
        context.Add(entity);
        await context.SaveChangesAsync();

        return entity.Id;
    }

    public virtual Task<T?> Get(int id)
        => Query.FirstOrDefaultAsync(e => e.Id == id);

    public virtual async Task<ICollection<T>> GetAll()
        => await Query.ToListAsync();

    public virtual Task Update(T entity)
    {
        context.Update(entity);
        return context.SaveChangesAsync();
    }

    public virtual Task<int> Delete(int id)
        => context.Set<T>()
            .Where(e => e.Id == id)
            .ExecuteDeleteAsync();
}
