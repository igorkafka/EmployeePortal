using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public sealed class Log:ILog
    {
        private static int counter = 0;
        private static Lazy<Log> instance = new Lazy<Log>(() => new Log());
        public static Log GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
        private Log()
        {
            counter++;
            Console.WriteLine("Counter Value: " + counter.ToString());
        }
        public void PrintDetails(string messege)
        {
            Console.WriteLine(messege);
        }

        public void LogExpection(string message)
        {
            string fileName = $"Exception_{DateTime.Now.Day}_{DateTime.Now.Year}_{DateTime.Now.Month}.log";
            string logFilePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}
