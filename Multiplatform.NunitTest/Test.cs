using NUnit.Framework;
using System;
namespace Multiplatform.NunitTest
{
	[TestFixture]
	public class TestsSample
	{
		[SetUp]
		public void Setup()
		{
		}


		[TearDown]
		public void Tear()
		{
		}

		[Test]
		public void Pass()
		{
			Assert.True(true);
		}

		[Test]
		[Ignore("another time")]
		public void Ignore()
		{
			Assert.True(false);
		}

		[Test]
		public void Inconclusive()
		{
			Assert.Inconclusive("Inconclusive");
		}
	}
}
