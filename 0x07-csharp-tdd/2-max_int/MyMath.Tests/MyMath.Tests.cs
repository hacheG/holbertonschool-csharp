using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

		[Test]
		public void Test1()
		{
			List<int> array = new List<int>();
			array.Add(4);
			array.Add(2);
			array.Add(-4);
			array.Add(5);
			array.Add(1);

			int output = Operations.Max(array);

			Assert.AreEqual(5, output);
		}

		[Test]
		public void Test2()
		{
			List<int> array = new List<int>();

			int output = Operations.Max(array);

			Assert.AreEqual(0, output);
		}

		[Test]
		public void Test3()
		{
			List<int> array = null;

			int output = Operations.Max(array);

			Assert.AreEqual(0, output);
		}
    }
}