// Mark A Ramirez
// 10/25/2022
// Asking Questions
// this will take you name and time you woke up and say good job
// Peer reviwed by: Kent Tupas the program works, no errors at all besides forgetting you after name.



using Microsoft.AspNetCore.Mvc;

namespace RamirezMAsking_Questions___Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AskingQuestionsController : ControllerBase
{

    [HttpGet]
    [Route("Asking/{name}/{time}")]

    public string asking(string name, string time)
    {
        return $"wow {name} woke up at {time} good job";
    }

}
