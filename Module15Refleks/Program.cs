using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Module15Refleks
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 1: Список методов класса Console
            ConsoleMethods.PrintMethods();

            // Задача 2: Получение и вывод значений свойств из экземпляра MyClass
            PropertyValues.GetAndPrintValues();

            // Задача 3: Вызов метода Substring класса String с помощью рефлексии
            SubstringTask.CallSubstring();

            // Задача 4: Получение списка конструкторов класса List<T>
            ListConstructors.GetConstructors();

            Console.ReadLine();
        }
    }
}
