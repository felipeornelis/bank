using Microsoft.AspNetCore.Mvc;

namespace Bank.UseCases;

[ApiController]
[Route("statements")]
public class CreateStatementController : ControllerBase
{
    private CreateStatementService _service;

    public CreateStatementController(CreateStatementService service)
    {
        _service = service;
    }

    [HttpPost]
    public ActionResult<Statement> Handle([FromBody] CreateStatementDTO request)
    {
        try
        {
            Statement statement = _service.Execute(request);

            return statement;
        }
        catch(InvalidStatementSituationException error)
        {
            return BadRequest(new { Error = error.Message });
        }
        catch(Exception)
        {
            return StatusCode(500);
        }
    }
}