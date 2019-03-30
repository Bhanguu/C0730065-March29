using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C0730065
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                HelloWorld hw = new HelloWorld();
                hw.Hello();
            }
        }
        class HelloWorld
        {
            public void Hello()
            {
                Console.WriteLine("Hello World");
          }

        }
        static void Download()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Download complete");
        }

    }
}
