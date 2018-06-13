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

            //多维数组，
            //1维
            {
                //2维
                {
                    //3维
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

             //1维
            {
                //2维
                {
                    //3维
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

        //利用out返回三个值
        public void Math(out int max, out int min, out int sum)
        {
            max = multidimensionArray[0, 0, 1].Max();
            min = multidimensionArray[0, 0, 1].Min();
            sum = multidimensionArray[0, 1, 1].Sum();
        }
    }

    class MyClass
    {
        static void Main(string[] args)
        {
            
            arrayMethods p = new arrayMethods();

            //VS2017,out关键字修饰参数可以直接如下声明
            //p.Math(out int a,out int b, out int c);
            int a;
            int b;
            int c;
            p.Math(out a, out  b, out  c);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
 
}
