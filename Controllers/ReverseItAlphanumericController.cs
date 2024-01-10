using Microsoft.AspNetCore.Mvc;
using NguyenTMiniChallengeFiveToSeven.Services.ReverseItAlphanumeric;

namespace NguyenTMiniChallengeFiveToSeven.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItAlphanumericController : ControllerBase
{
    private readonly IReverseItAlphanumeric _reverseItAlphanumeric;

    public ReverseItAlphanumericController(IReverseItAlphanumeric reverseItAlphanumeric)
    {
        _reverseItAlphanumeric = reverseItAlphanumeric;
    }
    [HttpGet]
    [Route("ReverseItAlphanumeric/{number1}")]
    public string ReverseItAlphanumeric(string number1)
    {
        return _reverseItAlphanumeric.ReverseItAlphanumeric(number1);
    }
}