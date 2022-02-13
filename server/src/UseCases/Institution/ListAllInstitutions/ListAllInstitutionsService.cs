namespace Bank.UseCases;

public class ListAllInstitutionsService
{
    private readonly IInstitutionRepository _repository;

    public ListAllInstitutionsService(IInstitutionRepository repository)
    {
        _repository = repository;
    }

    public List<Institution> Execute()
    {
        List<Institution> institutions = _repository.FindAll();

        return institutions;
    }
}