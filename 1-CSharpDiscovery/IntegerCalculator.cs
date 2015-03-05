namespace CSharpDiscovery
{
    using System.Linq;
    using NUnit.Framework;

    public class IntegerCalculator : Calculator
    {

        public new double Sum(double[] doubles)
        {
            var result = 0.0;
            foreach (var value in doubles)
            {
                result += (int)value;
            }
            return result;
        }

        public double Sum(string sum)
        {
            var values = sum.Split('+').Select(double.Parse).ToArray();
            return this.Sum(values);

        }
    }
}