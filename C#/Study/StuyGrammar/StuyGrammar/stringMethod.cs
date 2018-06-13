using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuyGrammar
{
    class stringMethod
    {
        static void Main(string[] args)
        {
            string test = "that's cool~~";
            Console.WriteLine
                (
                "Length:{0}-IndexOf:{1}-Insert:{2}-Remove:{3}-Replace:{4}-Substring:{5}-Contains:{6}",
                //string.Length 返回sting长度
                test.Length,

                //string.IndexOf(value) 返回对应value所在的index值
                test.IndexOf("o"),

                //string.Insert(index,value) 在index值位置插入value
                test.Insert(8, "aoa"),

                //string.Remove(index) 移除index后的字符
                test.Remove(5),

                //string.Replace(oldValue,newValue) 将oldValue用newValue替换
                test.Replace("'", " i"),

                //string.Substing（index，Length） 移除index前的字符,并保留Length长度字符，Length缺省则index后面的全部保留
                test.Substring(6),
    
                //string.Contains(value) 包含value，返回ture，否则返回false
                test.Contains("s")
                );
            Console.ReadLine();
        }
    }
}
