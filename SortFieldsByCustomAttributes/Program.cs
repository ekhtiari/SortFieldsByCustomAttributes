using System;
using System.Linq;
using System.Reflection;

namespace SortFieldsByCustomAttributes
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var newClass = new Model();
            var fields = newClass.GetType().GetProperties();
            
            var result = fields.OrderBy(x => x.GetCustomAttributes<CustomAttribut>().First()._name);

            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}