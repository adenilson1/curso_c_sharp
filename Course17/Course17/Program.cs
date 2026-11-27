using System;
using System.Globalization;
using System.Linq;

namespace Course15 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos numeros inteiros você vai digitar? ");
            int qtd = int.Parse(Console.ReadLine());
            int soma = 0;
            int[] vet = new int[qtd];

            for (int i = 0; i < vet.Length; i++) {
                Console.Write("Valor #" + (i + 1) + ": ");
                vet[i] = int.Parse(Console.ReadLine());
                
            }
            soma = vet.Sum();
            Console.WriteLine("Soma = " + soma);

        }
    }
}
