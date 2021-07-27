using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationLibrary
{
    static public class AvailableOperations
    {
        static public List<BaseOperation> operations;
        static  AvailableOperations()
        {
            operations = new List<BaseOperation>();
            operations.Add(new Sum());
            operations.Add(new Concat());
            operations.Add(new Power());
            operations.Add(new Divide());
        }
    }
}
