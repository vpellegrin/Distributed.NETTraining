using NFluent;
using NUnit.Framework;

namespace CSharpDiscovery
{
    [TestFixture]
    public class ControlFlowTests
    {
        [Test]
        public void UseForToConcatenateStringArrayValues()
        {
            var stringArray = new[] { "plip", "plop", "plup" };
            string stringConcatenated = "";
            //var stringBuilder = new System.Text.StringBuilder();
            // concatenate string array values in a single string with the simplest solution using a for, then refactor (but keep for loop) using StringBuilder (+ avoid "", use string.Empty instead) for memory usage reason
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringConcatenated += stringArray[i];
            }
            Check.That(stringConcatenated).Equals("plipplopplup");
        }

        [Test]
        public void UseForeachToConcatenateStringArrayValues()
        {
            var stringArray = new[] { "plip", "plop", "plup" };
            // concatenate string array values in a single string with the simplest solution using a foreach
            string stringConcatenated = ""; 
            foreach (string test in stringArray)
            {
                stringConcatenated += test;
            }
            Check.That(stringConcatenated).Equals("plipplopplup");
        }

        [Test]
        public void UseWhileToConcatenateStringArrayValues()
        {
            var stringArray = new[] { "plip", "plop", "plup" };
            // concatenate string array values in a single string with the simplest solution using a while
            string stringConcatenated = "";
            int cpt = 0;
            while (cpt < stringArray.Length)
            {
                stringConcatenated += stringArray[cpt];
                cpt++;
            }
            Check.That(stringConcatenated).Equals("plipplopplup");
        }

        [Test]
        public void UseDoWhileToConcatenateStringArrayValues()
        {
            var stringArray = new[] { "plip", "plop", "plup" };
            // concatenate string array values in a single string with the simplest solution using a foreach
            string stringConcatenated = "";
            int cpt = 0;
            do
            {
                stringConcatenated += stringArray[cpt];
                cpt++;
            } while (cpt < stringArray.Length);

            Check.That(stringConcatenated).Equals("plipplopplup");
        }

        [Test]
        public void UseIfElseElseIfDuringConcatenationOfStringArrayValues()
        {
            var stringArray = new[] { "plip", "plop", "plup", "foo" };
            // concatenate a string, with "good, " when item is plip, "not so good, " when item starts with "pl", "bad, " in any other case
            string stringConcatenated = "";
            foreach (string test in stringArray)
            {
                if (test == "plip")
                {
                    stringConcatenated += "good, ";
                }
                else if (test.Substring(0, 2) == "pl") 
                {
                    stringConcatenated += "not so good, ";
                    
                }
                else
                {
                    stringConcatenated += "bad, ";
                }
            }
            Check.That(stringConcatenated).Equals("good, not so good, not so good, bad, ");
        }

        //[Test]
        //public void UseSwitchCaseDuringConcatenationOfStringArrayValues()
        //{
        //    var stringArray = new[] { "plip", "plop", "plup", "foo" };
        //    // concatenate a string, with "good, " when item is plip, "not so good, " when item is "plop", "plip", "bad, " in any other case
        //    Check.That(stringConcatenated).Equals("good, not so good, not so good, bad, ");
        //}
    }
}
