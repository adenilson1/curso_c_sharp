using System;
using System.Globalization;

namespace Course15 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Ler um valor N. Calcular e escrever seu respectivo fatorial." +
                " Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1. \r\nLembrando que, por definição, fatorial de 0 é 1. ");

            Console.Write("Digite um numero inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = numero; i >= 0; i--) {
                if(i == 0 || i == 1) {
                    fatorial *= 1;
                }
                else if(i == numero) {
                    fatorial *= numero;
                }
                else {
                    fatorial *= i;
                }
            }

            Console.WriteLine(numero +"! = " + fatorial);
        }
    }
}
