using System;
using System.Globalization;

namespace Course15 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes." +
                " Escreva \r\num algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel \r\n4.Fim)." +
                " Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até \r\nque seja válido)." +
                " O programa será encerrado quando o código informado for o número 4." +
                " Deve ser escrito a \r\nmensagem: \"MUITO OBRIGADO\" e a quantidade de clientes que abasteceram cada tipo de combustível,");

            int qtd_gasolina = 0;
            int qtd_alcool = 0;
            int qtd_diessel = 0;
            int opcao = 0;

            while(opcao != 4) {
                Console.WriteLine();
                Console.WriteLine("Esolha o combustivel de sua preferencia: 1 - Álcool, 2 - Gasolina, 3 - Diessel e 4 - Sair");
                Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                if(opcao == 1 ) {
                    qtd_alcool += 1;
                }
                else if(opcao == 2) {
                    qtd_gasolina += 1;
                }
                else if(opcao == 3) {
                    qtd_diessel += 1;
                }
                else if(opcao == 4) {
                    Console.WriteLine("MUITO OBRIGADO");
                }
                else {
                    Console.WriteLine("Esolha uma opção válida");
                }
            }

            Console.WriteLine("Álcool: " + qtd_alcool);
            Console.WriteLine("Gasolina: " + qtd_gasolina);
            Console.WriteLine("Diessel: " + qtd_diessel);



        }
    }
}
