using Microsoft.AspNetCore.Mvc;

namespace Bank.UseCases;

[ApiController]
[Route("categories")]
public class ListAllCategoriesController : ControllerBase
{
    private readonly ListAllCategoriesService _service;

    public ListAllCategoriesController(ListAllCategoriesService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult<List<Category>> Handle()
    {
        try
        {
            List<Category> categories = _service.Execute();

            return Ok(new { Categories = categories });
        }
        catch(Exception)
        {
            return StatusCode(500);
        }
    }
}