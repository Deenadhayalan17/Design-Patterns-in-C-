using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_in_C_.Exercise.Singleton
{
    public class Singleton
    {
        public static bool IsSingleton(Func<object> func)
        {
            var obj1= func();
            var obj2= func();
            return ReferenceEquals(obj1, obj2);
        }
    }
}
