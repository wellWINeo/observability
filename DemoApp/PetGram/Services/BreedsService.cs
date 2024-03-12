using PetGram.Core.Exceptions;
using PetGram.Core.Models;
using PetGram.Data.Repositories;

namespace PetGram.Services;

public class BreedsService(
    BreedsRepository breedsRepository, 
    HealthIssueRepository healthIssueRepository)
{
    public async Task<int> Create(Breed breed)
    {
        await LoadHealthIssues(breed);

        return await breedsRepository.Create(breed);
    }

    public async Task<ICollection<Breed>> GetAll()
        => await breedsRepository.GetAll();

    public async Task Update(Breed breed)
    {
        if (!await breedsRepository.Exists(breed.Id))
        {
            throw new EntityNotFoundException<Breed>(breed.Id);
        }
        
        breed.HealthIssues = null!;
        await breedsRepository.Update(breed);
    }

    public async Task Delete(int id)
    {
        if (await breedsRepository.Delete(id) == 0)
            throw new EntityNotFoundException<Breed>(id);
    }

    private async Task LoadHealthIssues(Breed breed)
    {
        var healthIssuesIds = breed.HealthIssues
            .Select(hi => hi.Id)
            .ToArray();

        breed.HealthIssues = await healthIssueRepository.GetByIds(healthIssuesIds);
    }
}
