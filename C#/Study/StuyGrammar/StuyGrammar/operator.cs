using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuyGrammar
{
    class @operator
    {
        public int High { get; set; }
        public int Width { get; set; }
        public @operator(int h, int w)
        {
            High = h;
            Width = w;
        }

        //操作符重载 ，类似于method
        // 返回类型 operator 操作符 （参数） {语句块}
        public static @operator operator& (@operator boxA, @operator boxB)
        {
            int h = boxA.High + boxB.High;
            int w = boxA.Width + boxB.Width;
            @operator res = new @operator(h,w);
            return res;
        }

        static void Main(string[] args)
        {
            @operator A = new @operator(2, 4);
            @operator B = new @operator(1, 3);
            @operator C = A & B;
            Console.WriteLine(C.High);
            Console.WriteLine(C.Width);
            Console.ReadKey();


        }

    }
}
