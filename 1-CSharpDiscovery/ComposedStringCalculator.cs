namespace CSharpDiscovery
{
    using System;

    public class ComposedStringCalculator
    {
        public ComposedStringCalculator(IComputeStrategy computeStrategy)
        {
            throw new System.NotImplementedException();
        }

        public Action Calculate(string p0)
        {
            throw new NotImplementedException();
        }
    }

    public interface IComputeStrategy
    {
    }
}