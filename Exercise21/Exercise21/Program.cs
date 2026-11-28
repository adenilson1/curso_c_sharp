using System;
using System.Globalization;

namespace Course21 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Ler um número inteiro N e calcular todos os seus divisores. ");

            Console.Write("Digite um numero inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            for(int i =1; i <= numero; i++) {

                if(numero%i == 0) {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
