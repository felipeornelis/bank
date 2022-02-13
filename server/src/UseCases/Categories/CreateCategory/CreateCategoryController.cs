using Microsoft.AspNetCore.Mvc;

namespace Bank.UseCases;

[ApiController]
[Route("categories")]
public class CreateCategoryController : ControllerBase
{
    private readonly CreateCategoryService _service;

    public CreateCategoryController(CreateCategoryService service)
    {
        _service = service;
    }

    [HttpPost]
    public ActionResult<Category> Handle([FromBody] CreateCategoryDTO request)
    {
        try
        {
            Category category = _service.Execute(request);

            return category;
        }
        catch(NullRequiredFieldException error)
        {
            return BadRequest(new { Error = error.Message });
        }
        catch(InvalidTransactionTypeException error)
        {
            return BadRequest(new { Error = error.Message });
        }
        catch(CategoryExistsException error)
        {
            return Conflict(new { Error = error.Message });
        }
        catch(Exception)
        {
            StatusCode(500);
            return NoContent();
        }
    }
}