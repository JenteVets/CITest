using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        // Define a static logger variable
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            // Set up a simple configuration that logs on the console.
            //BasicConfigurator.Configure();
            XmlConfigurator.Configure();

            log.Info("Entering application.");
            Console.WriteLine("Dit is een test.");
            Console.WriteLine("Logger installeren.");
            log.Debug("De logger werkt.");
            Console.ReadLine();
            log.Info("Exiting application.");
        }
    }
}
