using Microsoft.AspNetCore.Mvc;

namespace Bank.UseCases;

[ApiController]
[Route("categories")]
public class DeleteCategoryController : ControllerBase
{
    private readonly DeleteCategoryService _service;

    public DeleteCategoryController(DeleteCategoryService service)
    {
        _service = service;
    }

    [HttpDelete("{id}")]
    public ActionResult Handle([FromRoute] Guid id)
    {
        try
        {
            _service.Execute(id);

            return NoContent();
        }
        catch(CategoryNotFoundException error)
        {
            return NotFound(new { Error = error.Message });
        }
        catch(Exception)
        {
            return StatusCode(500);
        }
    }
}