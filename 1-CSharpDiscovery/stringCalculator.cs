using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    public class StringCalculator : Calculator
    {
        public double Sum(string sum)
        {
            var values = sum.Split('+').Select(double.Parse).ToArray();
            return base.Sum(values);

        }
    }

}
