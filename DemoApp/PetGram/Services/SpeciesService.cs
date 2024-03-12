using PetGram.Core.Models;
using PetGram.Data.Repositories;

namespace PetGram.Services;

public class SpeciesService(SpeciesRepository repository)
{
    public Task<int> Create(Species species) => repository.Create(species);

    public Task<ICollection<Species>> GetAll() => repository.GetAll();

    public Task Update(Species species) => repository.Update(species);

    public Task Delete(int id) => repository.Delete(id);
}