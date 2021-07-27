using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationLibrary
{
    public class Divide : BaseOperation
    {
   
        public override string DoOperation(string a, string b)
        {
            if (Double.TryParse(a, out double aDouble)
                && Double.TryParse(b, out double bDouble))
            {
                if (bDouble==0)
                    throw new Exception("Попытка деления на ноль. " +
                "Исправьте переменную B");
                return (aDouble / bDouble).ToString();
            }
            else
                throw new Exception("Формат переменных не соответствует операции деления." +
                "Исправьте переменные или выберите другую операцию.");
        }
        public Divide() : base("Деление (численная)") { }
    }
}
