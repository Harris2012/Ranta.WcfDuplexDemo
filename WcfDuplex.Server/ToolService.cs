using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WcfDuplex.Common;

namespace WcfDuplex.Server
{
    class ToolService : ITool
    {
        public ToolService()
        {
            callback = OperationContext.Current.GetCallbackChannel<IToolCallback>();
        }

        IToolCallback callback;

        public void Add(double a, double b)
        {
            Console.WriteLine("Add(a,b) is called. a = {0} , b = {1}", a, b);

            callback.Display(a, b, a + b);
        }
    }
}
