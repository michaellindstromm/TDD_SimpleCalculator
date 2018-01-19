using System;
using Xunit;
using Calculator.CLI;

namespace Calculator.Test
{
    public class InputConverterTest
    {

        private readonly InputConverter _inputConverter = new InputConverter();

        [Fact]
        public void ConvertValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.convertInputToNumber(inputNumber);
            Assert.Equal(5, convertedNumber);
        }

        [Fact]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputNumber = "*";

            Exception ex = Assert.Throws<ArgumentException>( delegate { _inputConverter.convertInputToNumber(inputNumber); } );

            Assert.NotNull(ex);
        }
    }
}