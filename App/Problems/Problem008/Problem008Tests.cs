using NUnit.Framework;

namespace App.Problems.Problem008;

public class Problem008Tests
{
    [Test]
    public void Test()
    {
        var problem = new Problem008();
        var result = problem.Run(4);

        Assert.That(result, Is.EqualTo(5832));
    }
}