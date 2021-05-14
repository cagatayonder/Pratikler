using System;

namespace Interfaces_
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            // throw new NotImplementedException();
            Console.WriteLine("SMS LOG YAZAR");
        }
    }
}