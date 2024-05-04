using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Authorize] // Requires authorization to access this controller
[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    // GET: api/values/userinfo
    [HttpGet("userinfo")]
    public ActionResult<UserInfo> GetUserInfo()
    {
        // Simulate getting user information (replace with your actual logic)
        var userInfo = new UserInfo
        {
            Name = User.Identity.Name, // Assuming you have set the user's name in claims
            Section = "32E1",
            Course = "BSIT"
        };
        return userInfo;
    }

    // GET: api/values/funfacts
    [HttpGet("funfacts")]
    public ActionResult<FunFacts> GetFunFacts()
    {
        // Simulate fun facts about the API creator
        var funFacts = new FunFacts
        {
            Facts = new List<string>
            {
                "I love coding challenges.",
                "I enjoy learning new technologies.",
                "I'm passionate about creating useful applications.",
                "I have a pet cat named Whiskers.",
                "I enjoy outdoor activities like hiking and camping.",
                "I'm a coffee enthusiast.",
                "I'm a fan of sci-fi movies and books.",
                "I love traveling and exploring new places.",
                "I'm a strong advocate for clean code and best practices.",
                "I'm always eager to help others learn and grow in programming."
            }
        };
        return funFacts;
    }

    public class UserInfo
    {
        public string Name { get; set; }
        public string Section { get; set; }
        public string Course { get; set; }
    }

    public class FunFacts
    {
        public List<string> Facts { get; set; }
    }
}