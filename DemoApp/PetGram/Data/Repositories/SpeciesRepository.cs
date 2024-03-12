using PetGram.Core.Models;
using PetGram.Data.Repositories.Internal;

namespace PetGram.Data.Repositories;

public class SpeciesRepository : BaseRepository<Species>
{
    public SpeciesRepository(PetShopDbContext context)
        : base(context) { }

    protected override IQueryable<Species> Query => context.Set<Species>();
}
