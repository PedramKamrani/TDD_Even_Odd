namespace TDD_Even_Odd_Two
{
    public class EvaluatorTest
    {
        [Fact]
        public void Should_Evaluator_Even()
        {
            const int input = 2;
            var actual = Evaluator.EvaluatorMethod(input);
            Assert.Equal("Even",actual);
        }
        [Fact]
        public void Should_Evaluator_Odd()
        {
            const  int input = 5;
            var actual = Evaluator.EvaluatorMethod(input);
            Assert.Equal("Odd", actual);
        }
    }
}