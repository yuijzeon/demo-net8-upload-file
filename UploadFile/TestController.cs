using Microsoft.AspNetCore.Mvc;

namespace UploadFile;

public class TestController : ControllerBase
{
    [HttpPut("/test")]
    public OkResult UploadFile([FromForm] IFormFile file)
    {
        Console.WriteLine(file.FileName);
        return Ok();
    }
}