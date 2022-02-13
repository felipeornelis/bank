using Microsoft.AspNetCore.Mvc;

namespace Bank.UseCases;

[ApiController]
[Route("institutions")]
public class ListAllInstitutionsController : ControllerBase
{
    private readonly ListAllInstitutionsService _service;

    public ListAllInstitutionsController(ListAllInstitutionsService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult<List<Institution>> Handle()
    {
        try
        {
            List<Institution> institutions = _service.Execute();

            return institutions;
        }
        catch(Exception)
        {
            return StatusCode(500);
        }
    }
}