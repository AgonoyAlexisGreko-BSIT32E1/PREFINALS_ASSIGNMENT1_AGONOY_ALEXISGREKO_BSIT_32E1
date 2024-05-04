using Microsoft.AspNetCore.Mvc;
using System;


namespace ProtectedApi
{
    [ApiController]
    [Route("[controller]")]
    public class ValueController : ControllerBase
    {
        private readonly string _owner = "Alexis Greko Agonoy";
        private readonly Random _random = new Random();
        private readonly string[] _thingsAboutOwner = new[]
        {
            "I love playing basketball",
            "I enjoy riding motorcycle",
            "I like eating chickens",
            "Enjoying watching movies",
            "I love sleeping.",
            "I like playing computer games",
            "I like to go to the malls",
            "I love coffee",
            "I like playing in toms world",
            "I don't like backstabber"
        };


        [HttpGet("about/me")]
        public IActionResult AboutMe()
        {
            var thing = _thingsAboutOwner[_random.Next(_thingsAboutOwner.Length)];
            return Ok(thing);
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            return Ok(_owner);
           
        }

        

        [HttpPost("about")]
        public IActionResult About([FromBody] NameModel model)
        {
            return Ok($"Hi {model.Name} from {_owner}");
        }
    }

    public class NameModel
    {
        public string? Name { get; set; }
    }
}