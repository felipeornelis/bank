namespace Bank.Repositories;

public sealed class CategoryRepository : ICategoryRepository
{
    private List<Category> _repository = new()
    {
        new Category()
        {
            Name = "Oi",
            Icon = "https://genathus.com/deep.gif",
            Type = TransactionType.Expense,
            Id = Guid.Parse("3f041700-27b5-4817-814c-c69c89b8496b"),
            CreatedAt = DateTime.Parse("2022-02-13T14:48:22.7227205-03:00"),
            UpdatedAt = null,
            DeletedAt = null
        }
    };

    public Category Create(CreateCategoryDTO payload)
    {
        Category category = new Category()
        {
            Name = payload.Name,
            Icon = payload.Icon,
            Type = payload.Type,
        };

        _repository.Add(category);

        return category;
    }

    public void Delete(Guid id)
    {
        Category category = _repository.First<Category>(category => category.Id.Equals(id));
        int index = _repository.IndexOf(category);

        _repository[index].DeletedAt = DateTime.Now;
    }

    public List<Category> FindAll(bool deleted = false)
    {
        if(!deleted)
        {
            return _repository.Where<Category>(category => category.DeletedAt == null).ToList();
        }

        return _repository;
    }

    public Category? FindById(Guid id)
    {
        Category? category = _repository.FirstOrDefault<Category>(category => category.Id.Equals(id));

        return category;
    }

    public Category? FindByNameAndType(string name, TransactionType type)
    {
        Category? category = _repository.FirstOrDefault<Category>(category => category.Name.Equals(name) && category.Type.Equals(type));

        return category;
    }
}