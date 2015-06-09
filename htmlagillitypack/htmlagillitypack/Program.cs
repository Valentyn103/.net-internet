using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htmlagillitypack
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb htmlweb = new HtmlWeb();
            HtmlDocument htmldoc = htmlweb.Load("http://www.bank.gov.ua/control/uk/curmetal/detail/currency?period=daily");
            var Des = htmldoc.DocumentNode.Descendants("tr");
            foreach (HtmlNode Node in Des)
            {
                int count = 0;
                foreach (var d in Node.ChildNodes)
                {
                    var value = d.Attributes.FirstOrDefault(a => a.Name == "class" && a.Value == "cell");
                    if (value != null && count == 0)
                    {
                        Console.Write(Node.InnerText + "\t");
                        count++;
                    }
                }
                count = 0;
            }
        }
    }
}
