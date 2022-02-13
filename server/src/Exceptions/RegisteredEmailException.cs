namespace Bank.Exceptions;

public class RegisteredEmailException : Exception
{
    public static string Information = "Já criaram uma conta com esse e-mail";
    public RegisteredEmailException(string? message) : base(message) {}
}