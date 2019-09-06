using NUnit.Framework;
using System;
using ThreeProj;

namespace ThreeProj.Tests
{
    public class GenFibonacciTest
    {
        GenFibonacci service;

        [SetUp]
        public void Setup()
        {
            service = new GenFibonacci();
        }

        [Test]
        public void HappyPath()
        {
            int[] expected = { 0, 1, 1, 2, 3, 5, 8 };
            int[] result = service.Generate(7);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual( expected[i], result[i], "i=" + i);
            }
            Console.WriteLine("[{0}]", string.Join(", ", result));
        }
    }
}
