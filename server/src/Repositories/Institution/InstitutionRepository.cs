namespace Bank.Repositories;

public class InstitutionRepository : IInstitutionRepository
{
    private List<Institution> _repository = new()
    {
        new Institution()
        {
            Name = "Picpay",
            Compensation = "237",
            Icon = "https://genathus.com/img/picpay.png",
            Id = Guid.Parse("43f48f96-a447-4bce-add7-9533d1557430"),
            CreatedAt = DateTime.Parse("2022-02-13T17:00:54.6695811-03:00"),
            UpdatedAt = null,
            DeletedAt = null
        }
    };

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