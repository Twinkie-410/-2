using System;
using NUnit.Framework;

namespace TestProject;

public class Tests
{
    private static Action<int> exeption;
    private static Action counter;
    private static int count;
    [OneTimeSetUp]
    public void Setup()
    {
        exeption = x =>
        {
            var count = x;
            while (count > 0)
            {
                throw new Exception();
            }
        };
        
        counter = () => count++;
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
    
    [Test]
    public void Test2()
    {
        Assert.Pass();
    }
}