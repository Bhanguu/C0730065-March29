using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

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
        static async void Download()
        {
            await Network.Download();
            Console.WriteLine("Download complete");
        }
        class Network
        {
            ArrayList WebPageContent = new ArrayList();
            public static async Task Download() { 
            HttpClient client = new HttpClient();
            String data =  await client.GetStringAsync("http://torontopubliclibrary.ca");
                Console.WriteLine(data);
                foreach (String line in data) ;
        }
        }
    }
}





  