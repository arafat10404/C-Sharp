using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.String_All
{
    class Reverse_Sort_IEnumerator
    {
        public static void Main(String[] args)
        {
            String str = "redwan hossain";
            char[] ch = str.ToArray();

            string s2 = new string(ch);

            Array.Sort(ch);

            String[] st = { "b", "a", "d", "c" };
            Array.Sort(st);
            
            Console.WriteLine(ch);
            Console.WriteLine(s2 + " " + ch.Length);

            String srr = "";
            IEnumerator it = st.GetEnumerator();
            while (it.MoveNext())
            {
                 srr += it.Current.ToString();
                Console.WriteLine(srr);
            }
        }
    }
}
