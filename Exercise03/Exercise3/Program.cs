using System;
using System.Globalization;

namespace Exercise3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Faça um programa para ler dois valores inteiros, " +
                "e depois mostrar na tela a soma desses números com uma \r\nmensagem explicativa, " +
                "conforme exemplos.");

            Console.WriteLine();

            Console.WriteLine("Digite o primerio valor interio:");
            int primeiro_valor = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor inteiro:");
            int segundo_valor = int.Parse(Console.ReadLine());

            int soma = primeiro_valor + segundo_valor;

            Console.WriteLine();
            Console.WriteLine("SOMA = " + soma);

        }
    }
}
