using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] str = {"qwe","aaa","w"};
            MyClass myclass = new MyClass(10, "asd",str);
          //  Console.WriteLine(JsonConvert.SerializeObject(myclass));
            string a = JsonConvert.SerializeObject(myclass);
            RootObject2 b = JsonConvert.DeserializeObject<RootObject2>(a);
            Console.WriteLine(b.ToString());
        }
    }
    class MyClass
    {
        [JsonProperty("q")]
        public int Number;
   //     public string Str;
        public string[] Strmas;
        public MyClass2 myclass2;

        public MyClass(int number1, string str1, string[] Newstr)
        {
            Number = number1;
     //       Str = str1;
            Strmas = Newstr;
            myclass2 = new MyClass2(1, "FFFFFF");
        
        }
    }
    class MyClass2
    {
        public int QWER;
        public string DD;
        public int Count;
        public MyClass2(int a, string b)
        {
            QWER = a;
            DD = b;
            Count = 5;
        }
    }

    public class RootObject2
    {
        public int QWER { get; set; }
        public string DD { get; set; }
    }

    public class RootObject
    {
        public int Number { get; set; }
        public string Str { get; set; }
        public List<string> Strmas { get; set; }
        public RootObject2 myclass2 { get; set; }
    }
}
