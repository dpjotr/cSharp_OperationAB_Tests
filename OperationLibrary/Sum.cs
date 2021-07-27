using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationLibrary
{
    public class Sum : BaseOperation
    {
   
        public override string DoOperation(string a, string b)
        {
            if (Double.TryParse(a, out double aDouble)
                && Double.TryParse(b, out double bDouble)) 
                return (aDouble + bDouble).ToString();
            else 
                throw new Exception("Формат переменных не соответствует операции сложения." +
                "Исправьте переменные или выберите другую операцию.");
        }
        public Sum() : base("Сложение (численная)") {}
    }
}
