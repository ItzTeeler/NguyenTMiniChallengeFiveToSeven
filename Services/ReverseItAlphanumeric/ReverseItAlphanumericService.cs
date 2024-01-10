namespace NguyenTMiniChallengeFiveToSeven.Services.ReverseItAlphanumeric;

public class ReverseItAlphanumericService : IReverseItAlphanumericService
{
    public string ReverseItAlphanumeric(string number1orletter)
    {
        string reverse = "";
         for (int i = number1orletter.Length - 1; i>= 0; i--)
        {
            reverse += number1orletter[i];
        }
        return $"You entered {number1orletter}, reversed is {reverse}";
    }
}
