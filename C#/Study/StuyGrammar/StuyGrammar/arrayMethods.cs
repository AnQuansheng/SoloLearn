using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuyGrammar
{
    class arrayMethods
    {
        int[,,][] multidimensionArray = new int[2, 3, 2][];

        /*
        数组的实例的index值是从0开始算起
        数组declare的时候，Length值不会从0开始算

        int[] a = new int[2]; 数组Length是2，可以填充两个数值
        a[3] = 5; 数组的第2个值，却是3

        多维数组同理，int[2,3,2][]
        = = = = = = = = =       
         new int[0,0,0]|         
         new int[0,1,0]|         
        ——————— —      
         new int[0,1,0]|         
         new int[0,1,1]|         
        ——————— —      
         new int[0,2,0]|         
         new int[0,2,1]|         
        = = = = = = = = =
         new int[1,0,0]| 
         new int[1,1,0]| 
        ——————— —
         new int[1,1,0]| 
         new int[1,1,1]| 
        ——————— —
         new int[1,2,0]| 
         new int[1,2,1]|   
        = = = = = = = = =    
                        
        */

        /*
        {

            //多维数组，
            //1维
            {
                //2维
                {
                    //3维
                    new int[] {1,11},
                    new int[] {1,12}
                },  
                {
                    new int[] {2,22},
                    new int[] {2,23}
                },  
                {
                    new int[] {3,33},
                    new int[] {3,34}
                },
            },

             //1维
            {
                //2维
                {
                    //3维
                    new int[] {4,44},
                    new int[] {4,45}
                },  
                {
                    new int[] {5,55},
                    new int[] {5,56}
                },  
                {
                    new int[] {6,66},
                    new int[] {6,67}
                },
            }
         };
         */

        //利用out返回三个值
        public void Math(out int max, out int min, out int sum)
        {
            
            multidimensionArray[0, 0, 0] = new int[] {1,12 };
            multidimensionArray[0, 0, 1] = new int[] {1,13 };
            multidimensionArray[0, 1, 0] = new int[] {1,13 };
            multidimensionArray[0, 1, 1] = new int[] {1,14 };
            multidimensionArray[0, 2, 0] = new int[] {1,15 };
            multidimensionArray[0, 2, 1] = new int[] {1,16 };
            multidimensionArray[1, 0, 0] = new int[] {1,17 };
            multidimensionArray[1, 0, 1] = new int[] {1,18 };
            multidimensionArray[1, 1, 0] = new int[] {1,19 };
            multidimensionArray[1, 1, 1] = new int[] {1,20 };
            multidimensionArray[1, 2, 0] = new int[] {1,21 };
            multidimensionArray[1, 2, 1] = new int[] {1,22 };

            max = multidimensionArray[0, 0, 0].Max();
            min = multidimensionArray[0, 0, 1].Max();
            sum = multidimensionArray[0, 1, 1].Max();

            //min = multidimensionArray[0, 0, 1].Min();
            //sum = multidimensionArray[0, 1, 1].Sum();
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
