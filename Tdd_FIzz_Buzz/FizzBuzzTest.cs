namespace Tdd_FIzz_Buzz
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Should_Return_Count()
        {
            var round = 100;
            var fizzBuzzClass = new FizzBuzz();
            var actual = fizzBuzzClass.Start(round);
            Assert.Equal(round, actual.Count);
        }

        [Fact]
        public void Should_Return_Fizz()
        {
            const int round= 100;
            var fizzBuzzClass= new FizzBuzz();
            var actual= fizzBuzzClass.Start(round);
            Assert.Equal("Fizz", actual[3]);
        }
        [Fact]
        public void Should_Return_Buzz()
        {
            const int round = 100;
            var fizzBuzzClass = new FizzBuzz();
            var actual = fizzBuzzClass.Start(round);
            Assert.Equal("Fizz", actual[6]);
        }

        [Fact]
        public void Should_Return_FizzBuzz()
        {
            const int round = 100;
            var fizzBuzzClass = new FizzBuzz();
            var actual = fizzBuzzClass.Start(round);
            Assert.Equal("FizzBuzz", actual[15]);
        }
    }

    public class FizzBuzz
    {
        

        public List<string> Start(int round)
        {
            var list=new List<string>();
            for (int i = 0; i < round; i++)
            {
                var output = i % 3 == 0 ? "Fizz" : "";
                output += i % 5 == 0 ? "Buzz" : "";
                output +=output== string.Empty?i.ToString():"";

               list.Add(output);
            }

            return list;
        }
    }
}