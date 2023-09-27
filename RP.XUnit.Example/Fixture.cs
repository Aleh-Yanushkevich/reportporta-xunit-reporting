using Xunit;

namespace RP.XUnit.Example;

public class Fixture
{
    [Fact]
    public void Test() { Assert.NotEmpty("ss"); }
}