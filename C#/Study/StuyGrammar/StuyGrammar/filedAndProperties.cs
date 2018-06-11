using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuyGrammar
{
    class filedAndProperties
    {
        //filed字段
        private string name;

        //properties属性，一般编程规习惯约定属性和字段同名，首字母大写
        public string Name
        {
            //get访问器 访问字段的值
            //set存取器 改变储存字段的值
            get { return name; }
            set { name = value; }
        }
       
    }

    class main
    {
        static void Main(string[] args)
        {
            filedAndProperties O = new filedAndProperties();
            O.Name = "my name";
            Console.WriteLine(O.Name);
            Console.ReadKey();           
        }
    }
}
