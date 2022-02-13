namespace Bank.Repositories;

public interface ICreditCardRepository
{
    CreditCard Create(CreateCreditCardDTO payload);
    CreditCard? FindByNameAndUser(string name, Guid user);
}