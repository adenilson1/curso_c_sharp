using System;

namespace Course11 {
    class Program {
        static void Main(string[] args) {
            
            // Declaração e inicialização de variável
            double preco = double.Parse(Console.ReadLine()); // dentro do escopo principal, posso acessar a variável preco
            double valor_desconto = 0.0; // dentro do escopo principal, posso acessar a variável valor_desconto

            if (preco > 100.0) {
                double desconto = preco * 0.1; // dentro do escopo do if, posso acessar a variável desconto
                preco -= desconto; // posso acessar a variável preco, pois ela foi declarada no escopo principal
                valor_desconto = desconto; // posso acessar a variável valor_desconto,
                                           // pois ela foi declarada no escopo princi
            }

            Console.WriteLine("R$" +preco + " o desconto foi de R$" + valor_desconto); // posso acessar a variável preco,
                                                                                       // pois ela foi declarada no
                                                                                       // escopo principal

        }
    }
}
