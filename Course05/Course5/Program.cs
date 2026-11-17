using System;

namespace Course5 {
    class Program {
        static void Main(string[] args) {
            // Funções de Conversão Parte 1

            //float variavel = 4.5f;

            //double variavel2 = variavel; // Conversão implícita

            //Console.WriteLine(variavel2);

            //double variavel1;
            //float  variavel2;

            //variavel1 = 5.1;
            //variavel2 = (float)variavel1; // Conversão explícita (cast)
            //Console.WriteLine(variavel2);

            //double variavel1 = 5.1;
            //int variavel2;

            //variavel2 = (int)variavel1; // os valores decimais serao truncados, ou seja, o valor final sera 5
            //Console.WriteLine(variavel2);

            int variavel1 = 5;
            int variavel2 = 2;

            double resultado = (double) variavel1 / variavel2;

            Console.WriteLine(resultado);

        }
    }
}
