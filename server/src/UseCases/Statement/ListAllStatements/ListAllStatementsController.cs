using Microsoft.AspNetCore.Mvc;

namespace Bank.UseCases;

[ApiController]
[Route("statements")]
public class ListAllStatementsController : ControllerBase
{
    private ListAllStatementsService _service;

    public ListAllStatementsController(ListAllStatementsService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public ActionResult<List<Statement>> Handle([FromRoute] Guid id)
    {
        try
        {
            List<Statement> statements = _service.Execute(id);

            return Ok(new { Statements = statements });
        }
        catch(StatementNotFound error)
        {
            return BadRequest(new { Error = error.Message });
        }
        catch(Exception)
        {
            return StatusCode(500);
        }
    }
}