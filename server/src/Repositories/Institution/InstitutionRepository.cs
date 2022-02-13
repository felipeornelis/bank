namespace Bank.Repositories;

public class InstitutionRepository : IInstitutionRepository
{
    private List<Institution> _repository = new();

    public Institution Create(CreateInstitutionDTO payload)
    {
        Institution institution = new()
        {
            Name = payload.Name,
            Compensation = payload.Compensation,
            Icon = payload.Icon,
        };

        _repository.Add(institution);

        return institution;
    }

    public List<Institution> FindAll()
    {
        return _repository;
    }

    public Institution? FindByCompensantion(string compensation)
    {
        Institution? institution = _repository.FirstOrDefault<Institution>(institution => institution.Compensation.Equals(compensation));

        return institution;
    }

    public Institution? FindById(Guid id)
    {
        Institution? institution = _repository.FirstOrDefault<Institution>(institution => institution.Id.Equals(id));

        return institution;
    }

    public Institution? FindByName(string name)
    {
        Institution? institution = _repository.FirstOrDefault<Institution>(institution => institution.Name.Equals(name));

        return institution;
    }
}