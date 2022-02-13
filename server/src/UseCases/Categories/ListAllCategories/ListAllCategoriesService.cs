namespace Bank.UseCases;

public class ListAllCategoriesService
{
    private ICategoryRepository _repository;

    public ListAllCategoriesService(ICategoryRepository repository)
    {
        _repository = repository;
    }

    public List<Category> Execute()
    {
        List<Category> categories = _repository.FindAll();

        return categories;
    }
}