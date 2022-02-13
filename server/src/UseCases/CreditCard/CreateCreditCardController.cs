using Microsoft.AspNetCore.Mvc;

namespace Bank.UseCases;

[ApiController]
[Route("credit-card")]
public class CreateCreditCardController : ControllerBase
{
    private readonly CreateCreditCardService _service;

    public CreateCreditCardController(CreateCreditCardService service)
    {
        _service = service;
    }

    [HttpPost]
    public ActionResult<CreditCard> Handle([FromBody] CreateCreditCardDTO request)
    {
        try
        {
            CreditCard creditCard = _service.Execute(request);
            
            return creditCard;
        }
        catch(NullRequiredFieldException error)
        {
            return BadRequest(new { Error = error.Message });
        }
        catch(ArgumentOutOfRangeException error)
        {
            return BadRequest(new { Error = error.Message });
        }
        catch(UserNotFoundException error)
        {
            return NotFound(new { Error = error.Message });
        }
        catch(InstitutionNotFoundException error)
        {
            return NotFound(new { Error = error.Message });
        }
        catch(CreditCardExistsException error)
        {
            return Conflict(new { Error = error.Message });
        }
        catch(Exception)
        {
            return StatusCode(500);
        }
    }
}