using System;

namespace Couse9 {
    class Program {
        static void Main(string[] args) {

            int variavel = 10;
            bool c1 = variavel < 10;
            bool c2 = variavel < 20;
            bool c3 = variavel > 10;
            bool c4 = variavel > 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("------------------------------------");

            bool c5 = variavel <= 10;
            bool c6 = variavel >= 10;
            bool c7 = variavel == 10;
            bool c8 = variavel != 10;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
        }
    }
}
