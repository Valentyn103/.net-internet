using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient Client = new WebClient();
            Stream stream = Client.OpenRead("http://habrahabr.ru/");
            StreamReader sr = new StreamReader(stream);
            string newLine;
            while ((newLine = sr.ReadLine()) != null)
            {
                Console.WriteLine(newLine);
            }
        }
    }
}
