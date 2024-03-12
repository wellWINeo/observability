
using Microsoft.EntityFrameworkCore;
using PetGram.Core.Models;
using PetGram.Data.Repositories.Internal;

namespace PetGram.Data.Repositories;

public class BreedsRepository : BaseRepository<Breed>
{
    public BreedsRepository(PetShopDbContext context)
        : base(context) { }

    protected override IQueryable<Breed> Query => context
        .Set<Breed>()
        .Include(b => b.HealthIssues);

    public Task<bool> Exists(int id) => Query.AnyAsync(b => b.Id == id);
}
