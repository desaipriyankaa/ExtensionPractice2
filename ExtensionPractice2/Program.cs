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
            loggers.LogError("This is an Error !");
            loggers.log("Test Error","Errorss");

            loggers.Logwarning("This is a Warning !");
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

        public static void Logwarning(this SimpleLogger logger, string message)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            logger.log(message, "Warning");
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
