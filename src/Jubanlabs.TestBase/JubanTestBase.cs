namespace Jubanlabs.TestBase
{
    using Jubanlabs.Logging;
    using Microsoft.Extensions.Hosting;
    public class JubanTestBase
    {
        public JubanTestBase()
        {
            var host = Host.CreateDefaultBuilder()
                .Build().SetupJubanLogger();

            Console.WriteLine("JubanTestBase construction done");
        }
    }
}