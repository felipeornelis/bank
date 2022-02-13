namespace Bank.UseCases;

public class CreateCategoryService
{
    private readonly ICategoryRepository _repository;

    public CreateCategoryService(ICategoryRepository repository)
    {
        _repository = repository;
    }

    public Category Execute(CreateCategoryDTO payload)
    {
        if(payload.Name == "")
        {
            throw new NullRequiredFieldException(
                NullRequiredFieldException.Information
            );
        }

        if(!Enum.IsDefined<TransactionType>(payload.Type))
        {
            throw new InvalidTransactionTypeException(
                InvalidTransactionTypeException.Information
            );
        }

        Category? findCategory = _repository.FindByNameAndType(payload.Name, payload.Type);

        if(findCategory != null)
        {
            throw new CategoryExistsException(
                CategoryExistsException.Information
            );
        }

        Category category = _repository.Create(payload);

        return category;
    }
}