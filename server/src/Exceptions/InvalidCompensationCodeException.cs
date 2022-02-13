namespace Bank.Exceptions;

public class InvalidCompensationCodeException : Exception
{
    public static string Information = "Código de Compensação inválido.";
    public InvalidCompensationCodeException(string? message) : base(message) {}
}