using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearnDelegate
    {

        //定义委托，它定义了可以代表的方法的类型
        public delegate void GreetingDelegate(string name);

        
        class Program
        {

            private static void EnglishGreeting(string name)
            {
                Console.WriteLine("Morning, " + name);
            }

            private static void ChineseGreeting(string name)
            {
                Console.WriteLine("早上好, " + name);
            }

            //注意此方法，它接受一个GreetingDelegate类型的方法作为参数
            private static void GreetPeople(string name, GreetingDelegate MakeGreeting)
            {
                MakeGreeting(name);
            }

            static void Main(string[] args)
            {
                GreetPeople("Jimmy Zhang", EnglishGreeting);
                GreetPeople("张子阳", ChineseGreeting);
                Console.ReadKey();
            }
        }
    }
