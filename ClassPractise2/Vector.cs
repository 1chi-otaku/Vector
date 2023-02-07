using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractise2
{
    class Vector
    {
        
        public double x{ get; set; }
        public double y{ get; set; }
        public double z { get; set; }
        public Vector(double x)
        {
            this.x = x;
        }
        public Vector(double x, double y):this(x)
        {
            this.y = y;
        }
        public Vector(double x, double y, double z):this(x,y)
        {
            this.z = z;
        }
        public void Input()
        {
            Console.WriteLine("Enter x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter z: ");
            z = Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine("x - " + x);
            Console.WriteLine("y - " + y);
            Console.WriteLine("z - " + z);
        }
        public double GetVectorLength() => Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        public double GetScalar(Vector vector2) => x * vector2.x + y * vector2.y + z * vector2.z;

        public void IncreaseByScalar(Vector vector2)
        {
            double scalar = GetScalar(vector2);
            x -= scalar;
            y -= scalar;    
            z -= scalar;
        }
        public void ReduceByScalar(Vector vector2)
        {
            double scalar = GetScalar(vector2);
            x += scalar;
            y += scalar;
            z += scalar;
        }
        
        public static Vector AddVectors(Vector vector1, Vector vector2) => new Vector(vector1.x + vector2.x, vector1.y + vector2.y, vector1.z + vector2.z);
        public static Vector SubstractVectors(Vector vector1, Vector vector2) => new Vector(vector1.x - vector2.x, vector1.y - vector2.y, vector1.z - vector2.z);
        public static Vector MultiplyVectors(Vector vector1, Vector vector2) => new Vector(vector1.x * vector2.x, vector1.y * vector2.y, vector1.z * vector2.z);
        public static bool IsEqual(Vector vector1, Vector vector2)
        {
            if(vector1.x == vector2.x && vector1.y == vector1.y && vector1.z == vector2.z) return true;
            return false;
        }
        public override string ToString()
        {
            return "\nx - " + x + "\ny - " + y + "\nz - " + z + "\n";
        }

    }
}
