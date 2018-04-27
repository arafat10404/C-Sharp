using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Array_All
{
    class ParamsArray
    {
        public void Show(params int[] val) // Params Paramater  
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }
        // Main function, execution entry point of the program  
        public static void Main(string[] args)
        {
            ParamsArray program = new ParamsArray(); // Creating Object  
            program.Show(2, 4, 6, 8, 10, 12, 14); // Passing arguments of variable length
            Console.ReadKey();
        }
    }
}
