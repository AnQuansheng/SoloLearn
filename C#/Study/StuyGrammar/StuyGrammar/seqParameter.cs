using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuyGrammar
{
    class seqParameter

    {
        static int Area(int h, int w)
        {
            return h / w;
        }
        static int Readline()
        {

            Console.WriteLine("par1");
            int par1 = Convert.ToInt32(Console.ReadLine());
            return par1;
        }
        static void Main(string[] args)
        {
			//自定义parameters 对应的 arguements
            int res = Area(w: Readline(), h: Readline());
            int seqRes = Area( Readline(), Readline());
            Console.WriteLine("res={0}",res);
            Console.WriteLine("seqRes={0}",seqRes);
            Console.ReadKey();
        }
    }
}
