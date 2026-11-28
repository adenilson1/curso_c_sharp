using System;
using System.Globalization;

namespace Course15 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(" \r\nLeia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida." +
                " \r\nMostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo," +
                " mostrando \r\nessas informações conforme exemplo (use a palavra \"in\" para dentro do intervalo, e \"out\" para fora do intervalo). ");

            Console.Write("Digite um número inteiro: ");
            int qtd = int.Parse(Console.ReadLine());

            int[] vet = new int[qtd];
            int _in = 0;
            int _out = 0;

            for (int i = 0; i < qtd; i++ ) {
                vet[i] = int.Parse(Console.ReadLine());

                if (vet[i] >= 10 & vet[i] <= 20) {
                    _in++;
                }
                else {
                    _out++;
                }
            }

            Console.WriteLine(_in + " in");
            Console.WriteLine(_out + " out");
        }
    }
}
