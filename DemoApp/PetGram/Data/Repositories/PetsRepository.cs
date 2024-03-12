using Microsoft.EntityFrameworkCore;
using PetGram.Core.Models;
using PetGram.Data.Repositories.Internal;

namespace PetGram.Data.Repositories;

public class PetsRepository : BaseRepository<Pet>
{
    public PetsRepository(PetShopDbContext context)
        : base(context) { }

    protected override IQueryable<Pet> Query => context.Set<Pet>()
        .Include(p => p.Breed)
        .ThenInclude(b => b!.HealthIssues);

    public async Task<ICollection<Pet>> GetPetsByName(string name)
        => await Query.Where(p => p.NickName == name).ToListAsync();
}
