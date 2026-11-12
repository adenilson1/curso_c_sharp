using System;

namespace Course6 {
    class Program {
        static void Main(string[] args) {
            //Operadores Aritméticos

            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);
            Console.WriteLine("-----------------------------------");

            int n2 = (3 + 4) * 2;
            Console.WriteLine(n2);
            Console.WriteLine("-----------------------------------");

            int n3 = 17 % 3;
            Console.WriteLine(n3);
            Console.WriteLine("-----------------------------------");

            double n4 = 10.0 / 8;
            Console.WriteLine(n4);
            Console.WriteLine("-----------------------------------");

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b,2) - 4.0 * a * c;
            double x1, x2;

            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("O valor do delta eh: " + delta.ToString("F2"));
            Console.WriteLine("Os valores das raizes sao: " + x1.ToString("F2") + " e " + x2.ToString("F2"));


        }
    }
}
