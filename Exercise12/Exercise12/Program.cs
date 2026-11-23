using System;
using System.Globalization;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(" \r\nLeia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas" +
                " \r\nde um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o \r\nponto," +
                " ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0)." +
                " \r\n \r\nSe o ponto estiver na origem, escreva a mensagem “Origem”." +
                " \r\n \r\nSe o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”," +
                " conforme for a \r\nsituação");
            Console.WriteLine();
            Console.WriteLine("Entre com as coordenadas x e y:");
            Console.WriteLine("Coordenada x: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Coordenada y: ");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string quadrante = "";

            Console.WriteLine("O quadrante é: ");

            if(x == 0.0 && y == 0.0) {
                quadrante = "Origem";

            }
            else if(x > 0.0 && y > 0.0) {
                quadrante = "Q1";
            }
            else if(x < 0.0 && y > 0.0) {
                quadrante = "Q2";
            }
            else if(x < 0.0 && y < 0.0) {
                quadrante = "Q3";
            }
            else{
                quadrante = "Q4";
            }

            Console.WriteLine(quadrante);
        }
    }
}
