namespace Bank.UseCases;

public class DeleteCategoryService
{
    private readonly ICategoryRepository _repository;

    public DeleteCategoryService(ICategoryRepository repository)
    {
        _repository = repository;
    }

    public void Execute(Guid id)
    {
        Category? findCategory = _repository.FindById(id);

        if(findCategory == null)
        {
            throw new CategoryNotFoundException(
                CategoryNotFoundException.Information
            );
        }

        _repository.Delete(id);
    }
}