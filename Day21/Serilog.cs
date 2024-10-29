using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serilog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logger = new LoggerConfiguration()
                .WriteTo.Console(
                restrictedToMinimumLevel: Events.LogEventLevel.Information,
                outputTemplate:"[{Timestamp} {Level:u3} {Message} {NewLine}]")
                .CreateLogger();

            logger.Information("Application Started");
        }
    }
}