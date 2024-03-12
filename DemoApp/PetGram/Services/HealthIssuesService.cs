using PetGram.Core.Models;
using PetGram.Data.Repositories;

namespace PetGram.Services;

public class HealthIssuesService(HealthIssueRepository repository)
{
    public Task<int> Create(HealthIssue healthIssue) => repository.Create(healthIssue);

    public Task<ICollection<HealthIssue>> GetAll() => repository.GetAll();

    public Task Delete(int id) => repository.Delete(id);
}