using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuyGrammar
{
    class forPyramid
    {
        static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

            //System.IO.StreamWriter IO = new System.IO.StreamWriter("test.txt");
            //Console.SetOut(IO);
            //DrawPyramid(5);

            //IO.Flush();

            string txt = System.IO.File.ReadAllText("test.txt");
            Console.Write(txt);
            Console.ReadLine();
        }
    }
}
