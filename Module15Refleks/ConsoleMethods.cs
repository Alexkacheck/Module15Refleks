using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Module15Refleks
{
    public class ConsoleMethods
    {
        public static void PrintMethods()
        {
            Type consoleType = typeof(Console);
            MethodInfo[] methods = consoleType.GetMethods();

            Console.WriteLine("Методы класса:");
            foreach (var method in methods)
            {
                Console.WriteLine($"  {method.Name}");
            }
        }
    }
}
