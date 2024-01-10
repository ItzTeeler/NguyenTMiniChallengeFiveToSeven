using Microsoft.AspNetCore.Mvc;
using NguyenTMiniChallengeFiveToSeven.Services.MadLib;

namespace NguyenTMiniChallengeFiveToSeven.Controllers;

[ApiController]
[Route("[controller]")]

    public class MadLibController : ControllerBase
    {
    private readonly IMadLibService _madLibService;

    public MadLibController(IMadLibService madLibService)
        {
        _madLibService = madLibService;
    }
    [HttpGet]
    [Route("MadLib/{gender}/{name}/{age}/{color}/{pronoun}/{food}/{job}/{adjective1}/{adjective2}/{adjective3}/{noun}")]
        public string MadLib(string gender, string name, string age, string color, string pronoun, string food, string job, string adjective1, string adjective2, string adjective3, string noun){
            return _madLibService.MadLib(gender, name, age, color, pronoun, food, job, adjective1, adjective2, adjective3, noun);
        }
    }
