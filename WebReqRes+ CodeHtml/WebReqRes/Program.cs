using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebReqRes
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest req = WebRequest.Create("http://vk.com");
            req.Proxy = null;
            using (WebResponse res = req.GetResponse())
            {
                Console.WriteLine(req.Timeout);
                Console.WriteLine(req.ContentLength);
                Console.WriteLine(req.ContentType);
                Console.WriteLine(req.Headers);
                Console.WriteLine(req.Proxy);
                Console.WriteLine("\n\n" + res.ContentLength);
                Console.WriteLine(res.ContentType);
                Console.WriteLine(res.Headers);
            }
        }
    }
}
