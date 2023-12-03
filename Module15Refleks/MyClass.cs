using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Module15Refleks
{
    public class MyClass
    {
        public int FirstProperty { get; set; }
        public string SecondProperty { get; set; }
    }

    public class PropertyValues
    {
        public static void GetAndPrintValues()
        {
            MyClass myObject = new MyClass
            {
                FirstProperty = 42,
                SecondProperty = "Салам Рефлексия"
            };

            Type objectType = typeof(MyClass);
            PropertyInfo[] properties = objectType.GetProperties();

            Console.WriteLine("Значения свойств класса MyClass:");
            foreach (var property in properties)
            {
                object value = property.GetValue(myObject);
                Console.WriteLine($"  {property.Name}: {value}");
            }
        }
    }
}
