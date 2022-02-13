namespace Bank.Exceptions;

public class InstitutionNotFoundException : Exception
{
    public static string Information = "Instituição Financeira não encontrada. Pode até ser que ela exista, mas não aqui.";
    public InstitutionNotFoundException(string? message) : base(message) {}
}