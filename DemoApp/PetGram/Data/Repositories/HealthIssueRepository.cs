using Microsoft.EntityFrameworkCore;
using PetGram.Core.Models;
using PetGram.Data.Repositories.Internal;

namespace PetGram.Data.Repositories;

public class HealthIssueRepository : BaseRepository<HealthIssue>
{
    public HealthIssueRepository(PetShopDbContext context)
        : base(context) { }

    protected override IQueryable<HealthIssue> Query => context.Set<HealthIssue>();

    public async Task<ICollection<HealthIssue>> GetByIds(ICollection<int> ids)
        => await Query
            .Where(health => ids.Contains(health.Id))
            .ToListAsync();
}