using System;
using System.Globalization;

namespace Course15 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo \r\nsegundo." +
                " Se o denominador for igual a zero, mostrar a mensagem \"divisao impossivel\". ");

            Console.Write("Digite um numero inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            int aux = 0;


            while (aux < numero) {

                Console.Write("Digite o par #" + (aux+1) +": ");
                string[] entradas = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int[] vet = new int[entradas.Length];
                double resultado = 0.0;

                for(int i = 0; i < vet.Length; i++) {
                    vet[i] = int.Parse(entradas[i], CultureInfo.InvariantCulture);
                }

                for(int i = 0; i < vet.Length; i++) {
                    for(int j = vet.Length - 1; j > i; j--) {

                        if (vet[j] == 0) {
                            Console.WriteLine("Divisão impossível");
                        }
                        else {
                            resultado = (double) (vet[i] / (double) vet[j]);
                            Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                        }
                        Console.WriteLine();
                    }
                    

                }
                

                aux++;

            }
       

        }
    }
}
