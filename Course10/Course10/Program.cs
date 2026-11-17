using System;

namespace Couse10 {
    class Program {
        static void Main(string[] args) {

            bool c1 = 2 > 3 && 4 != 5; // E
            bool c2 = 2 > 3 || 4 != 5; // OU
            bool c3 = !(2 > 3) && 4 != 5; // Não
            bool c4 = (2 > 3) || !(4 != 5); // Não
            bool c5 = !(2 > 3) && !(4 != 5); // Não
            bool c6 = !(2 > 3) || !(4 != 5); // Não

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6);
        }
    }
}