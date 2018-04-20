using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    abstract class Foo
    {
        public abstract void M();
    }

    class Bar : Foo
    {
        public override void M()
        {
            Console.WriteLine("Bar.M");
        }
    }
    class Example
    {
        static void Main()
        {
            try
            {
                int[] arr = new int[5];
                arr[10] = 25;
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.GetType());
            }

            Foo b = new Bar();
            b.M();
        }
    }

}
