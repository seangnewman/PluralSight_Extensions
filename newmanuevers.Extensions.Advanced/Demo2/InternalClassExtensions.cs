using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace newmanuevers.Extensions.Advanced.Demo2
{
    internal static class InternalClassExtensions
    {

       

        public static string GetString1Upper(this Class1 obj)
        {
            return obj.GetString1().ToUpper();
        }

        public static string GetString00Upper(this Class0 obj)
        {
            //  return obj.GetString00().ToUpper();
            return null;
        }

        public static string GetString0Upper(this Class0 obj)
        {
            return obj.GetString0().ToUpper();
        }

        public static string GetString2Upper(this Class1.Class2 obj)
        {
            return obj.GetString2().ToUpper();
        }  

        public static string GetString3Upper(this object obj)
        {
            var upper = String.Empty;
            var type3 = typeof(Class1.Class2).GetNestedType("Class3", BindingFlags.NonPublic);
            if(obj.GetType() == type3)
            {
                var method = type3.GetMethod("GetString3", BindingFlags.NonPublic | BindingFlags.Instance);
                var string3 = method.Invoke(obj, null) as string;
                upper = string3.ToUpper();
            }
            return upper;
        }
    }
}
