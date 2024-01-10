using Microsoft.AspNetCore.Mvc;
using NguyenTMiniChallengeFiveToSeven.Services.ReverseItNumbersOnly;

namespace NguyenTMiniChallengeFiveToSeven.Controllers;
[ApiController]
[Route("[controller]")]
    public class ReverseItNumbersOnlyController : ControllerBase
    {
    private readonly IReverseItNumbersOnlyService _reverseItNumbersOnlyService;

    public ReverseItNumbersOnlyController(IReverseItNumbersOnlyService reverseItNumbersOnlyService)
        {
        _reverseItNumbersOnlyService = reverseItNumbersOnlyService;
    }
        [HttpGet]
        [Route("ReverseItNumbersOnly/{number1}")]
        public string ReverseItNumbersOnly (string number1){
            return _reverseItNumbersOnlyService.ReverseItNumbersOnly(number1);
        }
    }
