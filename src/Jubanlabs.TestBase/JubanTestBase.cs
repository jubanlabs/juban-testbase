using Microsoft.Extensions.Logging;

namespace Jubanlabs.TestBase
{
    using Jubanlabs.Logging;
    using Microsoft.Extensions.Hosting;

    public class JubanTestBase
    {
        public JubanTestBase()
        {
            var host = Host.CreateDefaultBuilder().ConfigureLogging((context, builder) =>
                {
                    builder.AddSimpleConsole(o => o.SingleLine = true);
                })
                .Build().SetupJubanLogger();

            Console.WriteLine("JubanTestBase construction done");
        }
    }
}