using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Module15Refleks
{
    public class SubstringTask
    {
        public static void CallSubstring()
        {
            string inputString = "Это строка";

            // Вызов метода Substring с помощью рефлексии
            MethodInfo substringMethod = typeof(string).GetMethod("Подстрока", new Type[] { typeof(int), typeof(int) });
            object result = substringMethod.Invoke(inputString, new object[] { 5, 7 });

            Console.WriteLine($"Подстрока: {result}");
        }
    }
}
