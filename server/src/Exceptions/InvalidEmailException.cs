namespace Bank.Exceptions;

public class InvalidEmailException : Exception
{
    public static string Information = "Faça o favor de informar um e-mail válido!";
    public InvalidEmailException(string? message) : base(message) {}
}