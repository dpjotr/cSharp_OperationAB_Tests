using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationLibrary
{
    public class Power : BaseOperation
    {
     
        public override string DoOperation(string a, string b)
        {
            if (Double.TryParse(a, out double aDouble)
                && Double.TryParse(b, out double bDouble))
                return (System.Math.Pow(aDouble, bDouble)).ToString();
            else
                throw new Exception("Формат переменных не соответствует операции возведения в степень." +
                "Исправьте переменные или выберите другую операцию.");
        }
        public Power() : base("Возведение в степень (численная)") { }
    }
}
