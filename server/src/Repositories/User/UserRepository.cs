namespace Bank.Repositories;

public class UserRepository : IUserRepository
{
    private readonly List<User> _repository = new();

    public User Create(CreateUserDTO payload)
    {
        User user = new User()
        {
            Name = payload.Name,
            Username = payload.Username,
            Email = payload.Email,
            Password = payload.Password,
        };

        _repository.Add(user);

        return user;
    }

    public User? FindByUsername(string username, bool deleted = false)
    {
        User? user = _repository.FirstOrDefault<User>(user => user.Username.Equals(username));

        if(user != null && user.DeletedAt != null && deleted == false)
        {
            user = null;
        }

        return user;
    }

    public User? FindByEmail(string email, bool deleted = false)
    {
        User? user = _repository.FirstOrDefault<User>(user => user.Email.Equals(email));

        if(user != null && user.DeletedAt != null && deleted == false)
        {
            user = null;
        }

        return user;
    }

    public User? FindById(Guid id, bool deleted = false)
    {
        User? user = _repository.FirstOrDefault<User>(user => user.Id.Equals(id));

        if(user != null && user.DeletedAt != null && deleted == false)
        {
            user = null;
        }

        return user;
    }

    public void Delete(Guid id)
    {
        User user = _repository.First<User>(user => user.Id.Equals(id));
        int index = _repository.IndexOf(user);

        user.DeletedAt = DateTime.Now;

        _repository[index] = user;
    }

    public List<User> FindAll(bool deleted = false)
    {
        if(!deleted)
        {
            return _repository.Where<User>(user => user.DeletedAt == null).ToList();
        }

        return _repository;
    }

}