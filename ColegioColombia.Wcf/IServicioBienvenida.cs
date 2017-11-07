using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ColegioColombia.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioBienvenida" in both code and config file together.
    [ServiceContract]
    public interface IServicioBienvenida
    {
        [OperationContract]
        string SaludoPersonalizado(string nombre);
    }
}