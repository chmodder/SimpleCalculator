using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class InsertCodeHere
    {
        public void Run()
        {
            //Ask for first value (out parameter is for testing)
            string userInput;
            int value1 = EnterValue("value 1", out userInput);

            //Ask for second value (out parameter is for testing)
            int value2 = EnterValue("value 2", out userInput);

            //Ask user for mathOperation
            Console.WriteLine("Which Math operation would you like to do:");
            Console.WriteLine("(M)ultiply, (D)ivide, (A)dd or (S)ubtract?");
            string mathOperator = EnterMathOperator();

            //calculate result
            int result = Calculate(value1, value2, mathOperator);
            Console.WriteLine("Result is {0}", result);

        }

        private int Calculate(int value1, int value2, string mathOperator)
        {
            int result = 0;

            //Calculates value1 and value2
            switch (mathOperator)
            {
                case "M":
                    result = value1 * value2;
                    break;
                case "D":
                    if (value1 != 0 && value2 != 0 && value1 > value2)
                    {
                        result = value1 / value2;
                    }
                    else
                    {
                        Console.WriteLine("Error:");
                        Console.WriteLine("Requirements for Division: Values can not be 0, and value 1 must be larger than value 2");
                        Console.WriteLine("returned 0");

                    }
                    break;
                case "A":
                    result = value1 + value2;
                    break;
                case "S":
                    result = value1 - value2;
                    break;
            }
            return result;
        }

        private string EnterMathOperator()
        {
            string mathOperator = Console.ReadLine();
            
            //validates input and repeats userinput if not validated
            while (!isMathOperator(mathOperator)|| mathOperator ==null)
            {
                Console.WriteLine("Try again...");
                Console.WriteLine("Allowed operations: (M)ultiply, (D)ivide, (A)dd or (S)ubtract?");
                mathOperator = Console.ReadLine();
            }
            mathOperator = mathOperator.ToUpper();
            return mathOperator;
        }

        private bool isMathOperator(string mathOperator)
        {
            mathOperator = mathOperator.ToUpper();
            if (mathOperator == "M" || mathOperator == "D" || mathOperator == "A" || mathOperator == "S" && mathOperator != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int EnterValue(string strValue, out string userInputValue)
        {
            Console.Write("Enter {0}: ", strValue);
            userInputValue = Console.ReadLine();
            int intValue = 0;

            //Repeat input process until value can be parsed
            while (!int.TryParse(userInputValue, out intValue))
            {
                Console.WriteLine("Value can't be parsed as a number");
                Console.Write("Enter {0}: ", strValue);
                userInputValue = Console.ReadLine();
            }
            return intValue;
        }
    }
}
