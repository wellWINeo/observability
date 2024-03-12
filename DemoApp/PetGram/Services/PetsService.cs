using EntityFramework.Exceptions.Common;
using PetGram.Core.Exceptions;
using PetGram.Core.Models;
using PetGram.Data.Repositories;

namespace PetGram.Services;

public class PetsService(
    PetsRepository petsRepository,
    ILogger<PetsService> logger)
{
    public async Task<Pet> CreatePet(Pet pet)
    {
        logger.LogInformation($"Creating pet with name {pet.NickName}");

        if (pet.NickName == "nigger")
        {
            throw new InvalidOperationException("Cannot create pet with such name");
        }

        try
        {
            await petsRepository.Create(pet);
        }
        catch (UniqueConstraintException ex)
        {
            throw new NickTakenException(pet.NickName, ex);
        }

        return pet;
    }

    public Task<Pet?> GetPetById(int id)
        => petsRepository.Get(id);

    public Task<ICollection<Pet>> GetPetsByName(string name)
        => petsRepository.GetPetsByName(name);

    public async Task<Pet?> GetPetByName(string name)
    {
        var pets = await petsRepository.GetPetsByName(name);

        return pets.FirstOrDefault();
    }

    public async Task<Pet> UpdatePet(Pet pet)
    {
        await petsRepository.Update(pet);
        return pet;
    }

    public Task DeletePet(int id)
        => petsRepository.Delete(id);
}
