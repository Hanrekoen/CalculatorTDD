using Domain;

namespace CalculatorTDD
{
    public class UnitTest1
    {
        [Fact]
        public void Sum_Of_2_and_2_should_be_4()
        {
            var calculator = new Calculator();

            var result = calculator.Sum(2, 2);
            if (result != 4)
            {
                throw new Exception($"Expected 4 but got {result}");
            }
        }

        
        
    }
}
