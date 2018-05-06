using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Collections_STL.LinkedList_LL
{
    class Descending_Ascending_Sort
    {
        public static void Main(String[] args)
        {
            var names = new LinkedList<string>();
            names.AddLast("Sonoo");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");

            names = new LinkedList<String>(names.OrderBy(i => i));      // Ascending order sort
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            names = new LinkedList<String>(names.OrderByDescending(i => i));        // Discending order sort
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
