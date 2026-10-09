using Fibonacci.Lib;

namespace Fibonacci.Tests;

[TestClass]
public sealed class FibonacciUtilsTests
{
    [TestMethod]
    public void GetFibonacci_Zero_GivesZero()
    {
        int n = 0;
        int result = FibonacciUtils.GetFibonacci(n);
        Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void GetFibonacci_Ten_Gives55()
    {
        int n = 10;
        int result = FibonacciUtils.GetFibonacci(n);
        Assert.AreEqual(55, result);
    }
    [TestMethod]
    public void GetFibonacci_15_Gives610()
    {
        int n = 15;
        int result = FibonacciUtils.GetFibonacci(n);
        Assert.AreEqual(610, result);
    }
}
