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
        /*
         * 创建构造函数给类一次传两个参赋值
         * public @operator(int h, int w)
         * {
         *     High = h;
         *      Width = w;
         *   
         */

        //操作符重载 ，类似于method
        // 返回类型 operator 操作符 （参数） {语句块}
        public static @operator operator& (@operator boxA, @operator boxB)
        {
            int h = boxA.High + boxB.High;
            int w = boxA.Width + boxB.Width;

            //利用构造函数赋值，应该如下
            //@operator res = new @operator(h,w);

            @operator res = new @operator();
            res.High = h;
            res.Width = w;
            return res;
        }

        static void Main(string[] args)
        {
            //利用构造函数赋值
            //@operator A = new @operator(2, 4);
            //@operator B = new @operator(1, 3);

            //否则只能如下，先声明实例，然后一个一个的赋值
            @operator A = new @operator();
            A.High = 2;
            A.Width = 4;
            @operator B = new @operator();
            B.High = 1;
            B.Width = 3;
            @operator C = A & B;
            Console.WriteLine(C.High);
            Console.WriteLine(C.Width);
            Console.ReadKey();


        }

    }
}
