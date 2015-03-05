namespace CSharpDiscovery
{
    public class AnotherIntegerCalculator : Calculator
    {
        public override double Sum(double[] doubles)
        {
            var result = 0.0;
            foreach (var value in doubles)
            {
                result += (int)value;
            }
            return result;
        }
    }
}