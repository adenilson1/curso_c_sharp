using System;
using System.Globalization;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Com base na tabela abaixo, escreva um programa que leia o código de um item e" +
                " a quantidade deste item. A \r\nseguir, calcule e mostre o valor da conta a pagar. ");
            Console.WriteLine();

            Console.WriteLine("### FAÇA O SEU PEDIDO ###");            
            Console.WriteLine("Digite o codigo do pedido:");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do pedido:");
            int quantidade = int.Parse(Console.ReadLine());

            double preco_do_pedido = 0.0;
            double total = 0.0;

            if(codigo == 1) {
                preco_do_pedido = 4.00;
            }
            else if(codigo == 2) {
                preco_do_pedido = 4.50;
            }
            else if(codigo == 3) {
                preco_do_pedido = 5.00;
            }
            else if(codigo == 4) {
                preco_do_pedido = 2.00;
            }
            else if(codigo == 5) {
                preco_do_pedido = 1.50;
            }
            else {
                Console.WriteLine("Código inválido.");
                quantidade = 0;
            }

            total = quantidade * preco_do_pedido;
            Console.WriteLine("Pagamento total R$" + total.ToString("F2"));


        }
    }
}
