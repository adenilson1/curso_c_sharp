using System;

namespace Course13 {
    class Program {

        static void Main(string[] args) {

            Console.WriteLine("Digite três numeros:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            double resultado = Maior(num1, num2, num3);

            Console.WriteLine("Maior = " + resultado);
        }

        static int Maior(int n1, int n2, int n3) {
            int m;

            if(n1 > n2 && n1 > n3) {
                m = n1;
            }
            else if(n2 > n3) {
                m = n2;
            }
            else {
                m = n3;
            }

            return m;
        }
    }
}