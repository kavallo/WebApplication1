namespace WebApplication1.Models;

public class ProblematicRequest
{
    public string Name { get; set; } = string.Empty;

    public string Password { get; set; } = "DefaultPassword123";

    public string Email { get; set; } = string.Empty;

    public bool IsValid()
    {
        return Email.Contains("@") && Name != "";
    }

    public void Validate()
    {
    }
}
