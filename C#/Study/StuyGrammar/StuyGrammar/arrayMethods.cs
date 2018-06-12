using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuyGrammar
{
    class arrayMethods
    {
        int[,,][] multidimensionArray =
        {

            {
                {
                  new int[] {1,99},
                  new int[] {1,66}
                },
                {
                  new int[] {2,3},
                  new int[] {2,3}
                },
                {
                  new int[] {3,4},
                  new int[] {3,4}
                },
            },

            {
                 {
                  new int[] {1,51},
                  new int[] {1,52}
                },
                {
                  new int[] {2,61},
                  new int[] {2,62}
                },
                {
                  new int[] {3,71},
                  new int[] {3,72}
                },
            }
         };

        public void math(out int max,out int min,out int sum)
        {
            int arrayMax = multidimensionArray[0, 0, 1].Max();
            int arrayMin = multidimensionArray[0, 0, 1].Min();
            int arraySum = multidimensionArray[0, 1, 1].Sum();
            max = arrayMax;
            min = arrayMin;
            sum = arraySum;
        }
    }

    class MyClass
    {
        //private static int a;
        //private static int b;
        //private static int c;

        static void Main(string[] args)
        {
            int a;
            int b;
            int c;   
            arrayMethods p = new arrayMethods();
            p.math(out a,out  b,out  c);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
 
}
