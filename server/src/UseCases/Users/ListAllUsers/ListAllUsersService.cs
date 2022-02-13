namespace Bank.UseCases;

public class ListAllUsersService
{
    private readonly IUserRepository _repository;

    public ListAllUsersService(IUserRepository repository)
    {
        _repository = repository;
    }

    public List<User> Execute(bool deleted = false)
    {
        List<User> users = _repository.FindAll();

        return users;
    }
}