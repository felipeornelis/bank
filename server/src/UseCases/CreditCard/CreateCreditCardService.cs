namespace Bank.UseCases;

public class CreateCreditCardService
{
    private readonly ICreditCardRepository _repository;
    private readonly IInstitutionRepository _institutionRepository;
    private readonly IUserRepository _userRepository;

    public CreateCreditCardService(ICreditCardRepository repository, IInstitutionRepository institutionRepository, IUserRepository userRepository)
    {
        _repository = repository;
        _institutionRepository = institutionRepository;
        _userRepository = userRepository;
    }

    public CreditCard Execute(CreateCreditCardDTO payload)
    {
        if(payload.Name == "")
        {
            throw new NullRequiredFieldException(
                NullRequiredFieldException.Information
            );
        }

        if(!Enumerable.Range(1, 31).Contains(payload.PaymentDueDate))
        {
            throw new ArgumentOutOfRangeException(
                "Dia inválido para data de pagamento"
            );
        }
        

        if(!Enumerable.Range(1, 31).Contains(payload.StatementClosingDate))
        {
            throw new ArgumentOutOfRangeException(
                "Dia inválido para data de fechamento da fatura"
            );
        }

        User? findUserById = _userRepository.FindById(payload.User);

        if(findUserById == null)
        {
            throw new UserNotFoundException(
                UserNotFoundException.Information
            );
        }

        Institution? findInstitutionById = _institutionRepository.FindById(payload.Institution);

        if(findInstitutionById == null)
        {
            throw new InstitutionNotFoundException(
                InstitutionNotFoundException.Information
            );
        }

        CreditCard? findCreditCardByNameAndUser = _repository.FindByNameAndUser(payload.Name, payload.User);

        if(findCreditCardByNameAndUser == null)
        {
            throw new CreditCardExistsException(
                CreditCardExistsException.Information
            );
        }

        CreditCard creditCard = _repository.Create(payload);

        return creditCard;
    }


}