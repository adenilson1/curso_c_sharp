using System;
using System.Globalization;

namespace Exercise5 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Fazer um programa para ler quatro valores inteiros A, B, C e D." +
                "A seguir, calcule e mostre a diferença do produto" +
                "\r\nde A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).");

            // valores
            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor de C: ");
            int c = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor de D: ");
            int d = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // calculo da diferença
            int resultado = a * b - c * d;

            // resultado
            Console.WriteLine("Resultado = " + resultado);


        }
    }
}
