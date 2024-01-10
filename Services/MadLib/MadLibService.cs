namespace NguyenTMiniChallengeFiveToSeven.Services.MadLib;

public class MadLibService : IMadLibService
{
    public string MadLib(string gender, string name, string age, string color, string pronoun, string food, string job, string adjective1, string adjective2, string adjective3, string noun)
    {
        return $"A young {gender}, aged {age} named {name} sat down at a restaurant to enjoy a (n) {adjective1} {food} which was for some reason colored {color}. {pronoun} works at a {adjective2} {job} that made the workers eat a (n) {adjective3} {noun} ON THE JOB.";
    }
}
