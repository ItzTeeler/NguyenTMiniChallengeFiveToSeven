using Microsoft.AspNetCore.Mvc;
using NguyenTMiniChallengeFiveToSeven.Services.ReverseItAlphanumeric;

namespace NguyenTMiniChallengeFiveToSeven.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItAlphanumericController : ControllerBase
{
    private readonly IReverseItAlphanumericService _reverseItAlphanumericService;

    public ReverseItAlphanumericController(IReverseItAlphanumericService reverseItAlphanumericService)
{
        _reverseItAlphanumericService = reverseItAlphanumericService;
    }
    
    [HttpGet]
    [Route("ReverseItAlphanumeric/{number1orletter}")]
    public string ReverseItAlphanumeric(string number1orletter)
    {
        return _reverseItAlphanumericService.ReverseItAlphanumeric(number1orletter);
    }
}
