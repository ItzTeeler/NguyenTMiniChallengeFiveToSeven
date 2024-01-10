namespace NguyenTMiniChallengeFiveToSeven.Services.ReverseItAlphanumeric;

public class ReverseItAlphanumeric : IReverseItAlphanumeric
{
    string IReverseItAlphanumeric.ReverseItAlphanumeric(string number1)
    {
        string reverse = "";
         for (int i = number1.Length - 1; i>= 0; i--)
        {
            reverse += number1[i];
        }
        return reverse;
    }
}
