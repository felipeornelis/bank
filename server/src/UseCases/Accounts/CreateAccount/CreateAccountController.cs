using Microsoft.AspNetCore.Mvc;

namespace Bank.UseCases;

[ApiController]
[Route("accounts")]
public class CreateAccountController : ControllerBase
{
    private readonly CreateAccountService _service;

    public CreateAccountController(CreateAccountService service)
    {
        _service = service;
    }

    [HttpPost]
    public ActionResult<Account> Handle([FromBody] CreateAccountDTO request)
    {
        try
        {
            Account account = _service.Execute(request);

            return account;
        }
        catch(NullRequiredFieldException error)
        {
            return BadRequest(new { Error = error.Message });
        }
        catch(InvalidAccountTypeException error)
        {
            return BadRequest(new { Error = error.Message });
        }
        catch(InvalidColorException error)
        {
            return BadRequest(new { Error = error.Message });
        }
        catch(InstitutionNotFoundException error)
        {
            return NotFound(new { Error = error.Message });
        }
        catch(AccountExistsException error)
        {
            return Conflict(new { Error = error.Message });
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