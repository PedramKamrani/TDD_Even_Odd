namespace TDD_Even_Odd
{
    public class ElavatorTest
    {

        [Fact]
        public void Should_Return_Even()
        {
            var input = 6;
            var evalaotor = new Evalator();
            var actual = evalaotor.WhichNumber(input);
            Assert.Equal("Even", actual);
        }
        [Fact]
        public void Should_Return_Odd()
        {
            var input = 6;
            var evalator = new Evalator();
            var actual = evalator.WhichNumber(input);
            Assert.Equal("Even", actual);
          
        }
    }
}