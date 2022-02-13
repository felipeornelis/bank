using Microsoft.AspNetCore.Mvc;

namespace Bank.UseCases;

[ApiController]
[Route("users")]
public class FindUserByIdController : ControllerBase
{
    private readonly FindUserByIdService _service;

    public FindUserByIdController(FindUserByIdService service)
    {
        _service = service;
    }

    [HttpGet("{id:Guid}")]
    public ActionResult<User?> Handle([FromRoute] Guid id)
    {
        try
        {
            User? user = _service.Execute(id);

            return user;
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