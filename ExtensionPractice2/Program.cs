using System;

namespace ExtensionPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            string demo = "This is a demo";
            demo.PrintToConsole();

            SimpleLogger loggers = new SimpleLogger();
            loggers.LogError("This is an error !");
            loggers.log("Test Error","Errorss");
        }
    }

    public static class ExtensionLogger
    {
        public static void LogError(this SimpleLogger logger, string message)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            logger.log(message,"Error");
            Console.ForegroundColor = defaultColor;
        }
    }
    public class SimpleLogger
    {
        public void log(string message)
        {
            System.Console.WriteLine(message);
        }
        public void log(string message, string messageType)
        {
            log($"{messageType} : {message}");
        }
    }
}
