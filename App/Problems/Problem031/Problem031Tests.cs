using NUnit.Framework;

namespace App.Problems.Problem031;

public class Problem031Tests
{
    [Test]
    public void Test()
    {
        var problem = new Problem031();
        var result = problem.Run(5);

        Assert.That(result, Is.EqualTo(11));
    }
}