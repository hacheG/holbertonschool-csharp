using NUnit.Framework;

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
            int[,] matrix = new int[2, 2] { { 6, 2 }, { 2, 4 } };
			int num = 2;

			int[,] output = Matrix.Divide(matrix, num);

			Assert.AreEqual(new int[2, 2] { { 3, 1 }, { 1, 2 } }, output);
        }
    }
}