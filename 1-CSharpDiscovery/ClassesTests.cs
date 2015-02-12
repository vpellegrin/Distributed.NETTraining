using NFluent;
using NUnit.Framework;

namespace CSharpDiscovery
{
    [TestFixture]
    public class ClassesTests
    {
        [Test]
        public void CreateACalculatorClassWithADefaultConstructorAndInstanciate()
        {
            Calculator calculator = new Calculator(); 
            Check.That(calculator).IsNotNull();
        }

        [Test]
        public void AddAnotherConstructorWithAFriendlyNameAndInstanciate()
        {
            // use a public member for Name for now, i.e public string Name;
            Calculator calculator = new Calculator("Calculator"); 
            Check.That(calculator.Name).Equals("Calculator");
        }

        [Test]
        public void AddAMethodThatMakeASumOfAnArrayOfDouble()
        {
            var valuesToSum = new[] { 1.3, 1.7 };
            // add a method Sum to calculator class
            Calculator calculator = new Calculator(); 
            double sumOfTheArray = calculator.sumOfTheArray(valuesToSum);
            Check.That(sumOfTheArray).Equals(3.0);
        }

        [Test]
        public void AddAMethodOverloadThatMakeASumOfTwoDoubleFromStringRepresentation()
        {
            var sumOfTwoDoubleFromString = "1,0+2";
            // add a method with the same name that uses the previous method
            // tips : use string.Split
            Calculator calculator = new Calculator();
            double onePlusTwo = calculator.sumOfTwoDouble(sumOfTwoDoubleFromString);
            Check.That(onePlusTwo).Equals(3.0);
        }

        [Test]
        public void AddAGetterForNameInsteadOfPublicNameMember()
        {
            Calculator calculator = new Calculator("Calculator");
            Check.That(calculator.Name).Equals("Calculator");
        }

        [Test]
        public void AddASetterForNameAndChangeNameWithIt()
        {
            Calculator calculator = new Calculator("Calculator");
            calculator.Name = "Enhanced Calculator";
            Check.That(calculator.Name).Equals("Enhanced Calculator");
        }

        [Test]
        public void UseObjectInitilizerWithDefaultConstructor()
        {
            Calculator calculator = new Calculator(); 
            Check.That(calculator.Name).Equals("Calculator");
        }

        //EN COURRRRSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS
        [Test]
        public void DefineConstantForPi()
        {
            var sumOfADoubleAndPiConstant = "1.2 + pi";
            // define pi constant (as double) and replace pi string with constant value

            Calculator calculator = new Calculator();
            double sum = calculator.sommeForPi(sumOfADoubleAndPiConstant);
            Check.That(sum).Equals(4.34);
        }

        //[Test]
        //public void StaticReadonlyMembers()
        //{
        //    var sumOfADoubleAndPiConstant = "1.2 + pi";
        //    // replace pi constant with a static readonly member
        //    Check.That(sum).Equals(4.34);
        //}

        //[Test]
        //public void MakeSumMethodsStaticAsTheyDoNotNeedAnyInstanceSpecific()
        //{
        //    // make sum methods static and call one these to retrieve a sum of double array values
        //    Check.That(sum).Equals(3);
        //}

        //[Test]
        //public void AddStaticCalculatorClass()
        //{
        //    // define a static class StaticCalculator that uses Calculator static methods & define static getter for Name
        //    Check.That(staticCalculator.Name).Equals("Static calculator");
        //}
    }
}
