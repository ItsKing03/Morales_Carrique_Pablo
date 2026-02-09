using NUnit.Framework;

public class MathUtilsTests
{
    [Test]
    public void SimpleMathCheckPasses()
    {
        int a = 2;
        int b = 3;
        int result = a + b;

        Assert.AreEqual(5, result);
    }
}

