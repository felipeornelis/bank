namespace Bank.Exceptions;

public class InvalidUsernameException : Exception
{
    public static string Information = "Nome de usuário inválido: {0}";
    public InvalidUsernameException(string? message) : base(message) {}
}