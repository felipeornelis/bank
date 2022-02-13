namespace Bank.Repositories;

public interface IInstitutionRepository
{
    Institution Create(CreateInstitutionDTO payload);

    Institution? FindById(Guid id);

    Institution? FindByName(string name);
    
    Institution? FindByCompensantion(string compensation);

    List<Institution> FindAll();
}