using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

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
                    builder.AddSimpleConsole(configure =>
                    {
                        configure.SingleLine = true;
                    });
                })
                .Build().SetupJubanLogger();

            Console.WriteLine("JubanTestBase construction done");
        }
    }
}