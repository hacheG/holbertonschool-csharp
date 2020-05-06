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
			string s = "eve";

			bool output = Str.IsPalindrome(s);

			Assert.IsTrue(output);
		}

		[Test]
		public void Test2()
		{
			string s = "esve";

			bool output = Str.IsPalindrome(s);

			Assert.IsFalse(output);
		}

		[Test]
		public void Test3()
		{
			string s = "Racecar";

			bool output = Str.IsPalindrome(s);

			Assert.IsTrue(output);
		}

		[Test]
		public void Test4()
		{
			string s = "A man, a plan, a canal: Panama.";

			bool output = Str.IsPalindrome(s);

			Assert.IsTrue(output);
		}

		[Test]
		public void Test5()
		{
			string s = "";

			bool output = Str.IsPalindrome(s);

			Assert.IsTrue(output);
		}
    }
}