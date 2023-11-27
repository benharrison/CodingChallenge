using CalculationEngine;

namespace CalculationEngineUnitTests;

[TestClass]
public class BasicExampleTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var obj = new BasicExample();
        var result = obj.Calculate(1, 2);
        Assert.AreEqual(3, result);
    }
}