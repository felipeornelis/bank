namespace Bank.Repositories;

public interface ICategoryRepository
{
    Category Create(CreateCategoryDTO payload);
    Category? FindByNameAndType(string name, TransactionType type);
    Category? FindById(Guid id);

    List<Category> FindAll(bool deleted = false);
    void Delete(Guid id);
}