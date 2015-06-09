using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.ProtocolBuffers;
using System.Diagnostics;
using ProtoBuf;
using System.IO;

namespace MyProtocol_Buffers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count : 10.  ms : {0}", MyClass.serialize(10));
            Console.WriteLine("Count : 100.  ms : {0}", MyClass.serialize(100));
            Console.WriteLine("Count : 1000.  ms : {0}", MyClass.serialize(1000));
            Console.WriteLine("Count : 5000.  ms : {0}", MyClass.serialize(1000));
            Console.WriteLine("Count : 10000.  ms : {0}", MyClass.serialize(10000));
            List<MyClass> b;
            using (var file = File.Open("D:/Mytxt.txt",FileMode.Open))
            {
                 b = Serializer.Deserialize<List<MyClass>>(file);
            }
            for(int i =0;i<b.Count;i++)
              Console.WriteLine(b[i].Number);
        }
    }

    [ProtoContract]
    public class MyClass
    {
        [ProtoMember(1)]
        public int Number;
        [ProtoMember(2)]
        public string[] Strmas;
        [ProtoMember(3)]
        public MyClass2 myclass2;

        public MyClass(int number1, string[] Newstr)
        {
            Number = number1;
            Strmas = Newstr;
            myclass2 = new MyClass2(1, "FFFFFF");

        }

        public static long serialize(int count)
        {
            string[] a = { "qwe", "qaaa", "zaaaawqweqweqweqw" };
            MyClass myclass = new MyClass(1, a);
            List<MyClass> NewMyClass = new List<MyClass>();
            NewMyClass.Add(new MyClass(1, a));
            NewMyClass.Add(new MyClass(2, a));
            NewMyClass.Add(new MyClass(3, a));
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            using (var file = File.Create("D:/Mytxt.txt"))
            {
                for (int i = 0; i < count; i++)
                {
                    Serializer.Serialize<List<MyClass>>(file, NewMyClass);
                }
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
    }
    [ProtoContract]
    public class MyClass2
    {
        [ProtoMember(1)]
        public int QWER;
        [ProtoMember(2)]
        public string DD;
        [ProtoMember(3)]
        public int Count;
        public MyClass2(int a, string b)
        {
            QWER = a;
            DD = b;
            Count = 5;
        }
    }
}
