using MyLibrary;
using Xunit;

namespace MyLibraryTests;

public class UnitTest1
{
    [Fact]
    public void ShouldReturnHelloWorldThreeTimes()
    {
        const string expected = @"Hello World
Hello World
Hello World";
        var sut = new HelloWorldPrinter();

        var str = sut.GetHellWorld(3);

        Assert.Equal(expected, str);
    }
}