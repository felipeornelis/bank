namespace Bank.UseCases;

public class DeleteUserService
{
    private readonly IUserRepository _repository;

    public DeleteUserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public void Execute(Guid id)
    {
        User? user = _repository.FindById(id);

        if(user == null)
        {
            throw new UserNotFoundException(
                UserNotFoundException.Information
            );
        }

        _repository.Delete(id);
    }
}