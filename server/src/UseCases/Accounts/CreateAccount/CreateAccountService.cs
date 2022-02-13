namespace Bank.UseCases;

public class CreateAccountService
{
    private readonly IAccountRepository _repository;
    private readonly IInstitutionRepository _institutionRepository;
    private readonly IUserRepository _userRepository;

    public CreateAccountService(IAccountRepository repository, IInstitutionRepository institutionRepository, IUserRepository userRepository)
    {
        _repository = repository;
        _institutionRepository = institutionRepository;
        _userRepository = userRepository;
    }

    public Account Execute(CreateAccountDTO payload)
    {
        if(payload.Name == "")
        {
            throw new NullRequiredFieldException(
                NullRequiredFieldException.Information
            );
        }

        if(!Enum.IsDefined<AccountType>(payload.Type))
        {
            throw new InvalidAccountTypeException(
                InvalidAccountTypeException.Information
            );
        }

        if(!Enum.IsDefined<Colors>(payload.Color))
        {
            throw new InvalidColorException(
                InvalidColorException.Information
            );
        }

        Institution? findInstitution = _institutionRepository.FindById(payload.Institution);

        if(findInstitution == null)
        {
            throw new InstitutionNotFoundException(
                InstitutionNotFoundException.Information
            );
        }

        Account? findAccount = _repository.FindByName(payload.Name, payload.User);

        if(findAccount != null)
        {
            throw new AccountExistsException(
                AccountExistsException.Information
            );
        }

        User? findUserById = _userRepository.FindById(payload.User);

        if(findUserById == null)
        {
            throw new UserNotFoundException(
                UserNotFoundException.Information
            );
        }

        Account account = _repository.Create(payload);

        return account;
    }
}