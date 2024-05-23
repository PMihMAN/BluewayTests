using Microsoft.AspNetCore.Mvc;

namespace BluewayTests.Controllers;

[ApiController]
[Route("[controller]")]
public class Anything2Controller : ControllerBase
{
    [HttpPost]
    [ReadableBodyStream]
    public async Task<IEnumerable<int>> PostAnthing2(int int1, int int2, int int3)
    {
        Console.WriteLine("Anything2");
        HttpContext.Request.Body.Seek(0, SeekOrigin.Begin);
        using var bodyStream = new StreamReader(HttpContext.Request.Body);
        Console.WriteLine(await bodyStream.ReadToEndAsync());
        return [4, 5, 6];
    }
}