using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WcfDuplex.Common;

namespace WcfDuplex.Client
{
    class Proxy
    {
        public Proxy()
        {
            InstanceContext instanceContext = new InstanceContext(new ToolCallback());

            duplexChannelFactory = new DuplexChannelFactory<ITool>(instanceContext, "ep001");

            service = duplexChannelFactory.CreateChannel();
        }

        ITool service;

        DuplexChannelFactory<ITool> duplexChannelFactory;

        public void Add(double a, double b)
        {
            service.Add(a, b);
        }
    }
}
