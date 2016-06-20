using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WcfDuplex.Common
{
    [ServiceContract]
    public interface IToolCallback
    {
        [OperationContract(IsOneWay = true)]
        void Display(double x, double y, double z);
    }
}
