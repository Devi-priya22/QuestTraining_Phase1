using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            BasicConfigurator.Configure();
            ConfigureLogging();
            log.Info("Starting up the application.");
            try
            {
                Console.WriteLine("Enter num1 : ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter num2 : ");
                int j = int.Parse(Console.ReadLine());
                int sum = i + j;
                Console.WriteLine(sum);

            }
            catch (Exception e) 
            {
                log.Error(e.StackTrace);
            }
        }
        private static void ConfigureLogging()
        {
            var repository = LogManager.GetRepository();
            var layout = new PatternLayout
            {
                ConversionPattern = "%date [%thread] %-5level %logger - %message%newline"
            };
            layout.ActivateOptions();

            var consoleAppender = new ConsoleAppender
            {
                Layout = layout,
                Threshold = Level.Info
            };
            var fileAppender = new FileAppender
            {
                File = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "logs.log"),
                AppendToFile = true,
                Layout = layout,
                Threshold = Level.Info
            };
            BasicConfigurator.Configure(repository, consoleAppender, fileAppender);
        }
    }
}