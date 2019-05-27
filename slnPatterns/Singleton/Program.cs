using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string filePath = @"D:\code\Design_patterns\files\testfile.txt";

            Settings setting = Settings.Instance;

            string content = setting.GetConfig(filePath);
            Console.WriteLine(content);
            Console.ReadLine();
        }
    }
}
