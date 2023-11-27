using CalculationEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationEngineUnitTests;

[TestClass]
public class AnnualRentTests
{

    [TestMethod]
    public void AnnualRent_Calculate__500month()
    {
        var obj = new AnnualRent();
        var result = obj.Calculate(500);
        Assert.AreEqual(6000, result);
    }

    [TestMethod]
    public void AnnualRent_Calculate__null()
    {
        var obj = new AnnualRent();
        var result = obj.Calculate(null);
        Assert.IsNull(result);
    }

    [TestMethod]
    public void AnnualRent_Calculate__negative1()
    {
        var obj = new AnnualRent();
        var result = obj.Calculate(-1);
        Assert.IsNull(result);
    }

}
