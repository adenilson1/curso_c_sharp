using System;
using System.Globalization;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar" +
                " seus impostos, pois sabem \r\nque nele não existem políticos corruptos e os recursos arrecadados" +
                " são utilizados em benefício da população, sem \r\nqualquer desvio. A moeda deste país é o Rombus," +
                " cujo símbolo é o R$.");
            Console.WriteLine();

            Console.WriteLine("Digite o valor da sua renda: ");
            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0.0;

            Console.WriteLine("Valor de seu imposto de renda:");
            //sem imposto de renda entre 0 a 2000.00
            if(renda > 0 && renda <= 2000.00) {
                Console.WriteLine("Insento");
            }
            else if(renda > 2000.00 && renda <= 3000.00) { // 8% de imposto de renda entre 2000.01 a 3000.00    
                imposto = (renda - 2000.00) * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(renda > 3000.00 && renda <= 4500.00) { // 18% de imposto de renda entre 3000.01 a 4500.00
                imposto = (3000-2000) * 0.08 + (renda - 3000.00) * 0.18;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else { // 28% de imposto de renda acima de 4500.00
                imposto = (3000 - 2000) * 0.08 + (4500 - 3000) * 0.18 + (renda - 4500.00) * 0.28;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}