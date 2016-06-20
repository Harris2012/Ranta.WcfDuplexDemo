using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WcfDuplex.Common
{
    [ServiceContract(CallbackContract = typeof(IToolCallback))]
    public interface ITool
    {
        [OperationContract(IsOneWay = true)]
        void Add(double a, double b);
    }
}
