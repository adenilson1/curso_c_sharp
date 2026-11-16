using System;
using System.Globalization;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo: ");
            string complete_name = Console.ReadLine();
  

            Console.WriteLine("Quantos quartos tem na sua casa ?");
            int number_of_rooms = int.Parse(Console.ReadLine());


            Console.WriteLine("Entre com o preço do produto:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu ultimo nome, idade e altura:");
            string[] vet = Console.ReadLine().Split(' ');
            string last_name = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);


            Console.WriteLine();
            Console.WriteLine("O que você digitou:");
            Console.WriteLine(complete_name);
            Console.WriteLine(number_of_rooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(last_name);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
