using System;
using System.IO;
using System.Net;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://ftp6.ua.freebsd.org/pub/FreeBSD/README.TXT");
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
        //    Console.WriteLine(reader.ReadToEnd());
            File.WriteAllText(@"..\..\text.txt", reader.ReadToEnd());
         //   Console.WriteLine("Download Complete, statuc {0}", response.StatusDescription);
            reader.Close();
            response.Close();

        }
    }
}
