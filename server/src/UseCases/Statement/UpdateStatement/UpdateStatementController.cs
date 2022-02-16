using Microsoft.AspNetCore.Mvc;

namespace Bank.UseCases;

[ApiController]
[Route("statements")]
public class UpdateStatementController : ControllerBase
{
    private UpdateStatementService _service;

    public UpdateStatementController(UpdateStatementService service)
    {
        _service = service;
    }

    [HttpPatch("{id}")]
    public ActionResult<Statement> Handle([FromBody] UpdateStatementDTO request, [FromRoute] Guid id)
    {
        try
        {
            Statement statement = _service.Execute(request, id);

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