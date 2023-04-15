namespace Tdd_FIzz_Buzz
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Should_Return_Count()
        {
            var round = 100;
            var actual = FizzBuzz.Start(round);
            Assert.Equal(round, actual.Count);
        }

        [Fact]
        public void Should_Return_Fizz()
        {
            const int round= 100;
            var actual= FizzBuzz.Start(round);
            Assert.Equal("Fizz", actual[3]);
        }
        [Fact]
        public void Should_Return_Buzz()
        {
            const int round = 100;
            var actual = FizzBuzz.Start(round);
            Assert.Equal("Fizz", actual[6]);
        }

        [Fact]
        public void Should_Return_FizzBuzz()
        {
            const int round = 100;
            var actual = FizzBuzz.Start(round);
            Assert.Equal("FizzBuzz", actual[15]);
        }
    }
}