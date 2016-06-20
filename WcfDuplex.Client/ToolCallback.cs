using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfDuplex.Common;

namespace WcfDuplex.Client
{
    class ToolCallback : IToolCallback
    {
        public void Display(double x, double y, double z)
        {
            Console.WriteLine("Display(x,y,z) is called. x = {0} , y = {1} z = {2}", x, y, z);
        }
    }
}
