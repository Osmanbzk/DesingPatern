using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP
{
    public class Logger
    {
        IMessageLogger _messageLogger;

        public Logger(IMessageLogger messageLogger)
        {
            _messageLogger = messageLogger;
        }
        public void Log(string message)
        {
            _messageLogger.Log(message);
        }

    }

    public interface IMessageLogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : IMessageLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class PrinterLogger : IMessageLogger
    {
        public void Log(string message)
        {
            //Console.WriteLine("File Document message :", message);
        }
    }
}
