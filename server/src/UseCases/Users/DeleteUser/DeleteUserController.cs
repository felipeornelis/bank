using Microsoft.AspNetCore.Mvc;

namespace Bank.UseCases;

[ApiController]
[Route("users")]
public class DeleteUserController : ControllerBase
{
    private readonly DeleteUserService _service;

    public DeleteUserController(DeleteUserService service)
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
        catch(UserNotFoundException error)
        {
            return NotFound(new { Error = error.Message });
        }
        catch(Exception)
        {
            return StatusCode(500);
        }
    }
}

