using System;

namespace Calculator.CLI
{   
    public class InputConverter
    {
        public double convertInputToNumber(string argTextInput)
        {
            double convertedNumber;
            if (!double.TryParse(argTextInput, out convertedNumber)) throw new ArgumentException("Expected a numeric value.");
            return convertedNumber;
        }
    }
}