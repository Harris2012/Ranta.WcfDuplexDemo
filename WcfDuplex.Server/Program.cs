using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WcfDuplex.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ToolService)))
            {
                host.Open();

                Console.WriteLine("Press any key to stop server...");

                Console.ReadKey();
            }
        }
    }
}
