using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationLibrary
{
    public class Concat : BaseOperation
    {
        public override string DoOperation(string a, string b)
        {
            return a + b;
        }
        public Concat() : base("Слияние") { }
    }
}
