using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuyGrammar
{
    class foreachLoop
    {
        string [] a = { "asa", "aaasa", "adaasa", "assdasfa", "asdfgsa", "asfsdvcva", "asttta", "afdfssa" };
        void returnValue()
        {
            //var自适应类型
            foreach (var k in a)
            {
                Console.WriteLine(k);
            }
        }
        
        static void Main(string[] args)
        {
            foreachLoop p = new foreachLoop();
            p.returnValue();
            Console.ReadLine();
        }
    }
}
