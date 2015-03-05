namespace CSharpDiscovery
{
    using System.Linq;

    public class ProductStringCalculator : AbstractStringCalculator
    {
        public override double Calculate(string sumOfTwoDoubleFromString)
        {
            var valuesToSum = sumOfTwoDoubleFromString.Split('+').Select(
                s =>
                {
                    var value = s.Replace(" ", string.Empty);
                    return double.Parse(value);
                }).ToArray();
            return this.Prod(valuesToSum);
        }

        public double Prod(double[] doubles)
        {
            var result = 0.0;
            foreach (var value in doubles)
            {
                result *= value;
            }
            return result;
        }
    }
}