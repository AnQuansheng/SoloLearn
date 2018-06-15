using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region 以数组举例
namespace StuyGrammar
{
    class indexers
    {
       
        private int[][] arrayTest =
            {
                new int[] { 1,10 },
                new int[] { 2, 20 },
                new int[] { 3,30 }

            };

        //indexer索引器的使用类似属性
        /*
            
            Type this [int var]
            {   
                get{}
                set{}      
            }
        */
        public int[] this[int i]
        {
            get { return arrayTest[i]; }
            set { arrayTest[i] = value; }
        }

    }

    class main
    {
        static void Main (string[] args)
        {
            
            indexers P = new indexers();
           
            Console.WriteLine(P[0].Max());
            Console.WriteLine(P[1].Max());
            Console.WriteLine(P[2].Max());
            Console.ReadLine();
        }
    }
}
#endregion




#region 以类为举例
namespace CSharp_Text
{
    class vectorA
    {
        public double x, y, z;

        public vectorA(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public vectorA()
        {
        }

        public override string ToString()
        {
            return "(" + x + "," + y + "," + z + ")";
        }

        public double this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        return x;
                    case 1:
                        return y;
                    case 2:
                        return z;
                    default:
                        throw new IndexOutOfRangeException("Attempt to retrieve vectorA element" + i);
                }
            }
            set
            {
                switch (i)
                {
                    case 0:
                        x = value;
                        break;
                    case 1:
                        y = value;
                        break;
                    case 2:
                        z = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException("Attempt to set vectorA element" + i);
                }
            }
        }
    }

    class main
    {
        static void MMain()
        {
            vectorA vect1 = new vectorA(1, -2, 4.1);
            vectorA vect2 = new vectorA();
            Console.WriteLine("vect1 = " + vect1);
            Console.WriteLine("vect1[1] = " + vect1[1]);
            for (int i = 0; i < 3; i++)
            {
                vect2[i] = i;
            }
            Console.WriteLine("vect2 = " + vect2);
            Console.ReadLine();
        }
    }
}

#endregion