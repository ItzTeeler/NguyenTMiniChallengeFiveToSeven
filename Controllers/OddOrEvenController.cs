using Microsoft.AspNetCore.Mvc;
using NguyenTMiniChallengeFiveToSeven.Services.OddOrEven;

namespace NguyenTMiniChallengeFiveToSeven.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
    private readonly IOddOrEvenService _oddOrEvenService;

    public OddOrEvenController(IOddOrEvenService oddOrEvenService)
{
        _oddOrEvenService = oddOrEvenService;
    }
    [HttpGet]
    [Route("OddOrEven/{number1}")]
    public string OddOrEven(string number1){
        return _oddOrEvenService.OddOrEven(number1);
    }
}
