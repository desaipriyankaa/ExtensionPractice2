using System;

namespace ExtensionPractice2
{
    public static class extensions
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
    }
}
