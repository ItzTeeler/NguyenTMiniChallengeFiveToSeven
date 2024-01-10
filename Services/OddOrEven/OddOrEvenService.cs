namespace NguyenTMiniChallengeFiveToSeven.Services.OddOrEven;

    public class OddOrEvenService : IOddOrEvenService
{
    public string OddOrEven(string number1)
    {
        int num1 = 0;
        bool isTrue1 = Int32.TryParse(number1, out num1);

        if (isTrue1 == true)
        {
            if (num1 % 2 == 0)
            {
                return $"{num1} that is an even number";
            }
            else
            {
                return $"{num1} that is an odd number";
            }
        }
        else
        {
            return "Please enter valid Numbers";
        }
    }
}
