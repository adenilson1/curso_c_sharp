using System;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.");
            Console.WriteLine();
            Console.WriteLine("Digite um número inteiro:");
            int numero_par_impar = int.Parse(Console.ReadLine());

            if(numero_par_impar % 2 == 0) {
                Console.WriteLine("PAR");
            } else {
                Console.WriteLine("ÍMPAR");
            }
        }
    }
}
