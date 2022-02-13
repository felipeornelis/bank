using Microsoft.AspNetCore.Mvc;

namespace Bank.UseCases;

[ApiController]
[Route("users")]
public class CreateUserController : ControllerBase
{
    private readonly CreateUserService _service;

    public CreateUserController(CreateUserService service)
    {
        _service = service;
    }

    public ActionResult<User> Handle([FromBody] CreateUserDTO request)
    {
        try
        {
            User user = _service.Execute(request);

            return user;
        }
        catch(NullRequiredFieldException error)
        {
            return BadRequest(new { Error = error.Message });
        }
        catch(InvalidEmailException error)
        {
            return BadRequest(new { Error = error.Message });
        }
        catch(UsernameTakenException error)
        {
            return Conflict(new { Error = error.Message });
        }
        catch(RegisteredEmailException error)
        {
            return Conflict(new { Error = error.Message });
        }
        catch(Exception)
        {
            return StatusCode(500);
        }
    }
}