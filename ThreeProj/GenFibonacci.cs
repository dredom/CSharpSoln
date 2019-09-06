using System;
namespace ThreeProj
{
    public class GenFibonacci
    {
        private const int start = 0;

        public GenFibonacci()
        {
        }

        public int[] Generate(int howMany)
        {
            int[] result = new int[howMany];
            int i = 0;
            result[i++] = start;
            result[i++] = start + 1;
            for (; i < howMany; i++)
            {
                result[i] = ComputeNext(result[i - 2], result[i - 1]);
            }
            return result;
        }

        private int ComputeNext(int previous, int last)
        {
            return previous + last;
        }
    }
}
