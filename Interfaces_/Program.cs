using System;

namespace Interfaces_
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger filelogger = new FileLogger();
            filelogger.WriteLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();

            SmsLogger smsLogger = new SmsLogger();
            smsLogger.WriteLog();
        }
    }
}
