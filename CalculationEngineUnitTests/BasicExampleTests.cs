using CalculationEngine;

namespace CalculationEngineUnitTests;

[TestClass]
public class BasicExampleTests
{
    [TestMethod]
    public void BasicExample_Calculate__2_1()
    {
        var obj = new BasicExample();
        var result = obj.Calculate(2, 1);
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void BasicExample_Calculate__1_2()
    {
        var obj = new BasicExample();
        var result = obj.Calculate(1, 2);
        Assert.AreEqual(0.5m, result);
    }

    [TestMethod]
    public void BasicExample_Calculate__2_negative1()
    {
        var obj = new BasicExample();
        var result = obj.Calculate(2, -1);
        Assert.AreEqual(-2, result);
    }

    // Divide by zero
    // --
    //[TestMethod]
    //public void BasicExample_Calculate__2_0()
    //{
    //    var obj = new BasicExample();
    //    var result = obj.Calculate(2, 0);
    //    Assert.AreEqual(??, result);
    //}

    // Handle null input for the denominator
    // --
    //[TestMethod]
    //public void BasicExample_Calculate__2_null()
    //{
    //    var obj = new BasicExample();
    //    var result = obj.Calculate(2, null);
    //    Assert.AreEqual(??, result);
    //}

    // Handle null input for the numerator
    // --
    //[TestMethod]
    //public void BasicExample_Calculate__null_2()
    //{
    //    var obj = new BasicExample();
    //    var result = obj.Calculate(null, 2);
    //    Assert.AreEqual(??, result);
    //}

    // Handle null inputs for both
    // --
    //[TestMethod]
    //public void BasicExample_Calculate__null_null()
    //{
    //    var obj = new BasicExample();
    //    var result = obj.Calculate(null, null);
    //    Assert.AreEqual(??, result);
    //}


}