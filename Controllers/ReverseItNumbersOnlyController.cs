using Microsoft.AspNetCore.Mvc;
using NguyenTMiniChallengeFiveToSeven.Services.ReverseItNumbersOnly;

namespace NguyenTMiniChallengeFiveToSeven.Controllers;
[ApiController]
[Route("[controller]")]
    public class ReverseItNumbersOnlyController : ControllerBase
    {
    private readonly IReverseItNumbersOnly _reverseItNumbersOnly;

    public ReverseItNumbersOnlyController(IReverseItNumbersOnly reverseItNumbersOnly)
        {
        _reverseItNumbersOnly = reverseItNumbersOnly;
    }
        [HttpGet]
        [Route("ReverseItNumbersOnly/{number1}")]
        public string ReverseItNumbersOnly (string number1){
            return _reverseItNumbersOnly.ReverseItNumbersOnly(number1);
        }
    }
