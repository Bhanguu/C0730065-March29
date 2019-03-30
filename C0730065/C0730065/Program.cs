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
               
                Console.WriteLine("Downloading file");
                Download();
                Console.ReadLine();
          }

        }
        static void Download()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Download complete");
            Thread.Sleep(7000);
        }

    }
}
