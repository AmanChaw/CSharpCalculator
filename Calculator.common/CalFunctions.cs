using System;

namespace Calculator.common
{
    public class CalFunctions
    {
        
        //Addition MEthod
        public int Addition(int x, int y)
        {
            if (x == null && y == null)
            {
                throw new ArgumentNullException("null");
            }

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
            if (y == 0)
            {
                throw new Exception("Cannot divide by zero");
            }
            return x / y;
        }

        //Modulus method
        public int Modulus(int x,int y)
        {
            return x % y;   
        }

        public double AcresToSquareMetres(double x)
        {
            return x * 4046.86;
        }

        public double InchesToCentimeter(double x)
        {
            return x * 2.54;
        }

        public double FarhenitToCelsius(int x)
        {
            return ((x - 32)* 5/9);
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
            return x / 3600;
        }
        public string Subtraction()
        {
            throw new NotImplementedException();
        }

        public string Multiplication()
        {
            throw new NotImplementedException();
        }

        public string Division()
        {
            throw new NotImplementedException();
        }

        public string Modulus()
        {
            throw new NotImplementedException();
        }
    }
}
