using System;

namespace ClassLibrary1
{
    public class CalFunctionsWeb
    {
        //Addition MEthod
        public int Addition(int x, int y)
        {

            return x + y;


        }

        //Subtraction Method
        public int Subtraction(int x, int y)
        {
            return x - y;
        }

        //Multiplication method
        public int Multiplication(int x, int y)
        {
            return x * y;
        }

        //Division method
        public int Division(int x, int y)
        {
            return x / y;
        }

        public int Modulus(int x,int y)
        {
            return x % y;
        }

        public int AcresToSquareMetres(int x)
        {
            return x * 4046;
        }

        public int InchesToCentimeter(int x)
        {
            return x * 3;
        }

        public int FarhenitToCelsius(int x)
        {
            return ((x - 32) * 5556);
        }

        public int USGalleonsToLitres(int x)
        {
            return x * 4;
        }

        public int PoundsToKilo(int x)
        {
            return x / 2;
        }

        public int MetresPerSecondToInchesPerSecond(int x)
        {
            return x / 39;
        }

        public int SecondsToHours(int x)
        {
            return x * 3600;
        }
    }
}
