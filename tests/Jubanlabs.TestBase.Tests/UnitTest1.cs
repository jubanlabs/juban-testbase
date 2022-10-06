using Microsoft.Extensions.Logging;

namespace Jubanlabs.TestBase.Tests;

[TestClass]
public class UnitTest1 :JubanTestBase
{
    private static  ILogger logger = Jubanlabs.Logging.Logger.GetLogger<UnitTest1>();
    
    [TestMethod]
    public void TestMethod1()
    {
        
        logger.LogInformation("hello logger.");
        logger.LogError("hello logger.");
    }
}