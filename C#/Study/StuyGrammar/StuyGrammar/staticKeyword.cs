using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuyGrammar
{

    class staticKeyword
    {
        static void Main(string[] args)
        {
            //每个dog实例都是对同一个dogPP进行操作
            //d.dogpp值为1 d1.dogpp再加1值为2
            dog d = new dog();
            dog d1 = new dog();

            //每个cat实例都是一个新的catPP
            //c.catPP c1.catPP值都是1
            cat c = new cat();
            cat c1 = new cat();

            //"static" has global nature, static members can be accessed directly using the "class name" without an object.    
            Console.WriteLine(dog.dogPP);
            Console.WriteLine(c1.catPP);
            Console.ReadLine();
        }
    }

    class dog
    {
        //No matter how many "dog" objects are instantiated, 
        //there is always only one "dogPP" variable that belongs to the dog class because it was declared static.
        public static int dogPP = 0;
        public dog()
        {
            dogPP++;
        }
    }

    class cat
    {
        public int catPP = 0;
        public cat()
        {
            catPP++;
        }
    }

}
