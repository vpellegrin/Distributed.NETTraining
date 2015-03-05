namespace CSharpDiscovery
{
    using System;
    using System.Linq;

    public class Calculator
    {
        public virtual double Sum(double[] doubles)
        {
            var result = 0.0;
            foreach (var value in doubles)
            {
                result += value;
            }
            return result;
        }

        
    }
}