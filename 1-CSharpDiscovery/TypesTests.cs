using System;
using NFluent;
using NUnit.Framework;

namespace CSharpDiscovery
{
    [TestFixture]
    public class TypesTests
    {
        [Test]
        public void NFluentAndNUnitAreWorking()
        {
            Check.That(true).IsTrue();
        }

        [Test]
        public void AnIntIsNotEqualToSameIntStringRepresentation()
        {
            int integer = 1;
            string integerAsAString = "1";
            Check.That(integerAsAString).Not.Equals(integer);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsFloat()
        {
            int integer = 1;
            float integerAsAFloat = 1;
            Check.That(integerAsAFloat).Not.Equals(integer);
        }

        [Test]
        public void anintisnotequaltosameintasdouble()
        {
            int integer = 1;
            double integerasadouble = 1;
            Check.That(integerasadouble).Not.Equals(integer);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsDecimal()
        {
            int integer = 1;
            decimal integerAsADecimal = 1;
            Check.That(integerAsADecimal).Not.Equals(integer);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsLong()
        {
            int integer = 1;
            long integerAsInt32 = 1;
            Check.That(integerAsInt32).Not.Equals(integer);
        }

        [Test]
        public void AnIntIsEqualToSameIntAsInt32()
        {
            int integer = 1;
            Int32 integerAsInt32 = 1;
            Check.That(integerAsInt32).Equals(integer);
        }

        [Test]
        public void AFloatCanBeCastedToInteger()
        {
            float single = 1.0F;
            int singleCstedToInteger = (int)single;
            int expectedInteger = 1;
            Check.That(singleCstedToInteger).Equals(expectedInteger);
        }

        [Test]
        public void AIntCanBeCastedToFloat()
        {        
            int integer = 1;
            float singleImplicitlyCastToInteger = (float)integer;
            float expectedSingle = 1.0F;

            Check.That(singleImplicitlyCastToInteger).Equals(expectedSingle);
        }

        [Test]
        public void AStringCanBeParsedToInteger()
        {
            
            string integerString = "30";
            int expectedInteger = 30;
            int integerParsed = int.Parse(integerString);

            Check.That(integerParsed).Equals(expectedInteger);
        }

        public void ParseFloatStringAsInteger()
        {
            String test = "30.0";
            int test2 = int.Parse(test);
        }

        [Test]
        public void AFloatStringRepresentationCannotBeParsedToInteger()
        {
            
            // Create a method named ParseFloatStringAsInteger that takes no argument, return void and parse a float string representation "30.0"
            Check.That(ParseFloatStringAsInteger).Throws<FormatException>();
        }

        [Test]
        public void TryToParseAStringToInteger()
        {
            string floatString = "30.0";
            int integerParsed = 0;
            bool tryParseFailed = int.TryParse(floatString, out integerParsed);

            // Use int.TryParse, /!\ it uses an "out" argument

            Check.That(integerParsed).Equals(default(int));
            Check.That(tryParseFailed).IsFalse();
        }

        [Test]
        public void UseVarForLessVerbosityButKeepStrongTyping()
        {
            var integerAsAString = "1";
            var integer = 1;
            Check.That(integerAsAString).Not.Equals(integer);
        }

        [Test]
        public void NullableIntWithNullValueDoesNotHaveValue()
        {
            // use "int?" to declare a nullable int initialized with null, then try also with Nullable<int>

            
            Nullable<int> nullableInteger = new Nullable<int>();
            Check.That(nullableInteger.HasValue).IsFalse();
        }

        public void GetNullableIntValue()
        {
            Nullable<int> nullableInteger = new Nullable<int>();
            //nullable<int> nullableinteger = null;
            //int? nullableinteger = null;
            //int a = null;
            int i = nullableInteger.Value;
        }
        [Test]
        public void GettingValueOfANullableIntwithNullValueThrowsAnInvalidOperationException()
        {
            // Create a method named GetNullableIntValue that takes no argument, return void and access a nullable int value (nullableInteger.Value)
            Check.That(GetNullableIntValue).Throws<InvalidOperationException>();
        }

        [Test]
        public void NullableIntWithNullValueDoesNotHaveValue2()
        {
            // use "int?" to declare a nullable int initialized with 30

            int? nullableInteger = 30;
            Check.That(nullableInteger.Value).Equals(30);
        }
    }
}
