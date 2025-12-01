using Xunit;

namespace GMock.Net.Tests;

public class MockTests
{
    [Fact]
    public void Mock_CanBeInstantiated()
    {
        var mock = new Mock();
        Assert.NotNull(mock);
    }
}
