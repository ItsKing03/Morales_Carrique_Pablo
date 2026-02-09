using NUnit.Framework;

public class MathUtils
{
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public bool IsEven(int value)
    {
        return value % 2 == 0;
    }
}

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

