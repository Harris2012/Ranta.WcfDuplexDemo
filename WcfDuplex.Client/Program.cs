using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfDuplex.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();

            proxy.Add(2, 3);

            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();
        }
    }
}
