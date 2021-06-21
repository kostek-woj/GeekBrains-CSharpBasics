using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DateTimeStruct
{
    class Program
    {
        static PropertyInfo GetPropertyInfo(object obj, string str) {
            return obj.GetType().GetProperty(str);
        }

        static void Main(string[] args) {
            Console.WriteLine("All properties of DateTime Struct:");

            DateTime dt = new DateTime();

            Console.WriteLine($"CanRead: { GetPropertyInfo(dt, "Year").CanRead }");
            Console.WriteLine($"CanWrite: { GetPropertyInfo(dt, "Year").CanWrite }");
            Console.WriteLine($"Attributes: { GetPropertyInfo(dt, "Year").Attributes }");
            Console.WriteLine($"CustomAttributes: { GetPropertyInfo(dt, "Year").CustomAttributes }");
            Console.WriteLine($"DeclaringType: { GetPropertyInfo(dt, "Year").DeclaringType }");
            Console.WriteLine($"GetMethod: { GetPropertyInfo(dt, "Year").GetMethod }");
            Console.WriteLine($"IsSpecialName: { GetPropertyInfo(dt, "Year").IsSpecialName }");
            Console.WriteLine($"MemberType: { GetPropertyInfo(dt, "Year").MemberType }");
            Console.WriteLine($"MetadataToken: { GetPropertyInfo(dt, "Year").MetadataToken }");
            Console.WriteLine($"Module: { GetPropertyInfo(dt, "Year").Module }");
            Console.WriteLine($"Name: { GetPropertyInfo(dt, "Year").Name }");
            Console.WriteLine($"PropertyType: { GetPropertyInfo(dt, "Year").PropertyType }");
            Console.WriteLine($"ReflectedType: { GetPropertyInfo(dt, "Year").ReflectedType }");
            Console.WriteLine($"SetMethod: { GetPropertyInfo(dt, "Year").SetMethod }");
            Console.WriteLine($"GetValue: { GetPropertyInfo(dt, "Year").GetValue(dt) }");
        }
    }
}
