using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace DTOs.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly Database database;

    public UsersController(Database database)
    {
        this.database = database;
    }

    [HttpGet("api/users/{id}")]
    public IActionResult GetUser(int id)
    {
        var user = database.Users.SingleOrDefault(user => user.Id == id);
        if (user == null)
        {
            return NotFound();
        }

        var userDto = new UserDto
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email
        };

        return Ok(userDto);
    }
}
