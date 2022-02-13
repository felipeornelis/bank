namespace Bank.Exceptions;

public class CreditCardExistsException : Exception
{
    public static string Information = "Você já cadastrou um cartão com esse nome, cabeção!";
    public CreditCardExistsException(string? message) : base(message) {}
}