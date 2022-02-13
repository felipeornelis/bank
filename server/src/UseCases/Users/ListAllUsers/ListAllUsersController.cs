using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace Bank.UseCases;

[ApiController]
[Route("users")]
public class ListAllUsersController : ControllerBase
{
    private readonly ListAllUsersService _service;

    public ListAllUsersController(ListAllUsersService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult<List<User>> Handle()
    {
        try
        {
            List<User> users = _service.Execute();

            return Ok(new { Users = users });
        }
        catch(Exception)
        {
            return StatusCode(500);
        }
    }
}