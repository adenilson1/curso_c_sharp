using System;

namespace Course4 {
    class Program {
        static void Main(string[] args) {
            // Operadores de atribuição
            int a = 10;
            Console.WriteLine(a);

            a += 2; // a = a + 2
            Console.WriteLine(a);

            a -= 2; // a = a - 2
            Console.WriteLine(a);

            a *= 2; // a = a * 2
            Console.WriteLine(a);

            a /= 2; // a = a / 2
            Console.WriteLine(a);

            a %= 3; // a = a % 3
            Console.WriteLine(a);

            Console.WriteLine("---------------------------");
            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF"; // s = s + "DEF"
            Console.WriteLine(s);
            Console.WriteLine("---------------------------");

            int numero = 10;

            numero++;
            Console.WriteLine(numero);
            Console.WriteLine("---------------------------");

            numero = 10;
            int numero1 = numero++;
            Console.WriteLine(numero);
            Console.WriteLine(numero1);
            Console.WriteLine("---------------------------");

            numero = 10;
            int numero2 = ++numero;
            Console.WriteLine(numero);
            Console.WriteLine(numero2);



        }
    }
}
