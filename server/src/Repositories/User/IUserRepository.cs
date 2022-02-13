namespace Bank.Repositories;

public interface IUserRepository
{
    User Create(CreateUserDTO payload);
    
    User? FindByUsername(string username, bool deleted = false);
    
    User? FindByEmail(string email, bool deleted = false);

    User? FindById(Guid id, bool deleted = false);
    
    void Delete(Guid id);
    
    List<User> FindAll(bool deleted = false);
}