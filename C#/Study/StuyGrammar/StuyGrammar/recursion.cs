using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuyGrammar
{
    class recursion
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fun(6));
        }

        static int Fun(int num)
        {
            if(num == 1)
            {
                return 1;
            }
            return num * Fun(num - 1);
			/*
			 运行时候 		           计算结果时候	.
				|	Fun(6)------>6*Fun(5)	↑
				|	Fun(5)------>5*Fun(4)	|
				|	Fun(4)------>4*Fun(3)	|
				|	Fun(3)------>3*Fun(2)	|
				|	Fun(2)------>2*Fun(1)   |
				↓	Fun(1)------>1			|	
									Fun(1)=1开始回调
			*/
        }
    }
}
