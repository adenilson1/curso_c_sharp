using System;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("\r\nLeia a hora inicial e a hora final de um jogo." +
                " A seguir calcule a duração do jogo, sabendo que o mesmo pode \r\ncomeçar em um dia e terminar em outro," +
                " tendo uma duração mínima de 1 hora e máxima de 24 horas. ");
            Console.WriteLine();

            Console.WriteLine("Hora inicial:");
            int hora_inicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Hora final:");
            int hora_final = int.Parse(Console.ReadLine());

            int tempo_de_jogo = hora_final - hora_inicial;

            if (hora_inicial == 0) {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else if (hora_final < hora_inicial) {
                tempo_de_jogo += 24;
                Console.WriteLine("O JOGO DUROU " + tempo_de_jogo + " HORA(S)");
            }
            else {
                Console.WriteLine("O JOGO DUROU " + tempo_de_jogo + " HORA(S)");
            }

        }
    }
}
