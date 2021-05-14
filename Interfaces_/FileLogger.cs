using System;

namespace Interfaces_
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            // throw new NotImplementedException();
            Console.WriteLine("DOSYA LOG YAZAR");
        }
    }
}