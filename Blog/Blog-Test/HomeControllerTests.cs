using Xunit;

namespace Blog_Test
{
    public class HomeControllerTests
    {
        [Fact]
        public void CanCallDataAccessMethod()
        {
            Assert.Equal(4, 2 + 2);
            Assert.Equal(1, 1);
        }

    }
}
