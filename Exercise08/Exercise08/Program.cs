using System;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem" +
                "\"Sao Multiplos\" ou \"Nao sao \r\nMultiplos\", indicando se os valores lidos são múltiplos entre si." +
                "Atenção: os números devem poder ser digitados em \r\nordem crescente ou decrescente.");
            Console.WriteLine();

            Console.WriteLine("Digite o primeiro número inteiro:");
            int primeiro_numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número inteiro:");
            int segundo_numero = int.Parse(Console.ReadLine());


            int resto = 0;
            if(primeiro_numero > segundo_numero) {
                resto = primeiro_numero % segundo_numero;
            }
            else {
                resto = segundo_numero % primeiro_numero;
            }

            if (resto == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}
