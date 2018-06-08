using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuyGrammar
{

    class main
    {
        static void Main(string[] args)
        {
            //类实例化的时候，可以调用"类的构造函数"中的方法
            /*可以实现功能呢，比如"注册账户信息"的类中有一个方法是"发送邮件给注册人"，
                则每有一个人注册账户就会自动发送一个邮件给注册人。*/
            constructorCallMethod obj = new constructorCallMethod();
            Console.ReadLine();
        }
    }

    class constructorCallMethod
    {
        private int age;

        //类的构造函数
        public constructorCallMethod()
        {
            Console.WriteLine("hi here");
        }
    }
    
}
