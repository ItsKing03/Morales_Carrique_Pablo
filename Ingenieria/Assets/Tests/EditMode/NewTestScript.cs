using NUnit.Framework;

public class NewTestScript
{
    [Test]
    public void NewTestScriptSimplePasses()
    {
        Assert.Pass();
    }

    [Test]
    public void SimpleAdditionTestPasses()
    {
        int a = 2;
        int b = 3;
        int result = a + b;

        Assert.AreEqual(5, result);
    }

    [Test]
    public void AlwaysTrueTestPasses()
    {
        Assert.IsTrue(true);
    }
}

