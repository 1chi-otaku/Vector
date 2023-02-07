using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Vector a = new Vector(1, 2, 3);
           Vector b = new Vector(2, 3, 4);
           Vector c = new Vector(0,0,0);

           Console.WriteLine("Vector a:" + a.ToString() );
           Console.WriteLine("Vector b:" + b.ToString() );
           Console.WriteLine("Enter vector c: \n");
           c.Input();
           Console.WriteLine("Vector c:" + c.ToString() + "");
           Console.WriteLine("Vector a lenght: " + a.GetVectorLength());
           Console.WriteLine("Vector b lenght: " + b.GetVectorLength());
           Console.WriteLine("Vector c lenght: " + c.GetVectorLength());
           Console.WriteLine("The vector a has been scaled up by the scalar a & b:");
           a.IncreaseByScalar(b);
           Console.WriteLine(a.ToString());
           Console.WriteLine("The vector b has been scaled down by the scalar b & c:");
           b.ReduceByScalar(c);
           Console.WriteLine(b.ToString());

           Vector d = Vector.AddVectors(a, b);
           Console.WriteLine("The sum of the vector a and b: " + d.ToString());

           d = Vector.SubstractVectors(a, b);
           Console.WriteLine("The difference of the vector a and b: " + d.ToString());
           
           d = Vector.MultiplyVectors(a, c);
           Console.WriteLine("The vector a and c have been multiplied: " + d.ToString());

           if(Vector.IsEqual(a,b) == true)
            {
                Console.WriteLine("a == b");
            }
            else
            {
                Console.WriteLine("a != b");
            }
        }
    }
}
