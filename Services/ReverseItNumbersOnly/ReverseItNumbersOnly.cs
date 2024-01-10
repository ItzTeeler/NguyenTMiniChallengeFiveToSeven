namespace NguyenTMiniChallengeFiveToSeven.Services.ReverseItNumbersOnly;

public class ReverseItNumbersOnly : IReverseItNumbersOnly
{
    string IReverseItNumbersOnly.ReverseItNumbersOnly(string number1)
    {
        double num1 = 0;
        bool isTrue1 = Double.TryParse(number1, out num1);
        if (isTrue1 == true)
        {
            string reverse = "";
            for (int i = number1.Length - 1; i >= 0; i--)
            {
                reverse += number1[i];
            }
            return reverse;
        }
        else
        {
            return "Please enter valid Numbers";
        }
    }
}
