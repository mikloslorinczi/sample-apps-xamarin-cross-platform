using Xunit;

namespace Multiplatform.xUnit
{
	public class MyClass
	{
		[Fact]
		public void PassingTest()
		{
			Assert.Equal(4, Add(2, 2));
		}

		int Add(int x, int y)
		{
			return x + y;
		}
	}
}
