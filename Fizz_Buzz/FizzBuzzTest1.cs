namespace Fizz_Buzz
{
    public class FizzBuzzTest1
    {
        [Fact]
        public void Should_Return_Count_Inter()
        {
            var round = 100;
            var sourceClass = new FizzBuzzClass();
            var actual = sourceClass.Start(round);
            Assert.Equal(round,actual.Count);
        }

        [Theory]
        [InlineData("Fizz", 3)]
        [InlineData("Buzz", 5)]
        [InlineData("FizzBuzz", 15)]
        public void Should_Return_Which_Word(string excepted, int actualIndex)
        {
            var round = 100;
            var sourceClass = new FizzBuzzClass();
            var actual = sourceClass.Start(round);
            Assert.Equal(excepted, actual[actualIndex]);
          
        }
    }
}