// Inyeccion de Dependencias

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DefaultOperation : 
    ITransientOperation,
    IScopedOperation,
    ISingletonOperation
{
    public string OperationId { get; } 

}
