using Microsoft.AspNetCore.Mvc;

namespace BluewayTests.Controllers;

[ApiController]
[Route("[controller]")]
public class AnythingController : ControllerBase
{
    [HttpPost]
    public async Task<IEnumerable<int>> PostAnything()
    {
        using var bodyStream = new StreamReader(HttpContext.Request.Body);
        Console.WriteLine(await bodyStream.ReadToEndAsync());
        return [1,2,3];
    }
}