using System;
using Calculator.common;

namespace CSharpCalculator.CalculatorCommon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("WELCOME TO AMAN'S CALCULATOR");
            Console.WriteLine("***********************************************************************************");
            CalFunctions myObj = new CalFunctions();
            
            int z;
            string num=string.Empty;
            while (num != "e")
            {
                Console.WriteLine("Please provide number 1 and number 2:");
                int num1 = Convert.ToInt16(Console.ReadLine());


                
                int num2 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Please select from these operators:+,-,*,/,%");
                num = Convert.ToString(Console.ReadLine());

                switch (num)
                {
                    case "+":
                        z = myObj.Addition(num1, num2);
                        Console.WriteLine(z);
                        break;

                    case "-":
                        z = myObj.Subtraction(num1, num2);
                        Console.WriteLine(z);
                        break;

                    case "*":
                        z = myObj.Multiplication(num1, num2);
                        Console.WriteLine(z);
                        break;

                    case "/":
                        z = myObj.Division(num1, num2);
                        Console.WriteLine(z);
                        break;

                    case "%":
                        z = myObj.Modulus(num1, num2);
                        Console.WriteLine(z);
                        break;

                    case "m":
                       double k = myObj.AcresToSquareMetres(num1);
                        Console.WriteLine(k);
                        break;

                    case "cm":
                        double m = myObj.InchesToCentimeter(num1);
                        Console.WriteLine(m);
                        break;

                    case "FC":
                        double n = myObj.FarhenitToCelsius(num1);
                        Console.WriteLine(n);
                        break;

                    case "GL":
                        z = myObj.USGalleonsToLitres(num1);
                        Console.WriteLine(z);
                        break;

                    case "PK":
                        z = myObj.PoundsToKilo(num1);
                        Console.WriteLine(z);
                        break;

                    case "MI":
                        z = myObj.MetresPerSecondToInchesPerSecond(num1);
                        Console.WriteLine(z);
                        break;

                    case "SH":
                        z = myObj.SecondsToHours(num1);
                        Console.WriteLine(z);
                        break;
                    

                    default:
                        Console.ReadKey();
                        continue;
                        

                }
            }

        }
    }
}
