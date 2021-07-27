using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OperationLibrary
{
    abstract public class BaseOperation
    {
        private protected readonly string operationName;
        public string OperationName => operationName;

        private protected BaseOperation(string operation)
        {
            operationName = operation;
        }

        abstract public string DoOperation(string a, string b);


    }
}
