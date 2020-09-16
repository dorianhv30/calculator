using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    public class Calculator
    {
        public  int Add(int a, int b) {
            Logger.Log($"{a} + {b} = {a + b}");
            return a + b;
        }
        
    }

    public class Helper
    {
        public static bool IsValid(string number, out int result)
        {
            bool isValid;
            isValid = int.TryParse(number, out result);
            return isValid;
        }
    }

    public class Logger
    {
        public static void Log(string message) { Console.WriteLine(message); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            Console.WriteLine("Input the numbers seprated by enter");
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            if (!Helper.IsValid(firstInput, out firstNumber))
            {
                Logger.Log($"{firstInput} is not a number");
            }
            else if (!Helper.IsValid(secondInput, out secondNumber))
            {
                Logger.Log($"{secondInput} is not a number");
            }
            else {
                Calculator calc = new Calculator();
                calc.Add(firstNumber, secondNumber);
            }

            Console.ReadLine();

        }
    }
}
