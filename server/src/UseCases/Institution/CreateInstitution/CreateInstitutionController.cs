using Microsoft.AspNetCore.Mvc;

namespace Bank.UseCases;

[ApiController]
[Route("institutions")]
public class CreateInstitutionController : ControllerBase
{
    private CreateInstitutionService _service;

    public CreateInstitutionController(CreateInstitutionService service)
    {
        _service = service;
    }

    [HttpPost]
    public ActionResult<Institution> Handle([FromBody] CreateInstitutionDTO request)
    {
        try
        {
            Institution institution = _service.Execute(request);

            return institution;
        }
        catch(InstitutionExistsException error)
        {
            return Conflict(new { Error = error.Message });
        }
        catch(InvalidCompensationCodeException error)
        {
            return Conflict(new { Error = error.Message });
        }
        catch(Exception)
        {
            return StatusCode(500);
        }
    }
}