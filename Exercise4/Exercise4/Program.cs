using System;
using System.Globalization;

namespace Exercise4 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine(" \r\nFaça um programa para ler o valor do raio de um círculo," +
                "e depois mostrar o valor da área deste círculo com quatro \r\ncasas decimais conforme exemplos." +
                "\r\n \r\nFórmula da área: area = π . raio2 \r\n \r\nConsidere o valor de π = 3.14159 ");

            Console.WriteLine();

            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Calculo da área
            double area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine();
            Console.WriteLine("Área = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
