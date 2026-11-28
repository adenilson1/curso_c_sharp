using System;
using System.Globalization;
using System.Net.Quic;
using System.Runtime.Serialization;

namespace Course18 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste" +
                " \r\nde 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes \r\nconjuntos de 3 valores," +
                " sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem \r\npeso 5. ");

            Console.Write("Digite um numero inteiro positivo: ");
            int qtd_testes = int.Parse(Console.ReadLine());
            int aux = 0;
            

            while (aux < qtd_testes) {

                Console.WriteLine("Digite tres valores decimais: ");
                string[] entradas = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                double[] vetor = new double[entradas.Length];
                double soma = 0.0;

                for (int i = 0; i < entradas.Length; i++) {
                    vetor[i] = double.Parse(entradas[i], CultureInfo.InvariantCulture);
                }

                for (int i = 0; i < vetor.Length; i++) {
                    
                    if (i == 0) {
                        soma += 2 * vetor[i];
                    }
                    else if (i == 1) {
                        soma += 3 * vetor[i];
                    }
                    else {
                        soma += 5 * vetor[i];
                    }

                }

                Console.WriteLine("Media Ponderada = " + (soma / (2 + 3 + 5)).ToString("F1", CultureInfo.InvariantCulture));


                aux++;

            }
            
        }
    }
}
