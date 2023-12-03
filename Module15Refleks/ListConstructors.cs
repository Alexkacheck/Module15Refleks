using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Module15Refleks
{
    public class ListConstructors
    {
        public static void GetConstructors()
        {
            Type listType = typeof(List<>);
            ConstructorInfo[] constructors = listType.GetConstructors();

            Console.WriteLine("Конструкторы класса List<T>:");
            foreach (var constructor in constructors)
            {
                Console.WriteLine($"  {constructor}");
            }
        }
    }
}
