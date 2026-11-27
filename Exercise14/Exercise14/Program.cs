using System;
using System.Globalization;

namespace Course15 {
    class Program {
        static void Main(string[] args) {

            int senha_correta = 2002;
            int senha_digitada = 0;

            while(senha_correta != senha_digitada) {
                Console.Write("Digite a senha: ");
                senha_digitada = int.Parse(Console.ReadLine());

                if(senha_digitada != senha_correta) {
                    Console.WriteLine("Senha Inválida");
                }
            }

            Console.WriteLine("Senha Permitida");

        }
    }
}
