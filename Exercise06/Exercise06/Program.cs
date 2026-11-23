using System;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Fazer um programa para ler um número" +
                " inteiro, e depois dizer se este número é negativo ou não.");
            Console.WriteLine();
            Console.WriteLine("Entre com um numero inteiro: ");
            int numero_inteiro = int.Parse(Console.ReadLine());

            if (numero_inteiro < 0) {
                Console.WriteLine("O número é negativo.");
            }
            else {
                Console.WriteLine("O número não é negativo.");
            }

        }
    }
}
