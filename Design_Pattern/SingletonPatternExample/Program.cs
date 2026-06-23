using System;

namespace SingletonPatternExample
{
    public class Logger
    {
        private static Logger instance;

        private Logger()
        {
            Console.WriteLine("Logger instance created.");
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine("Log: " + message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Singleton Pattern Test ---");

            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("First message from logger1.");
            logger2.Log("Second message from logger2.");

            if (ReferenceEquals(logger1, logger2))
            {
                Console.WriteLine("\nSUCCESS: Both logger1 and logger2 refer to the same instance.");
            }
            else
            {
                Console.WriteLine("\nFAILURE: Multiple instances of Logger exist.");
            }

            Console.WriteLine("\n--- End of Test ---");
        }
    }
}