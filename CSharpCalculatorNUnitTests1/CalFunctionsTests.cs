using Calculator.common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace CSharpCalculatorNUnitTests1
{
    public class CalFunctionsTests
    {
        
        [Test]
        
public void Adding_Operations_CheckingOutput()
        {
            //ARRANGE
            var add = new CalFunctions();

            //ACT
            var result = add.Addition(2,2);

            //ASSERT
           Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(4, result);
        }

        [Test]
        public void Add_PassInvalidValues_GettingException()
        {
            //ARRANGE
            var add = new CalFunctions();

            //ACT


            //ASSERT
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(4, add.Addition(2, 2));
        }

        [Test]
        public void Adding_Operations_Fail_CheckingOutput()
        {
            //ARRANGE
            var add = new CalFunctions();

            //ACT


            //ASSERT
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(500, add.Addition(200, 300));
        }




        [Test]
        public void Subtracting_Operations_CheckingOutput()
        {
            //ARRANGE
            var subt = new CalFunctions();

            //ACT
            

            //ASSERT
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1, subt.Subtraction(2, 1));
        }

        [Test]
        public void Multiplying_Operations_CheckingOutput()
        {
            //ARRANGE
            var mult = new CalFunctions();

            //ACT
            mult.Multiplication(2, 1);

            //ASSERT
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(2, 2*1);
        }

        [Test]
        public void Division_Operations_CheckingOutput()
        {
           
                //ARRANGE
                var div = new CalFunctions();

                //ACT
                div.Division(4, 2);


            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(2, 4 / 2);
            
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Cannot divide by zero")]
        public void Division_Operations_DivideByZero_CheckingOutput()
        {

            //ARRANGE
            var div = new CalFunctions();



            int x = 4;
            int y = 0;
            div.Division(x,y);

        }

        [Test]
        public void Modulus_Operations_CheckingOutput()
        {
            //ARRANGE
            var mod = new CalFunctions();

            //ACT
            mod.Modulus(4, 2);

            //ASSERT
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(0, 4%2);
        }

        [Test]
        public void AcresToSquareMeters_Operations_CheckingOutput()
        {
            //ARRANGE
            var acres = new CalFunctions();

            //ACT
            acres.AcresToSquareMetres(1);

            //ASSERT
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(4046, 1 * 4046);
        }

        [Test]
        public void InchesToCentimeters_Operations_CheckingOutput()
        {
            //ARRANGE
            var acres = new CalFunctions();

            //ACT
            acres.AcresToSquareMetres(1);

            //ASSERT
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(3, 1 * 3);
        }

        [Test]
        public void FarhenitToCelsius_Operations_CheckingOutput()
        {
            //ARRANGE
            var cel = new CalFunctions();

            //ACT
            cel.FarhenitToCelsius(1);

            //ASSERT
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(-17, (1-32  )* 5/9);
        }

        [Test]
        public void USGalleonsToLitres_Operations_CheckingOutput()
        {
            //ARRANGE
            var lit = new CalFunctions();

            //ACT
            lit.USGalleonsToLitres(1);

            //ASSERT
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(4,1*4);
        }

        [Test]
        public void PoundsToKilo_Operations_CheckingOutput()
        {
            //ARRANGE
            var kilo = new CalFunctions();

            //ACT
            kilo.PoundsToKilo(1);

            //ASSERT
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(0, 1 / 2);
        }

        [Test]
        public void MetersPerSecondToInchesPerSecond_Operations_CheckingOutput()
        {
            //ARRANGE
            var inches = new CalFunctions();

            //ACT
            inches.MetresPerSecondToInchesPerSecond(1);

            //ASSERT
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(0, 1 / 39);
        }

        [Test]
        public void SecondsToHours_Operations_CheckingOutput()
        {
            //ARRANGE
            var hours = new CalFunctions();

            //ACT
            hours.SecondsToHours(1);

            //ASSERT
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(0, 1 / 3600);
        }


    }
}