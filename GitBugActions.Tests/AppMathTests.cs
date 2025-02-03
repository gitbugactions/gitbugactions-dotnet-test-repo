using Xunit;

namespace GitBugActions.Tests;

public class AppMathTests
{
    private readonly AppMath _appMath = new();

    [Fact]
    public void TestSum()
    {
        Assert.Equal(3, _appMath.Sum(1, 2));
    }

    [Fact]
    public void TestSubtract()
    {
        Assert.Equal(1, _appMath.Subtract(2, 1));
    }

    [Fact]
    public void TestMultiply()
    {
        Assert.Equal(4, _appMath.Multiply(2, 2));
    }

    [Fact]
    public void TestSumTwice()
    {
        Assert.Equal(6, _appMath.SumTwice(2, 2));
    }

    [Fact]
    public void TestSubtractTwice()
    {
        Assert.Equal(2, _appMath.SubtractTwice(6, 2));
    }
}
