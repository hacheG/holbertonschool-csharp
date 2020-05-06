using NUnit.Framework;

namespace Text.Tests
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
			string s = "iAmHere";

			int output = Str.CamelCase(s);

			Assert.AreEqual(3, output);
		}

		[Test]
		public void Test2()
		{
			string s = "";

			int output = Str.CamelCase(s);

			Assert.AreEqual(0, output);
		}

		[Test]
		public void Test3()
		{
			string s = "hello";

			int output = Str.CamelCase(s);

			Assert.AreEqual(1, output);
		}

		[Test]
		public void Test4()
		{
			string s = null;

			int output = Str.CamelCase(s);

			Assert.AreEqual(0, output);
		}
    }
}