namespace Bank.UseCases;

public class FindUserByIdService
{
    private readonly IUserRepository _repository;

    public FindUserByIdService(IUserRepository repository)
    {
        _repository = repository;
    }

    public User? Execute(Guid id)
    {
        User? findUser = _repository.FindById(id);

        if(findUser == null)
        {
            throw new UserNotFoundException(
                UserNotFoundException.Information
            );
        }

        return findUser;
    }
}