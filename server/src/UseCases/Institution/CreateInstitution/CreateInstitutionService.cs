namespace Bank.UseCases;

public class CreateInstitutionService
{
    private readonly IInstitutionRepository _repository;

    public CreateInstitutionService(IInstitutionRepository repository)
    {
        _repository = repository;
    }

    public Institution Execute(CreateInstitutionDTO payload)
    {
        if(payload.Name == "" || payload.Icon == "")
        {
            throw new NullRequiredFieldException(
                NullRequiredFieldException.Information
            );
        }

        if(payload.Compensation.Length != 3)
        {
            throw new InvalidCompensationCodeException(
                InvalidCompensationCodeException.Information
            );
        }

        Institution? findInstitutionByName = _repository.FindByName(payload.Name);

        if(findInstitutionByName != null)
        {
            throw new InstitutionExistsException(
                InstitutionExistsException.Information
            );
        }

        Institution? findInstitutionByCompensation = _repository.FindByCompensantion(payload.Compensation);

        if(findInstitutionByCompensation != null)
        {
            throw new InstitutionExistsException(
                String.Format("O Código de Compensação {0} pertence à instituição {1}", payload.Compensation, findInstitutionByCompensation.Name)
            );
        }

        Institution institution = _repository.Create(payload);

        return institution;        
    }
}