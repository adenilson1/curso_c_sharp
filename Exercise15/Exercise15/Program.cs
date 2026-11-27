using System;
using System.Globalization;

namespace Course15 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(" \r\nEscreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema \r\ncartesiano." +
                " Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo \r\nmenos uma de" +
                " duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). ");

            Console.Write("Digite o valor da coordenada 'x' : ");
            int coord_x = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor da coordenada 'y' : ");
            int coord_y = int.Parse(Console.ReadLine());

            while (coord_x != 0 & coord_y != 0) { 
                string quadrante = Quadrante(coord_x, coord_y);
                Console.WriteLine("As coordenadas então no: " + quadrante);
                Console.WriteLine();

                Console.Write("Digite o valor da coordenada 'x' : ");
                coord_x = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor da coordenada 'y' : ");
                coord_y = int.Parse(Console.ReadLine());

            }
        }

        static string Quadrante(int x, int y) {
            string q = " ";
            if (x> 0 & y > 0) {
                q = "primeiro";
            }
            else if(x < 0 & y > 0) {
                q = "segundo";
            }
            else if(x < 0 & y < 0) {
                q = "terceiro";
            }
            else {
                q = "quarto";
            }

            return q;
        }
    }
}
