using System;
using System.Globalization;

namespace Course15 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("\r\nFazer um programa para ler um número inteiro positivo N." +
                " O programa deve então mostrar na tela N linhas, \r\ncomeçando de 1 até N." +
                " Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor," +
                " conforme \r\nexemplo. ");

            Console.Write("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());
            int[][] vet_principal = new int[numero][];


            for (int i = 0; i < numero; i++) {

                int n = i + 1;
                vet_principal[i] = new int[] {
                    n,
                    (int)Math.Pow(n, 2),
                    (int)Math.Pow(n, 3)
                };
            }

            for(int i = 0; i <vet_principal.Length; i++) {
                Console.WriteLine(vet_principal[i][0] + " " + vet_principal[i][1] + " " + vet_principal[i][2]);
            }

        }
    }
}



       
