using System;
using Xunit;
using Calculator.CLI;

namespace Calculator.Test
{
    public class CalculatorEngineTest
    {

        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [Fact]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.calculate("add", number1, number2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.calculate("+", number1, number2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void SubtractsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 2;
            int number2 = 1;
            double result = _calculatorEngine.calculate("minus", number1, number2);
            Assert.Equal(1, result);
        }

        [Fact]
        public void SubtractsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 2;
            int number2 = 1;
            double result = _calculatorEngine.calculate("-", number1, number2);
            Assert.Equal(1, result);
        }

        [Fact]
        public void MultipliesTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 3;
            int number2 = 2;
            double result = _calculatorEngine.calculate("multiply", number1, number2);
            Assert.Equal(6, result);
        }

        [Fact]
        public void MultipliesTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 3;
            int number2 = 2;
            double result = _calculatorEngine.calculate("*", number1, number2);
            Assert.Equal(6, result);
        }

        [Fact]
        public void DividesTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 6;
            int number2 = 2;
            double result = _calculatorEngine.calculate("divide", number1, number2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void DividesTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 6;
            int number2 = 2;
            double result = _calculatorEngine.calculate("/", number1, number2);
            Assert.Equal(3, result);
        }
    }
}
