using System;
using System.Globalization;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(" \r\nVocê deve fazer um programa que leia um valor qualquer e apresente uma mensagem" +
                " dizendo em qual dos \r\nseguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se" +
                " encontra. Obviamente se o valor não estiver em \r\nnenhum destes intervalos, deverá ser impressa" +
                " a mensagem “Fora de intervalo”. ");
            Console.WriteLine();

            Console.WriteLine("Digite um numero qualquer:");

            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("O intervalor de " + numero + " é entre");
            if (numero >= 0 && numero <= 25) {
                Console.WriteLine("[0, 25]");
            }
            else if (numero > 25 && numero <= 50) {
                Console.WriteLine("(25, 50]");
            }
            else if (numero > 50 && numero <= 75) {
                Console.WriteLine("(50, 75]");
            }
            else if (numero > 75 && numero <= 100) {
                Console.WriteLine("(75, 100]");

            }
            else {
                Console.WriteLine("Sem intervalo");

            }
        }
    }
}
