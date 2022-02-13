namespace Bank.Exceptions;

public class UserNotFoundException : Exception
{
    public static string Information = "Usuário não encontrado";
    public UserNotFoundException(string? message) : base(message) {}
}