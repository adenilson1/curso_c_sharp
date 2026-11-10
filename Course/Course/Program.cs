using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            bool completo = false; // true ou false
            char genero = 'F'; // caracter unico
            char letra = '\u0041'; // codigo unicode

            float n4 = 4.5f; // numero real de 32 bits
            double n5 = 4.5; // numero real de 64 bits

            string nome = "Maria Green"; // variável tipo referencia que recebe uma cadeia de caracteres, ele é do tipo imutável, ou seja, não pode ser alterado após a sua criação
            object obj1 = "Alex Brown"; // object é a superclasse de todos os tipos, ou seja, qualquer tipo pode ser atribuido a uma variável do tipo object
            object obj2 = 4.5f; // object é a superclasse de todos os tipos, ou seja, qualquer tipo pode ser atribuido a uma variável do tipo object

            byte n1 = 126; // numero inteiro de 0 a 255
            int n2 = 1000; // numero inteiro de -2.147.483.648 a 2.147.483.647
            long n3 = 2147483648; // numero inteiro de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807


            Console.WriteLine(completo);
            Console.WriteLine(letra);
            Console.WriteLine(genero);

            Console.WriteLine(n4);
            Console.WriteLine(n5);

            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);

            Console.WriteLine();

            // Valores minimos e máximos dos tipos numéricos
            int n6 = int.MinValue; // valor minimo do tipo int
            int n7 = int.MaxValue; // valor maximo do tipo int
            sbyte n8 = sbyte.MinValue; // valor minimo do tipo sbyte
            decimal n9 = decimal.MaxValue; // valor maximo do tipo decimal
            Console.WriteLine(n6);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
        }
    }
}
