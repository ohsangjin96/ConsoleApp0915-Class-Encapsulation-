using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0915
{
    class MyCat
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }

    }
    class ClassTest1
    {
       
        static void Main()
        {

            MyCat c1 = new MyCat();
            
            int result = MyCat.Sum(5, 3);
            int a = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[a];
            for(int i = 0; i < arr.Length; i++)
            {
               string asd = Console.ReadLine();
                arr[i] = asd;
            }
            foreach(string b in arr)
            {
                Console.Write(b+" ");
            }

        }
    }
}
