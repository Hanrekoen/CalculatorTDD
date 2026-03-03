using Domain;
using FluentAssertions;

namespace CalculatorTDD
{
    public class UnitTest1
    {
        [Fact]
        public void Sum_Of_2_and_2_should_be_4()
        => new Calculator()
            .Sum(2, 2)
            .Should().Be(4);



    }
}
