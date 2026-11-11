using System;
using System.Globalization;

namespace Course3 {
    class Program {
        static void Main(string[] args) {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            //usando placeholder
            Console.WriteLine("{0} tem {1} anos e seu saldo é R$ {2:F2}", nome, idade, saldo);

            // usando concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e seu saldo é R$ " +
                saldo.ToString("F2", CultureInfo.InvariantCulture));

            // usando interpolação
            Console.WriteLine($"{nome} tem {idade} anos e seu saldo é R$ {saldo:F2}");
        }
    }
}