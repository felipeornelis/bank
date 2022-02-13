using System.Text.RegularExpressions;

namespace Bank.UseCases;

public class CreateUserService
{
    private readonly IUserRepository _repository;

    public CreateUserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public User Execute(CreateUserDTO payload)
    {

        if(payload.Email == "" || payload.Username == "" || payload.Password == "")
        {
            throw new NullRequiredFieldException(
                NullRequiredFieldException.Information
            );
        }

        if(payload.Username.Length < 3)
        {
            throw new InvalidUsernameException(
                String.Format(InvalidUsernameException.Information, "nome de usuário não pode ter menos que 3 caracteres")
            );
        }

        // if(!Regex.IsMatch(payload.Username, "/(w+)/giu"))
        // {
        //     throw new InvalidUsernameException(
        //         String.Format(InvalidUsernameException.Information, "nome de usuário pode conter somente letras, números e underscore (-).")
        //     );
        // }

        if(!payload.Email.ValidateEmail())
        {
            throw new InvalidEmailException(
                InvalidEmailException.Information
            );
        }

        User? findUserByUsername = _repository.FindByUsername(payload.Username, true);

        if(findUserByUsername != null)
        {
            throw new UsernameTakenException(
                UsernameTakenException.Information
            );
        }

        User? findUserByEmail = _repository.FindByEmail(payload.Email, true);

        if(findUserByEmail != null)
        {
            throw new RegisteredEmailException(
                RegisteredEmailException.Information
            );
        }

        User user = _repository.Create(payload);

        return user;
    }
}