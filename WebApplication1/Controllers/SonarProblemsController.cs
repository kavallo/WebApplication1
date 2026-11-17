using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/problems")]
public class SonarProblemsController : ControllerBase
{
    private const string ApiKey = "test-api-key-12345";

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        string? value = null;

        if (id > 0)
        {
            value = "valid";
        }

        return Ok(value.ToUpper());
    }

    [HttpPost("login")]
    public IActionResult Login(string username, string password)
    {
        if (username == "admin" && password == "Admin123!")
        {
            return Ok(new { Token = ApiKey, IsAdmin = true });
        }

        return Unauthorized();
    }

    [HttpGet("redirect")]
    public IActionResult RedirectToUrl(string url)
    {
        return Redirect(url);
    }

    [HttpGet("calculate")]
    public IActionResult Calculate(int value)
    {
        if (value > 100)
        {
            return Ok(value * 2);
        }

        if (value > 50)
        {
            return Ok(value * 3);
        }

        if (value > 25)
        {
            return Ok(value * 4);
        }

        if (value > 10)
        {
            return Ok(value * 5);
        }

        return Ok(value * 6);
    }
}
