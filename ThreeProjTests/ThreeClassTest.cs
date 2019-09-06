using NUnit.Framework;
using System;
using ThreeProj;

namespace ThreeProj.Tests
{
    public class ThreeClassTest
    {
        ThreeClass threeClass;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("ThreeClassTest Setup");
            threeClass = new ThreeClass();
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("Test1 starting...");
            ThreeClass.Main(new string[] { "a" });
            threeClass.DoIt();
            Console.WriteLine("Test1 end");
            Assert.Pass();
        }
    }
}