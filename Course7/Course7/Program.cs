using System;

namespace Course6 {
    class Program {
        static void Main(string[] args) {
            
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();


            string[] vet = Console.ReadLine().Split(' ');


            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(vet[0] + " " + vet[1] + " " + vet[2]);
        }
    }
}
