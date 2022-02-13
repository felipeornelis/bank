namespace Bank.Exceptions;

public class InstitutionExistsException : Exception
{
    public static string Information = "Instituição Financeira já registrada.";
    public InstitutionExistsException(string? message) : base(message) {}
}