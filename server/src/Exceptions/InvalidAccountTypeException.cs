namespace Bank.Exceptions;

public class InvalidAccountTypeException : Exception
{
    public static string Information = "Tipo de conta inválido. Escolha uma das opções válidas e não invente moda.";
    public InvalidAccountTypeException(string? message) : base(message) {}
}