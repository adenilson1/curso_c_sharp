using System;
using System.Globalization;

namespace Course15 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X," +
                " um valor por linha, inclusive o \r\nX, se for o caso. ");

            Console.Write("Digite um número interio positvo: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++) {

                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
                
            }

        }
    }
}
