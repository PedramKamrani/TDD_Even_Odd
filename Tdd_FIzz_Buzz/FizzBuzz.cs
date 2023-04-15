namespace Tdd_FIzz_Buzz;

public class FizzBuzz
{
        

    public static List<string> Start(int round)
    {
        var list=new List<string>();
        for (var i = 0; i < round; i++)
        {
            var output = i % 3 == 0 ? "Fizz" : "";
            output += i % 5 == 0 ? "Buzz" : "";
            output +=output== string.Empty?i.ToString():"";

            list.Add(output);
        }

        return list;
    }
}