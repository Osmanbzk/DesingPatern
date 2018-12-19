using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDWrong.OCP
{
    class Logger
    {
        public void Log(string message, LogType logType)
        {
            switch (logType)
            {
                case LogType.Console:
                    Console.WriteLine(message);
                    break;
                case LogType.File:
                    break;
                default:
                    break;
            }
        }
    }

    enum LogType
    {
        Console,
        File
    }
}
