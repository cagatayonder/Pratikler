using System;

namespace Interfaces_
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            // throw new NotImplementedException();
            Console.WriteLine("DATABASE LOG YAZAR");
        }
    }
}
