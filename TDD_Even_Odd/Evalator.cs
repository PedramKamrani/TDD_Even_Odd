namespace TDD_Even_Odd
{
    public class Evalator
    {
        public  string WhichNumber(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }
    }
}
