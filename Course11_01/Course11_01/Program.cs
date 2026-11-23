using System;

namespace Course11 {
    class Program {
        static void Main(string[] args) {
            // ESTRUTURA CONDICIONAL IF-ELSE

            Console.WriteLine("Qual a hora atual? ");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18) {
                Console.WriteLine("Boa tarde!");
            }

            else if (hora < 24) {
                Console.WriteLine("Boa noite!");
            }
            else {
                Console.WriteLine("Essa hora não existe!");
            }
        }
    }
}
