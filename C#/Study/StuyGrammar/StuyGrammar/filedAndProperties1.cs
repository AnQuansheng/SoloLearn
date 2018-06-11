using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuyGrammar
{
    class filedAndProperties1
    {
        /*
        public int publicAge { get; set; }相当于
        private int publicAge;
        public int _publicAge
        {
            get{return publicAge;}        
            set{publicAge = value;}
        }
        */
        public int publicAge { get; set; }
        private int privateAge;
        public int cool
        {
            get { return privateAge; }
            set { privateAge = value; }
                   
        }
        public void writePrivateProperties()
        {
            Console.WriteLine(privateAge);
        }
    }

    class main
    {
         public static void Main(string[] args)
            {
                filedAndProperties1 Opublic = new filedAndProperties1();
                Opublic.cool = 10;
                Opublic.publicAge = 20;
                Opublic.writePrivateProperties();
                Console.WriteLine(Opublic.publicAge);
                Console.WriteLine(Opublic.cool);
                Console.ReadLine();
            }
    }
}
