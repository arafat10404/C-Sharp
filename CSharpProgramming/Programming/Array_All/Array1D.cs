﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Array_All
{
    class Array1D
    {
        public static void Main(String[] arg)
        {
            int[] arr = new int[5];
            arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.ForEach(arr, Console.WriteLine);
            Console.ReadKey();
        }
    }
}
