using System;

namespace Course11 {
    class Program {
        static void Main(string[] args) {
            // ESTRUTURA CONDICIONAL IF-ELSE

            Console.WriteLine("Entre com um numero inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) {
                Console.WriteLine("Par");
            }
            else {
                Console.WriteLine("Impar");
            }
        }
    }
}
