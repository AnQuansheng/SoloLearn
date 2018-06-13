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
                test.Length,
                test.IndexOf("o"),
                test.Insert(8, "aoa"),
                test.Remove(5),
                test.Replace("'", " i"),
                test.Substring(6),
                test.Contains("s")
                );
            Console.ReadLine();
        }
    }
}
