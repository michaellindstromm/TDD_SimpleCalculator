using System;

namespace Calculator.CLI
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = inputConverter.convertInputToNumber(Console.ReadLine());
                double secondNumber = inputConverter.convertInputToNumber(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                // In real world we would want to log this exception. 
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
